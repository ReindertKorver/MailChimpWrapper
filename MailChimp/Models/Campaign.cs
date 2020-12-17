using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Campaign
    {
        public Campaign()
        {
        }

        public Campaign(Campaign c)
        {
            Id = c.Id;
            WebId = c.WebId;
            ParentCampaignId = c.ParentCampaignId;
            Type = c.Type;
            Recipients = c.Recipients;
            Settings = c.Settings;
            VariateSettings = c.VariateSettings;
            Tracking = c.Tracking;
            RssOpts = c.RssOpts;
            AbSplitOpts = c.AbSplitOpts;
            SocialCard = c.SocialCard;
            CreateTime = c.CreateTime;
            ArchiveUrl = c.ArchiveUrl;
            LongArchiveUrl = c.LongArchiveUrl;
            EmailsSent = c.EmailsSent;
            SendTime = c.SendTime;
            ContentType = c.ContentType;
            NeedsBlockRefresh = c.NeedsBlockRefresh;
            HasLogoMergeTag = c.HasLogoMergeTag;
            Resendable = c.Resendable;
            Links = c.Links;
        }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("web_id")]
        public int WebId { get; set; }

        [JsonPropertyName("parent_campaign_id")]
        public string ParentCampaignId { get; set; }

        [JsonPropertyName("type")]
        public CampaignType Type { get; set; }

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

        [JsonPropertyName("ab_split_opts")]
        public AbSplitOpts AbSplitOpts { get; set; }

        [JsonPropertyName("social_card")]
        public SocialCard SocialCard { get; set; }

        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        [JsonPropertyName("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonPropertyName("long_archive_url")]
        public string LongArchiveUrl { get; set; }

        [JsonPropertyName("emails_sent")]
        public int EmailsSent { get; set; }

        [JsonPropertyName("send_time")]
        public string SendTime { get; set; }

        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        [JsonPropertyName("needs_block_refresh")]
        public bool NeedsBlockRefresh { get; set; }

        [JsonPropertyName("has_logo_merge_tag")]
        public bool HasLogoMergeTag { get; set; }

        [JsonPropertyName("resendable")]
        public bool Resendable { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }
    }

    /// <summary>
    /// There are four types of campaigns you can create in Mailchimp. A/B Split campaigns have been deprecated and variate campaigns should be used instead.
    /// <para>
    /// Possible values: "regular", "plaintext", "absplit", "rss", or "variate".
    /// </para>
    /// </summary>
    public enum CampaignType
    {
        regular,
        plaintext,
        absplit,
        rss,
        variate
    }
}