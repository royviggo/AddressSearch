using GeonorgeAddressSearch;
using GeonorgeAddressSearch.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System;

var serviceProvider = new ServiceCollection()
    .AddGeonorgeAddressSearch()
    .BuildServiceProvider();

var geonorgeAddressSearchService = serviceProvider.GetService<IGeonorgeAddressSearchService>();
if (geonorgeAddressSearchService == null)
{
    Console.WriteLine("Could not create a GeonorgeAddressSearchService");
    return;
}

try
{
    var searchResult = await geonorgeAddressSearchService.SearchAsync(new AddressSearchRequest
    {
        Sok = "storgat* mo*",
        Sokemodus = SearchMode.AND,
    });

    Console.WriteLine($"Number of hits: {searchResult.Metadata.TotaltAntallTreff}, showing the {searchResult.Metadata.TreffPerSide} first:");
    foreach (var address in searchResult.Adresser)
    {
        Console.WriteLine($"{address.Adressetekst}, {address.Postnummer} {address.Poststed}");
    }
}
catch (Exception ex) when (ex is ApiException)
{
    Console.WriteLine($"Error calling GeonorgeAddressSearchService: {ex}");
}
