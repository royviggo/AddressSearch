using System.Collections.Generic;

namespace GeonorgeAddressSearch
{
    public class OutputAdressList
    {
        public ICollection<OutputAdress> Adresser { get; set; }

        public HitMetadata Metadata { get; set; }
    }
}