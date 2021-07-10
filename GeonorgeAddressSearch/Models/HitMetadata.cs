namespace GeonorgeAddressSearch
{
    public class HitMetadata
    {
        /// <summary>Garanterer at dataene som returneres er ascii-kompatible.</summary>
        public bool? AsciiKompatibel { get; set; } = true;

        /// <summary>Sidenummeret som vises. Første side = 0</summary>
        public int? Side { get; set; } = 0;

        /// <summary>Søkestrengen som ble sendt inn til API-et.</summary>
        public string SokeStreng { get; set; }

        /// <summary>Antall treff som søket returnerte.</summary>
        public int? TotaltAntallTreff { get; set; }

        /// <summary>Antall treff per side.</summary>
        public int? TreffPerSide { get; set; } = 10;

        /// <summary>Hvilket resultatnummer det første objektet du ser har.</summary>
        public int? ViserFra { get; set; }

        /// <summary>Hvilket resultatnummer det siste objektet du ser har.</summary>
        public int? ViserTil { get; set; }
    }
}