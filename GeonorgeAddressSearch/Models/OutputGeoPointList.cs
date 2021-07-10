using System.Collections.Generic;

namespace GeonorgeAddressSearch
{
    public class OutputGeoPointList
    {
        public ICollection<OutputGeoPoint> Adresser { get; set; }

        public HitMetadata Metadata { get; set; }
    }
}