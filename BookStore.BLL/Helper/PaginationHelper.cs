namespace ShopNest.BLL.Helpers
{
    using Microsoft.EntityFrameworkCore;

    namespace ShopNest.BLL.Helpers
    {
        public class PaginationHelper<T>
        {
            public List<T> Items { get; set; } = new();

            public int TotalItems { get; set; }

            public int CurrentPage { get; set; }

            public int PageSize { get; set; }

            public int TotalPages =>
                (int)Math.Ceiling((double)TotalItems / PageSize);

            public bool HasNext => CurrentPage < TotalPages;

            public bool HasPrevious => CurrentPage > 1;

            public static async Task<PaginationHelper<T>> CreateAsync(IQueryable<T> source,int page,int pageSize)
            {
                var totalItems = await source.CountAsync();

                var items = await source
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return new PaginationHelper<T>
                {
                    Items = items,
                    TotalItems = totalItems,
                    CurrentPage = page,
                    PageSize = pageSize
                };
            }
        }
    }
}