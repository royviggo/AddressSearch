using GeonorgeAddressSearch.Extensions;
using GeonorgeAddressSearch.Utils;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace GeonorgeAddressSearch
{
    public class GeonorgeAddressSearchService : IGeonorgeAddressSearchService
    {
        private readonly GeonorgeAddressSearchOptions _geonorgeAddressSearchOptions = new()
        {
            BaseUrl = "https://ws.geonorge.no/adresser/v1",
        };
        private readonly HttpClient _httpClient;

        public GeonorgeAddressSearchService(HttpClient httpClient, IOptions<GeonorgeAddressSearchOptions> options)
        {
            _httpClient = httpClient;
            GeonorgeAddressSearchOptions = options.Value;
        }

        private GeonorgeAddressSearchOptions GeonorgeAddressSearchOptions
        {
            get => _geonorgeAddressSearchOptions;
            init
            {
                if (!string.IsNullOrEmpty(value.BaseUrl))
                {
                    _geonorgeAddressSearchOptions.BaseUrl = value.BaseUrl;
                }
            }
        }

        private JsonSerializerOptions JsonSerializerOptions =>
            new()
            {
                PropertyNameCaseInsensitive = true,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                }
            };

        public async Task<OutputAdressList> SearchAsync(AddressSearchRequest addressSearch)
        {
            var uri = AddressSearchUrlBuilder(GeonorgeAddressSearchOptions.BaseUrl, addressSearch);

            return await _httpClient.GetFromJsonAsync<OutputAdressList>(uri, JsonSerializerOptions);
        }

        public async Task<OutputAdressList> SearchAsync(AddressSearchRequest addressSearch, CancellationToken cancellationToken)
        {
            var uri = AddressSearchUrlBuilder(GeonorgeAddressSearchOptions.BaseUrl, addressSearch);

            return await _httpClient.GetFromJsonAsync<OutputAdressList>(uri, JsonSerializerOptions, cancellationToken);
        }

        private static string AddressSearchUrlBuilder(string baseUrl, AddressSearchRequest addressSearch)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder
                .Append(baseUrl != null ? baseUrl.TrimEnd('/') : "")
                .Append("/sok?");

            urlBuilder.AddParameter("poststed", ValueConvertUtil.ConvertToString(addressSearch.Poststed));
            urlBuilder.AddParameter("adressetilleggsnavn", ValueConvertUtil.ConvertToString(addressSearch.AdresseTilleggsnavn));
            urlBuilder.AddParameter("postnummer", ValueConvertUtil.ConvertToString(addressSearch.Postnummer));
            urlBuilder.AddParameter("kommunenummer", ValueConvertUtil.ConvertToString(addressSearch.Kommunenummer));
            urlBuilder.AddParameter("adressekode", ValueConvertUtil.ConvertToString(addressSearch.Adressekode));
            urlBuilder.AddParameter("nummer", ValueConvertUtil.ConvertToString(addressSearch.Nummer));
            urlBuilder.AddParameter("side", ValueConvertUtil.ConvertToString(addressSearch.Side));
            urlBuilder.AddParameter("bruksnummer", ValueConvertUtil.ConvertToString(addressSearch.Bruksnummer));
            urlBuilder.AddParameter("utkoordsys", ValueConvertUtil.ConvertToString(addressSearch.UtKoordSys));
            urlBuilder.AddParameter("adressetekst", ValueConvertUtil.ConvertToString(addressSearch.Adressetekst));
            urlBuilder.AddParameter("bokstav", ValueConvertUtil.ConvertToString(addressSearch.Bokstav));
            urlBuilder.AddParameter("kommunenavn", ValueConvertUtil.ConvertToString(addressSearch.Kommunenavn));
            urlBuilder.AddParameter("objtype", ValueConvertUtil.ConvertToString(addressSearch.ObjektType));
            urlBuilder.AddParameter("bruksenhetsnummer", ValueConvertUtil.ConvertToString(addressSearch.Bruksenhetsnummer));
            urlBuilder.AddParameter("adressenavn", ValueConvertUtil.ConvertToString(addressSearch.Adressenavn));
            urlBuilder.AddParameter("undernummer", ValueConvertUtil.ConvertToString(addressSearch.Undernummer));
            urlBuilder.AddParameter("treffPerSide", ValueConvertUtil.ConvertToString(addressSearch.TreffPerSide));
            urlBuilder.AddParameter("sokemodus", ValueConvertUtil.ConvertToString(addressSearch.Sokemodus));
            urlBuilder.AddParameter("filtrer", ValueConvertUtil.ConvertToString(addressSearch.Filtrer));
            urlBuilder.AddParameter("gardsnummer", ValueConvertUtil.ConvertToString(addressSearch.Gardsnummer));
            urlBuilder.AddParameter("sok", ValueConvertUtil.ConvertToString(addressSearch.Sok));
            urlBuilder.AddParameter("asciiKompatibel", ValueConvertUtil.ConvertToString(addressSearch.AsciiKompatibel));
            urlBuilder.AddParameter("festenummer", ValueConvertUtil.ConvertToString(addressSearch.Festenummer));

            urlBuilder.Length--;
            return urlBuilder.ToString();
        }
    }
}
