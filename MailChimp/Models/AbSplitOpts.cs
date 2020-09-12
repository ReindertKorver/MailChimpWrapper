using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class AbSplitOpts
    {
        [JsonPropertyName("split_test")]
        public string SplitTest { get; set; }

        [JsonPropertyName("pick_winner")]
        public string PickWinner { get; set; }

        [JsonPropertyName("wait_units")]
        public string WaitUnits { get; set; }

        [JsonPropertyName("wait_time")]
        public int WaitTime { get; set; }

        [JsonPropertyName("split_size")]
        public int SplitSize { get; set; }

        [JsonPropertyName("from_name_a")]
        public string FromNameA { get; set; }

        [JsonPropertyName("from_name_b")]
        public string FromNameB { get; set; }

        [JsonPropertyName("reply_email_a")]
        public string ReplyEmailA { get; set; }

        [JsonPropertyName("reply_email_b")]
        public string ReplyEmailB { get; set; }

        [JsonPropertyName("subject_a")]
        public string SubjectA { get; set; }

        [JsonPropertyName("subject_b")]
        public string SubjectB { get; set; }

        [JsonPropertyName("send_time_a")]
        public string SendTimeA { get; set; }

        [JsonPropertyName("send_time_b")]
        public string SendTimeB { get; set; }

        [JsonPropertyName("send_time_winner")]
        public string SendTimeWinner { get; set; }
    }
}