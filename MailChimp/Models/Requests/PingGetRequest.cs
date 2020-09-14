using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// A health check for the API that won't return any account-specific information.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/ping/ping/">Docs /ping</see>
    /// </para>
    /// <para>
    /// Because this request does not require any values you can also use <see cref="MailChimpClient.GetRequest"></see>
    /// </para>
    /// </summary>
    public class PingGetRequest : IBaseRequest
    {
        string IBaseRequest.Endpoint { get => Endpoints.Ping; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}