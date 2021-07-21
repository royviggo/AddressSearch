namespace AddressSearch.Web.Models
{
    public class SearchViewModel : AddressViewModel
    {
        public string Search { get; set; }
        public string SearchMode { get; set; }

        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
