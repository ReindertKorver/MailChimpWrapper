using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// /// <summary>
    /// Get all campaigns in an account.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/list-campaigns/">Docs /campaigns</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignsResponse"/>
    /// </para>
    /// <para>
    /// Because this request does not require any values you can also use <see cref="MailChimpClient.GetRequest"></see>
    /// </para>
    /// </summary>
    public class CampaignsGetRequest : IBaseRequest
    {
        private readonly string _queryParams;

        public CampaignsGetRequest(string queryParams = "")
        {
            _queryParams = queryParams;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}{_queryParams}"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}