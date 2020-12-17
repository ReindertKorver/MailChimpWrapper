using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Set the content for a campaign.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/campaign-content/set-campaign-content/">Docs /campaigns/{campaign_id}/content</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="CampaignContentResponse"/>
    /// </para>
    /// </summary>
    public class CampaignContentEditRequest : IBaseRequest
    {
        private readonly string _id;

        public CampaignContentEditRequest(string campaignId)
        {
            _id = campaignId;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}/content"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Put; }

        [JsonPropertyName("plain_text")]
        public string PlainText { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("template")]
        public CampaignTemplate Template { get; set; }

        [JsonPropertyName("archive")]
        public Archive Archive { get; set; }

        [JsonPropertyName("variate_contents")]
        public List<object> VariateContents { get; set; }
    }
}