namespace GeonorgeAddressSearch
{
    public class AddressSearchRequest
    {
        /// <summary>
        /// Navn på gate, veg, sti, plass eller område som er ført i matrikkelen (eksempel Sørumvegen).
        /// </summary>
        public string Adressenavn { get; set; }

        /// <summary>
        /// Offisiell adresse som tekststreng (eksempel «Ven, Sørumvegen 45»), men uten eventuelt bruksenhetsnummer for leiligheter
        /// </summary>
        public string Adressetekst { get; set; }

        /// <summary>
        /// Del av adressenummer (husnummer) som er et nummer og eventuelt en bokstav, f.eks 23B
        /// </summary>
        public int? Nummer { get; set; }

        /// <summary>
        /// Del av adressenummer (husnummer) som er et nummer og en eventuelt en bokstav, f.eks 23B. For å kun søke på adresser uten noen
        /// bokstav så inkluderer man "bokstav=" i søkestrengen uten å fylle inn noen verdi.
        /// </summary>
        public string Bokstav { get; set; }

        /// <summary>
        /// Nummer som entydig identifiserer adresserbare gater, veger, stier, plasser og områder som er ført i matrikkelen innen kommunen
        /// </summary>
        public int? Adressekode { get; set; }

        /// <summary>
        /// Nedarvet bruksnavn, navn på en institusjon eller bygning eller grend brukt som del av den offisielle adressen
        /// </summary>
        public string AdresseTilleggsnavn { get; set; }

        /// <summary>
        /// Unik identifikasjon av et postnummerområde. Tekstverdi som må bestå av 4 tall. 0340 er for eksempel gyldig, mens 340 er ikke gyldig.
        /// </summary>
        public string Postnummer { get; set; }

        /// <summary>
        /// Navn på poststed i henhold til Postens egne lister
        /// </summary>
        public string Poststed { get; set; }

        /// <summary>
        /// Nummerering av kommunen i henhold til Statistisk sentralbyrå sin offisielle liste. Tekstverdi som må bestå av 4 tall.
        /// 0301 er for eksempel gyldig, mens 301 er ikke gyldig.
        /// </summary>
        public string Kommunenummer { get; set; }

        /// <summary>
        /// Navn (norsk) på en kommune
        /// </summary>
        public string Kommunenavn { get; set; }

        /// <summary>
        /// Vegadresse er offisiell adresse i form av et adressenavn og et adressenummer (Storgata 10). Der kommunen ikke har gått over
        /// til vegadresser, vil det finnes matrikkeladresse på formen: gårdsnummer/ bruksnummer/ev festenummer-ev undernummer (10/2)
        /// Begge adressetypene kan ha bruksenhetsnummer (leiligheter) og adressetilleggsnavn. Begge adressetypene vises som standard,
        /// hvis man kun ønsker å se en av de kan man spesifisere adressetypen via dette parameteret.
        /// </summary>
        public Objtype? ObjektType { get; set; }

        /// <summary>
        /// Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet (grunneiendom
        /// eller feste, - gir her ikke knyting mot seksjon)
        /// </summary>
        public int? Gardsnummer { get; set; }

        /// <summary>
        /// Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet (grunneiendom eller
        /// feste, - gir her ikke knyting mot seksjon)
        /// </summary>
        public int? Bruksnummer { get; set; }

        /// <summary>
        /// Fortløpende nummerering av matrikkeladresser med samme gårds-, bruks- og festenummer.
        /// </summary>
        public int? Undernummer { get; set; }

        /// <summary>
        /// Del av offisiell adresse (bruksenhetsnummer) til f.eks en leilighet i flerboligbygg. Bokstaven og de to første tallene angir
        /// etasje, de to siste angir leilighetens nummer i etasjen, regnet fra venstre mot høyre. Eksempel: "H0102", "K0101"
        /// </summary>
        public string Bruksenhetsnummer { get; set; }

        /// <summary>
        /// Del av en matrikkeladresse der vegadresse ikke er innført, - eller vegadressens knytning til matrikkelenhet
        /// (grunneiendom eller feste, - gir her ikke knytning mot seksjon)
        /// </summary>
        public int? Festenummer { get; set; }

        /// <summary>
        /// Koordinatsystem som adressegeometrien skal returneres i. Oppgis som srid, f.eks. 25833 eller 3857. Standardinnstilling er 4258
        /// </summary>
        public int? UtKoordSys { get; set; }

        /// <summary>
        /// Sidenummeret som vises. Første side = 0
        /// </summary>
        public int? Side { get; set; }

        /// <summary>
        /// Antall treff per side.
        /// </summary>
        public int? TreffPerSide { get; set; }

        /// <summary>
        /// Generelt adressesøk over nesten alle feltene. Wildcard-søk med "*" er støttet. Flere detaljer vil gi mer nøyaktige søk.
        /// Bare legg til ekstra opplysninger adskilt med mellomrom. F.eks.: ?sok=munkegata 1 trondheim
        /// </summary>
        public string Sok { get; set; }

        /// <summary>
        /// Modifiserer "sok"-feltet, standardverdi er "AND". Velg om søket skal kreve at hver eneste søkeparameter finnes i treffet,
        /// eller om det holder med treff på kun ett parameter. F.eks. vil "?sok=munkegata 1 trondheim&amp;sokemodus=OR" returnere alt
        /// som inneholder "munkegata" OG/ELLER tallet "1" OG/ELLER "trondheim".
        /// </summary>
        public SearchMode? Sokemodus { get; set; }

        /// <summary>
        /// Kommaseparert liste med objekter du ikke ønsker å filtrere ut. For å hente ut underobjekter bruk "."-notasjon, f.eks.:
        /// &amp;filtrer=adresser.kommunenummer,adresser.representasjonspunkt
        /// </summary>
        public string Filtrer { get; set; }

        /// <summary>
        /// Garanterer at dataene som returneres er ascii-kompatible.
        /// </summary>
        public bool? AsciiKompatibel { get; set; }
    }
}
