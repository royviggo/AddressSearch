namespace GeonorgeAddressSearch
{
    public class GeomPoint
    {
        /// <summary>Koordinatsystem til punktet. Angitt vha EPSG-kode.</summary>
        public string Epsg { get; set; }

        /// <summary>Geografiske lat/nord koordinater, med mindre annet er spesifisert.</summary>
        public double Lat { get; set; }

        /// <summary>Geografiske lon/øst koordinater, med mindre annet er spesifisert.</summary>
        public double Lon { get; set; }
    }
}
