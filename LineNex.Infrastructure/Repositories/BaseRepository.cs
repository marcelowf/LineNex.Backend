using Microsoft.EntityFrameworkCore;
using LineNex.Core.Interfaces;
using LineNex.Infrastructure.Context;
using System.Linq.Expressions;
using LineNex.Core.Models;

namespace LineNex.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TFilters> : IBaseRepository<TEntity, TFilters>
        where TEntity : class
        where TFilters : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public async Task<PagedResult<TEntity>> GetAll(TFilters filters, int pageIndex, int pageSize)
        {
            var query = sqlContext.Set<TEntity>().AsQueryable();

            if (filters != null)
            {
                foreach (var filterProp in typeof(TFilters).GetProperties())
                {
                    var value = filterProp.GetValue(filters);
                    if (value == null)
                        continue;

                    var entityParam = Expression.Parameter(typeof(TEntity), "x");
                    var entityProp = Expression.Property(entityParam, filterProp.Name);

                    Expression predicateBody;

                    if (filterProp.PropertyType == typeof(string))
                    {
                        var notNull = Expression.NotEqual(entityProp, Expression.Constant(null, typeof(string)));
                        var containsMethod = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) })!;
                        var containsCall = Expression.Call(entityProp, containsMethod, Expression.Constant((string)value));
                        predicateBody = Expression.AndAlso(notNull, containsCall);
                    }
                    else
                    {
                        var constant = Expression.Constant(value, filterProp.PropertyType);
                        predicateBody = Expression.Equal(entityProp, constant);
                    }

                    var lambda = Expression.Lambda<Func<TEntity, bool>>(predicateBody, entityParam);
                    query = query.Where(lambda);
                }
            }
            query = query.OrderBy(x => EF.Property<object>(x, "Id"));

            var total = await query.CountAsync();
            var items = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<TEntity>
            {
                Items = items,
                TotalCount = total,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }

        public async Task<PagedResult<TEntity>> GetAllInclude(TFilters filters, int pageIndex, int pageSize)
        {
            var query = sqlContext.Set<TEntity>().AsQueryable();

            if (filters != null)
            {
                foreach (var filterProp in typeof(TFilters).GetProperties())
                {
                    var value = filterProp.GetValue(filters);
                    if (value == null)
                        continue;

                    var entityParam = Expression.Parameter(typeof(TEntity), "x");
                    var entityProp = Expression.Property(entityParam, filterProp.Name);

                    Expression predicateBody;

                    if (filterProp.PropertyType == typeof(string))
                    {
                        var notNull = Expression.NotEqual(entityProp, Expression.Constant(null, typeof(string)));
                        var containsMethod = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) })!;
                        var containsCall = Expression.Call(entityProp, containsMethod, Expression.Constant((string)value));
                        predicateBody = Expression.AndAlso(notNull, containsCall);
                    }
                    else
                    {
                        var constant = Expression.Constant(value, filterProp.PropertyType);
                        predicateBody = Expression.Equal(entityProp, constant);
                    }

                    var lambda = Expression.Lambda<Func<TEntity, bool>>(predicateBody, entityParam);
                    query = query.Where(lambda);
                }
            }

            var navProps = typeof(TEntity).GetProperties().Where(p => p.PropertyType.IsClass && p.PropertyType != typeof(string));

            foreach (var navProp in navProps)
            {
                var parameter = Expression.Parameter(typeof(TEntity), "x");
                var navAccess = Expression.Property(parameter, navProp.Name);
                var includeLambda = Expression.Lambda(navAccess, parameter);

                var includeMethod = typeof(EntityFrameworkQueryableExtensions)
                    .GetMethods()
                    .First(m => m.Name == "Include" && m.GetParameters().Length == 2 && m.GetGenericArguments().Length == 2)
                    .MakeGenericMethod(typeof(TEntity), navProp.PropertyType);

                query = (IQueryable<TEntity>)includeMethod
                    .Invoke(null, new object[] { query, includeLambda })!;
            }

            query = query.OrderBy(x => EF.Property<object>(x, "Id"));

            var total = await query.CountAsync();
            var items = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<TEntity>
            {
                Items = items,
                TotalCount = total,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }

        public async Task<TEntity> Create(Guid authorId, TEntity entity)
        {
            if (!await AuthorExists(authorId))
            {
                return null;
            }

            await sqlContext.Set<TEntity>().AddAsync(entity);
            await sqlContext.SaveChangesAsync(authorId);
            return entity;
        }

        public async Task<TEntity> Update(Guid authorId, Guid id, TEntity entity)
        {
            if (!await AuthorExists(authorId))
                return null;

            var existingEntity = await GetById(id);
            if (existingEntity == null)
                return null;

            var propsToSkip = new[] { "Id", "CreatedAt", "CreatedById" };
            var entityProperties = typeof(TEntity).GetProperties();

            foreach (var prop in entityProperties)
            {
                if (propsToSkip.Contains(prop.Name))
                    continue;

                var dtoValue = prop.GetValue(entity);
                if (dtoValue != null)
                    prop.SetValue(existingEntity, dtoValue);
            }

            await sqlContext.SaveChangesAsync(authorId);
            return existingEntity;
        }

        public async Task<bool> Delete(Guid id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            sqlContext.Set<TEntity>().Remove(entity);
            await sqlContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            var property = typeof(TEntity).GetProperty("IsDeleted");
            if (property != null)
            {
                property.SetValue(entity, true);
                sqlContext.Entry(entity).State = EntityState.Modified;
                await sqlContext.SaveChangesAsync();
                return true;
            }

            return false;
        }

        private async Task<TEntity> GetById(Guid id)
        {
            return await sqlContext.Set<TEntity>().FindAsync(id);
        }

        private async Task<bool> AuthorExists(Guid authorId)
        {
            return await sqlContext.User.AnyAsync(u => u.Id == authorId);
        }
    }
}
