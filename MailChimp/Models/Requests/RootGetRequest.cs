using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get links to all other resources available in the API.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/root/list-api-root-resources/">Docs /</see>
    /// </para>
    /// <para>
    /// Because this request does not require any values you can also use <see cref="MailChimpClient.GetRequest"></see>
    /// </para>
    /// </summary>
    public class RootGetRequest : IBaseRequest
    {
        string IBaseRequest.Endpoint { get => Endpoints.Root; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}