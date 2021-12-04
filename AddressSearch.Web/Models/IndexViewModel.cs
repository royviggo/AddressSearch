using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AddressSearch.Web.Models
{
    public class IndexViewModel : SearchViewModel
    {
        public IEnumerable<SelectListItem> SearchModeList => new List<SelectListItem>
        {
            new SelectListItem { Value = "0", Text = "Alle ordene" },
            new SelectListItem { Value = "1", Text = "Ett av ordene" },
        };

        public PaginatedList<AddressViewModel> SearchResults { get; set; }

        public string ErrorMessage { get; set; }
    }
}
