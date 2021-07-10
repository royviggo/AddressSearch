using AddressSearch.Web.Models;
using System.Linq;
using GeonorgeAddressSearch;

namespace AddressSearch.Web.Mappings
{
    public static class GeonorgeAddressSearchMapping
    {
        public static AddressSearchRequest Map(IndexViewModel model)
        {
            return new()
            {
                Sok = model.Search,
                Sokemodus = (SearchMode?)int.Parse(model.SearchMode),
                Side = model.PageIndex - 1,
                TreffPerSide = model.PageSize,

                //Adressenavn = null,
                //Adressetekst = null,
                //Nummer = null,
                //Bokstav = null,
                //Adressekode = null,
                //AdresseTilleggsnavn = null,
                //Postnummer = null,
                //Poststed = null,
                //Kommunenummer = null,
                //Kommunenavn = null,
                //ObjektType = null,
                //Gardsnummer = null,
                //Bruksnummer = null,
                //Undernummer = null,
                //Bruksenhetsnummer = null,
                //Festenummer = null,
                //UtKoordSys = null,
                //Filtrer = null,
                //AsciiKompatibel = null
            };
        }

        public static AddressViewModel Map(OutputAdress address)
        {
            return new()
            {
                AddressName = address.Adressenavn,
                AddressText = address.Adressetekst,
                Number = address.Nummer,
                Letter = address.Bokstav,
                PostCode = address.Postnummer,
                City = address.Poststed,
                CountyNumber = address.Kommunenummer,
                County = address.Kommunenavn,
            };
        }

        public static PaginatedList<AddressViewModel> Map(OutputAdressList addressList)
        {
            return new PaginatedList<AddressViewModel>(
                addressList.Adresser.Select(Map),
                addressList.Metadata.TotaltAntallTreff,
                addressList.Metadata.Side + 1,
                addressList.Metadata.TreffPerSide);
        }
    }
}
