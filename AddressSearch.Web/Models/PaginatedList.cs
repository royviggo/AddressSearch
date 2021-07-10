using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressSearch.Web.Models
{
    public class PaginatedList<T> : List<T>
    {
        public PaginatedList(IEnumerable<T> items, int? totalItems, int? pageIndex, int? pageSize)
        {
            AddRange(items.ToList());
            TotalItems = totalItems ?? Count;
            PageIndex = pageIndex ?? 1;
            PageSize = pageSize ?? 10;
            TotalPages = (int)Math.Ceiling(TotalItems / (decimal)PageSize);
        }

        public int TotalItems { get; }
        public int PageIndex { get; }
        public int PageSize { get; }
        public int TotalPages { get; }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public int FirstPage => 1;
        public int LastPage => TotalPages;
        public int PreviousPage => PageIndex > 1 ? PageIndex - 1 : PageIndex;
        public int NextPage => PageIndex < TotalPages ? PageIndex + 1 : PageIndex;
    }
}
