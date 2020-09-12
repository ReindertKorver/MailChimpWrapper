using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class DailySend
    {
        [JsonPropertyName("sunday")]
        public bool Sunday { get; set; }

        [JsonPropertyName("monday")]
        public bool Monday { get; set; }

        [JsonPropertyName("tuesday")]
        public bool Tuesday { get; set; }

        [JsonPropertyName("wednesday")]
        public bool Wednesday { get; set; }

        [JsonPropertyName("thursday")]
        public bool Thursday { get; set; }

        [JsonPropertyName("friday")]
        public bool Friday { get; set; }

        [JsonPropertyName("saturday")]
        public bool Saturday { get; set; }
    }
}