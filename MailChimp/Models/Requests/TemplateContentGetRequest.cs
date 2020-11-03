using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get the sections that you can edit in a template, including each section's default content.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/template-default-content/view-default-content/">Docs /templates/{template_id}/default-content</see>
    /// </para>
    /// </summary>
    public class TemplateContentGetRequest : IBaseRequest
    {
        private readonly string _queryParams;
        private readonly int _id;

        public TemplateContentGetRequest(int id, string queryParams = "")
        {
            _queryParams = queryParams;
            _id = id;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Templates + "/" + _id + "/default-content" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}