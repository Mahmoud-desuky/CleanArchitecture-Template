using CleanArchitecture.Application.Common.Models;

namespace CleanArchitecture.Application.Common.Extensions;

public static class QueryableExtensions
{
    public static async Task<PaginatedList<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize)
    {
        var count = await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.CountAsync(source);
        var items = await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync(
            source.Skip((pageNumber - 1) * pageSize).Take(pageSize));

        return new PaginatedList<T>(items, count, pageNumber, pageSize);
    }
}
