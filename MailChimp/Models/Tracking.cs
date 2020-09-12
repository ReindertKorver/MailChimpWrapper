using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Tracking
    {
        [JsonPropertyName("opens")]
        public bool Opens { get; set; }

        [JsonPropertyName("html_clicks")]
        public bool HtmlClicks { get; set; }

        [JsonPropertyName("text_clicks")]
        public bool TextClicks { get; set; }

        [JsonPropertyName("goal_tracking")]
        public bool GoalTracking { get; set; }

        [JsonPropertyName("ecomm360")]
        public bool Ecomm360 { get; set; }

        [JsonPropertyName("google_analytics")]
        public string GoogleAnalytics { get; set; }

        [JsonPropertyName("clicktale")]
        public string Clicktale { get; set; }

        [JsonPropertyName("salesforce")]
        public SalesForce Salesforce { get; set; }

        [JsonPropertyName("capsule")]
        public Capsule Capsule { get; set; }
    }
}