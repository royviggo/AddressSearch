using GeonorgeAddressSearch.Exceptions;
using System.Threading;
using System.Threading.Tasks;

namespace GeonorgeAddressSearch
{
    public interface IGeonorgeAddressSearchService
    {
        /// <summary>Standard søk.</summary>
        /// <param name="addressSearch"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<OutputAdressList> SearchAsync(AddressSearchRequest addressSearch, CancellationToken cancellationToken = default);
    }
}