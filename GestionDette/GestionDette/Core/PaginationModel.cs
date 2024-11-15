using Microsoft.EntityFrameworkCore;

namespace Cours.Core;

public class PaginationModel<T>
{
    // Design Pattern Builder

    // Total Items 10 clients
    // Total pages 4 pages
    // PageSize 3
    // Page
    public List<T> Items { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int TotalItems { get; set; }
    public int PageSize { get; set; }
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < TotalPages;

    private PaginationModel(List<T> items, int totalItems, int pageSize, int currentPage)
    {
        Items = items;
        TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        TotalItems = totalItems;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    // public PaginationModel()
    // {
    // }

    public static async Task<PaginationModel<T>> Paginate(IQueryable<T> data, int pageSize, int currentPage)
    {
        var elements = await data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        var count = await data.CountAsync();
        // return new PaginationModel<T>()
        // {
        //     Items = elements,
        //     TotalItems = count,
        //     PageSize = pageSize,
        //     CurrentPage = currentPage
        // };

        return new PaginationModel<T>(elements, count, pageSize, currentPage);
    }


}