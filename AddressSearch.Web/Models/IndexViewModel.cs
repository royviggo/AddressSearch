using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using GeonorgeAddressSearch;

namespace AddressSearch.Web.Models
{
    public class IndexViewModel
    {
        public string Search { get; set; }
        public string SearchMode { get; set; }
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public List<SelectListItem> SearchModeList = new()
        {
            new SelectListItem { Value = "0", Text = "Alle ordene" },
            new SelectListItem { Value = "1", Text = "Ett av ordene" },
        };

        public PaginatedList<AddressViewModel> SearchResults { get; set; }

        public string ErrorMessage { get; set; }
    }
}
