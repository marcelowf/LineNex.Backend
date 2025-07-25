namespace LineNex.Core.Models
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Items { get; init; } = Enumerable.Empty<T>();
        public int TotalCount { get; init; }
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public int TotalPages =>
            (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}