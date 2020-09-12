using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class RssOpts
    {
        [JsonPropertyName("feed_url")]
        public string FeedUrl { get; set; }

        [JsonPropertyName("frequency")]
        public string Frequency { get; set; }

        [JsonPropertyName("schedule")]
        public Schedule Schedule { get; set; }

        [JsonPropertyName("constrain_rss_img")]
        public bool ConstrainRssImg { get; set; }
    }
}