using System;
using System.Text;

namespace GeonorgeAddressSearch.Extensions
{
    public static class UriBuilderExtension
    {
        public static StringBuilder AddParameter(this StringBuilder uriBuilder, string key, string value)
        {
            if (value != null)
            {
                uriBuilder.Append(Uri.EscapeDataString(key))
                    .Append('=')
                    .Append(Uri.EscapeDataString(value))
                    .Append('&');
            }

            return uriBuilder;
        }
    }
}
