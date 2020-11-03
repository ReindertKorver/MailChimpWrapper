using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Create a new template for the account. Only Classic templates are supported.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/templates/add-template/">Docs /templates</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="TemplateResponse"/>
    /// </para>
    /// </summary>
    public class TemplatePostRequest : IBaseRequest
    {
        private readonly string _queryParams;

        public TemplatePostRequest(string name, string html, string queryParams = "")
        {
            _queryParams = queryParams;
            Name = name;
            Html = html;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Templates + "/" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("folder_id")]
        public string FolderId { get; set; }
    }
}