using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Create a new Mailchimp campaign.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/add-campaign/">Docs /campaigns</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignResponse"/>
    /// </para>
    /// </summary>
    public class CampaignNewPostRequest : Campaign, IBaseRequest
    {
        public CampaignNewPostRequest()
        {
        }

        public CampaignNewPostRequest(CampaignType type = CampaignType.regular)
        {
            Type = type;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Campaigns; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }
    }
}