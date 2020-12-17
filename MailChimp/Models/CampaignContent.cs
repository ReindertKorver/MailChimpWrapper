using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class CampaignContent
    {
        [JsonPropertyName("variate_contents")]
        public List<VariateContent> VariateContents { get; set; }

        [JsonPropertyName("plain_text")]
        public string PlainText { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("archive_html")]
        public string ArchiveHtml { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }
    }
}