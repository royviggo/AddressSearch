namespace GeonorgeAddressSearch
{
    public class GeonorgeAddressSearchOptions : IGeonorgeAddressSearchOptions
    {
        public static string Section => "GeonorgeAddressSearch";

        public string BaseUrl { get; set; }
    }
}
