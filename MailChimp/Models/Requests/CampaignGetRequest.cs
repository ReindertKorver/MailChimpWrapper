using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// /// <summary>
    /// Get information about a specific campaign.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/get-campaign-info/">Docs /campaigns/{campaign_id}</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignResponse"/>
    /// </para>
    /// </summary>
    public class CampaignGetRequest : IBaseRequest
    {
        internal readonly string _queryParams;
        internal readonly string _id;

        public CampaignGetRequest(string id, string queryParams = "")
        {
            _queryParams = queryParams;
            _id = id;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Campaigns + "/" + _id + "" + _queryParams; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}