using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get information about all lists in the account.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/lists/">Docs /lists</see>
    /// </para>
    /// <para>
    /// Because this request does not require any values you can also use <see cref="MailChimpClient.GetRequest"></see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="ListsResponse"/>
    /// </para>
    /// </summary>
    public class ListsGetRequest : IBaseRequest
    {
        private readonly string _queryParams;

        public ListsGetRequest(string queryParams = "")
        {
            _queryParams = queryParams;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Lists + "/" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}