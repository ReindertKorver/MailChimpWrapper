using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Remove a campaign from your Mailchimp account.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaigns/delete-campaign/">Docs /campaigns/{campaign_id}</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="EmptyResponse"/>
    /// </para>
    /// </summary>
    public class CampaignDeleteRequest : IBaseRequest
    {
        internal readonly string _id;

        public CampaignDeleteRequest(string id)
        {
            _id = id;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Delete; }
    }
}