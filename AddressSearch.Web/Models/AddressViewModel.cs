namespace AddressSearch.Web.Models
{
    public class AddressViewModel
    {
        public string AddressName { get; set; }
        public string AddressText { get; set; }
        public int? Number { get; set; }
        public string Letter { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string CountyNumber { get; set; }
        public string County { get; set; }
        public int? AddressCode { get; set; }
        public string AddressExtraName { get; set; }

        public int? Gardsnummer { get; set; }
        public int? Bruksnummer { get; set; }
        public int? Undernummer { get; set; }
        public int? Festenummer { get; set; }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Epsg { get; set; }
    }
}
