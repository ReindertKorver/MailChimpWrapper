using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Creates a Resend to Non-Openers version of this campaign. We will also check if this campaign meets the criteria for Resend to Non-Openers campaigns.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/resend-campaign/">Docs /campaigns/{campaign_id}/actions/create-resend</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignResponse"/>
    /// </para>
    /// </summary>
    public class CampaignResendRequest : IBaseRequest
    {
        internal readonly string _id;

        public CampaignResendRequest(string id)
        {
            _id = id;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}/actions/create-resend"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }
    }
}