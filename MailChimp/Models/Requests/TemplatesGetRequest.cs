using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get a list of an account's available templates.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/templates/list-templates/">Docs /templates</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="TemplateContentResponse"/>
    /// </para>
    /// </summary>
    public class TemplatesGetRequest : IBaseRequest
    {
        private readonly string _queryParams;

        public TemplatesGetRequest(string queryParams = "")
        {
            _queryParams = queryParams;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Templates + "/" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}