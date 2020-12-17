using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
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
    public class CampaignEditRequest : IBaseRequest
    {
        private readonly string _id;

        public CampaignEditRequest(string id)
        {
            _id = id;
        }

        public CampaignEditRequest(Campaign c)
        {
            _id = c.Id;
            Recipients = c.Recipients;
            Settings = c.Settings;
            VariateSettings = c.VariateSettings;
            Tracking = c.Tracking;
            RssOpts = c.RssOpts;
            SocialCard = c.SocialCard;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Campaigns}/{_id}"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Patch; }

        [JsonPropertyName("recipients")]
        public Recipients Recipients { get; set; }

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }

        [JsonPropertyName("variate_settings")]
        public VariateSettings VariateSettings { get; set; }

        [JsonPropertyName("tracking")]
        public Tracking Tracking { get; set; }

        [JsonPropertyName("rss_opts")]
        public RssOpts RssOpts { get; set; }

        [JsonPropertyName("social_card")]
        public SocialCard SocialCard { get; set; }
    }
}