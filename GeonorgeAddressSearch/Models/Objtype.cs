using System.Runtime.Serialization;

namespace GeonorgeAddressSearch
{
    /// <summary>Vegadresse er offisiell adresse i form av et adressenavn og et adressenummer (Storgata 10). Der kommunen ikke har gått over til vegadresser, vil det finnes matrikkeladresse på formen: gårdsnummer/ bruksnummer/ev festenummer-ev undernummer (10/2) Begge adressetypene kan ha bruksenhetsnummer (leiligheter) og adressetilleggsnavn. Begge adressetypene vises som standard, hvis man kun ønsker å se en av de kan man spesifisere adressetypen via dette parameteret.</summary>
    public enum Objtype
    {
        [EnumMember(Value = @"Vegadresse")]
        Vegadresse = 0,

        [EnumMember(Value = @"Matrikkeladresse")]
        Matrikkeladresse = 1,
    }
}