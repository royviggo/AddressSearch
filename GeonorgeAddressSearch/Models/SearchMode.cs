using System.Runtime.Serialization;

namespace GeonorgeAddressSearch
{
    /// <summary>Modifiserer "sok"-feltet, standardverdi er "AND". Velg om søket skal kreve at hver eneste søkeparameter finnes i treffet, eller om det holder med treff på kun ett parameter. F.eks. vil "?sok=munkegata 1 trondheim&amp;sokemodus=OR" returnere alt som inneholder "munkegata" OG/ELLER tallet "1" OG/ELLER "trondheim".</summary>
    public enum SearchMode
    {
        [EnumMember(Value = @"AND")]
        AND = 0,

        [EnumMember(Value = @"OR")]
        OR = 1,
    }
}