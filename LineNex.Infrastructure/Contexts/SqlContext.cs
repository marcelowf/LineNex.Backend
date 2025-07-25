using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using LineNex.Application.Utilitys;
using LineNex.Domain.Entity;
using LineNex.Domain.Entity;

namespace LineNex.Infrastructure.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<DistributionPoint> DistributionPoint { get; set; }
        public DbSet<DistributionPointMachine> DistributionPointMachine { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Layout> Layout { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<MachineConnection> MachineConnection { get; set; }
        public DbSet<MachineSensor> MachineSensor { get; set; }
        public DbSet<MachineSensorData> MachineSensorData { get; set; }
        public DbSet<ProductionLine> ProductionLine { get; set; }
        public DbSet<ProductionLineMachine> ProductionLineMachine { get; set; }
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserCompany> UserCompany { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<InventoryDistributionPoint> InventoryDistributionPoint { get; set; }
        public DbSet<DistributionPointStock> DistributionPointStock { get; set; }
        public DbSet<MachineTag> MachineTag { get; set; }
        public DbSet<ApplicationToken> ApplicationToken { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var userGuid = Guid.Parse("D17E004B-2335-4850-8A8A-4597CF73F862");

            // Users
            var users = new List<User>
            {
                new User
                {
                    Id             = userGuid,
                    Name           = "Marcelo Wzorek Filho",
                    Email          = "marcelo.projects.dev@gmail.com",
                    Password       = "XYZ",
                    RoleId         = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById    = userGuid,
                    CreatedAt      = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    EmailConfirmed = true,
                    IsDeleted      = false
                }
            };
            modelBuilder.Entity<User>().HasData(users);

            // Roles
            var roles = new List<Role>
            {
                new Role
                {
                    Id           = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Administrator",
                    Code         = "ADMIN",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new Role
                {
                    Id           = Guid.Parse("A7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Standard User",
                    Code         = "USER",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);

            // Permissions
            var permissions = new List<Permission>
            {
                new Permission
                {
                    Id           = Guid.Parse("17EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Reader",
                    Code         = "RDR",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new Permission
                {
                    Id           = Guid.Parse("27EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Create",
                    Code         = "CRT",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new Permission
                {
                    Id           = Guid.Parse("37EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Update",
                    Code         = "UPD",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new Permission
                {
                    Id           = Guid.Parse("47EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    Name         = "Delete",
                    Code         = "DEL",
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                }
            };
            modelBuilder.Entity<Permission>().HasData(permissions);

            // RolePermissions
            var rolePermissions = new List<RolePermission>
            {
                new RolePermission
                {
                    Id           = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    RoleId       = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    PermissionId = Guid.Parse("17EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new RolePermission
                {
                    Id           = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    RoleId       = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    PermissionId = Guid.Parse("27EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new RolePermission
                {
                    Id           = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    RoleId       = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    PermissionId = Guid.Parse("37EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new RolePermission
                {
                    Id           = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    RoleId       = Guid.Parse("B7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    PermissionId = Guid.Parse("47EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                },
                new RolePermission
                {
                    Id           = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    RoleId       = Guid.Parse("A7EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    PermissionId = Guid.Parse("17EC40E3-9BE7-4201-B2A6-13FB71D41E94"),
                    CreatedById  = userGuid,
                    CreatedAt    = DateTime.Parse("2025-01-01 23:59:59.9999999"),
                    IsDeleted    = false
                }
            };
            modelBuilder.Entity<RolePermission>().HasData(rolePermissions);

            // foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            // {
            //     if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            //     {
            //         modelBuilder.Entity(entityType.ClrType)
            //             .HasQueryFilter(CreateQueryFilter(entityType.ClrType));
            //     }
            // }
        }

        private static LambdaExpression CreateQueryFilter(Type entityType)
        {
            var parameter = Expression.Parameter(entityType, "e");

            var isDeletedFalse = Expression.Equal(Expression.Property(parameter, "IsDeleted"), Expression.Constant(false));
            var createdByIdNotEmpty = Expression.NotEqual(Expression.Property(parameter, "CreatedById"), Expression.Constant(Guid.Empty));

            return Expression.Lambda(Expression.AndAlso(isDeletedFalse, createdByIdNotEmpty), parameter);
        }

        public async Task<int> SaveChangesAsync(Guid authorId, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTimeZone.HrBrasilia(DateTime.UtcNow);
                    entry.Property("CreatedById").CurrentValue = authorId;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifiedAt").CurrentValue = DateTimeZone.HrBrasilia(DateTime.UtcNow);
                    entry.Property("ModifiedById").CurrentValue = authorId;
                }
            }

            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}