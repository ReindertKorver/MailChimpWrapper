using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get information about all lists in the account.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/lists/">Docs /lists</see>
    /// </para>
    /// </summary>
    public class ListsGetRequest : IBaseRequest
    {
        internal readonly string _queryParams;

        public ListsGetRequest(string queryParams = "")
        {
            _queryParams = queryParams;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Lists + "/" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}