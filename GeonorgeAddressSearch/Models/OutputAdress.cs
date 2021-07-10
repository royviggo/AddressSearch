using System;
using System.Collections.Generic;

namespace GeonorgeAddressSearch
{
    public class OutputAdress
    {
        /// <summary>Nummer som entydig identifiserer adresserbare gater, veger, stier, plasser og områder som er ført i matrikkelen innen kommunen</summary>
        public int? Adressekode { get; set; }

        /// <summary>Navn på gate, veg, sti, plass eller område som er ført i matrikkelen (eksempel Sørumvegen).</summary>
        public string Adressenavn { get; set; }

        /// <summary>Del av offisiell adresse, men uten bruksenhetsnummer som ligger til bruksenheter/boliger (ligger her som egenskap til vegadressen) Eksempel: "Storgata 2B" eller "123/4-2" Der det i tillegg er adressetilleggsnavn: "Haugen, Storgata 2B" eller "Midtgard, 123/4-2"</summary>
        public string Adressetekst { get; set; }

        /// <summary>Del av offisiell adresse, men uten bruksenhetsnummer som ligger til bruksenheter/boliger og adressetilleggsnavn Eksempel: "Storgata 2B" eller "123/4-2"</summary>
        public string Adressetekstutenadressetilleggsnavn { get; set; }

        /// <summary>Nedarvet bruksnavn, navn på en institusjon eller bygning eller grend brukt som del av den offisielle adressen</summary>
        public string Adressetilleggsnavn { get; set; }

        /// <summary>Del av adressenummer (husnummer) som er et nummer og eventuelt en bokstav, f.eks 23B</summary>
        public int? Nummer { get; set; }

        /// <summary>Del av adressenummer (husnummer) som er et nummer og en eventuelt en bokstav, f.eks 23B. For å kun søke på adresser uten noen bokstav så inkluderer man "bokstav=" i søkestrengen uten å fylle inn noen verdi.</summary>
        public string Bokstav { get; set; }

        /// <summary>Unik identifikasjon av et postnummerområde. Tekstverdi som må bestå av 4 tall. 0340 er for eksempel gyldig, mens 340 er ikke gyldig.</summary>
        public string Postnummer { get; set; }

        /// <summary>Navn på poststed i henhold til Postens egne lister</summary>
        public string Poststed { get; set; }

        public ICollection<string> Bruksenhetsnummer { get; set; }

        /// <summary>Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet (grunneiendom eller feste, - gir her ikke knyting mot seksjon)</summary>
        public int? Bruksnummer { get; set; }

        /// <summary>Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet (grunneiendom eller feste, - gir her ikke knytning mot seksjon)</summary>
        public int? Festenummer { get; set; }

        /// <summary>Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet (grunneiendom eller feste, - gir her ikke knyting mot seksjon)</summary>
        public int? Gardsnummer { get; set; }

        /// <summary>Navn (norsk) på en kommune</summary>
        public string Kommunenavn { get; set; }

        /// <summary>Nummerering av kommunen i henhold til Statistisk sentralbyrå sin offisielle liste. Tekstverdi som må bestå av 4 tall. 0301 er for eksempel gyldig, mens 301 er ikke gyldig.</summary>
        public string Kommunenummer { get; set; }

        /// <summary>Vegadresse er offisiell adresse i form av et adressenavn og et adressenummer (Storgata 10). Der kommunen ikke har gått over til vegadresser, vil det finnes matrikkeladresse på formen: gårdsnummer/ bruksnummer/ev festenummer-ev undernummer (10/2) Begge adressetypene kan ha bruksenhetsnummer (leiligheter) og adressetilleggsnavn. Begge adressetypene vises som standard, hvis man kun ønsker å se en av de kan man spesifisere adressetypen via dette parameteret.</summary>
        public Objtype? Objtype { get; set; }

        /// <summary>Dato for siste endring på objektdataene</summary>
        public DateTimeOffset? Oppdateringsdato { get; set; }

        public GeomPoint Representasjonspunkt { get; set; }

        /// <summary>Angivelse om stedfestingen (koordinatene) er kontrollert og funnet i orden (verifisert)</summary>
        public bool? Stedfestingverifisert { get; set; }

        /// <summary>Fortløpende nummerering av matrikkeladresser med samme gårds-, bruks- og festenummer.</summary>
        public int? Undernummer { get; set; }
    }
}