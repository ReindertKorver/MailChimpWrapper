using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Update some or all of the settings for a specific campaign.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/update-campaign-settings/">Docs /campaigns/{campaign_id}</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignResponse"/>
    /// </para>
    /// </summary>
    public class CampaignEditRequest : Campaign, IBaseRequest
    {
        private readonly string _id;

        public CampaignEditRequest(string id)
        {
            _id = id;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Patch; }
    }
}