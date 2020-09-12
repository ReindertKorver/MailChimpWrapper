using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Send a Mailchimp campaign. For RSS Campaigns, the campaign will send according to its schedule. All other campaigns will send immediately.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/send-campaign/">Docs /campaigns/{campaign_id}/actions/send</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="EmptyResponse"/>
    /// </para>
    /// </summary>
    public class CampaignSendRequest : IBaseRequest
    {
        internal readonly string _id;

        public CampaignSendRequest(string id)
        {
            _id = id;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}/actions/send"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }
    }
}