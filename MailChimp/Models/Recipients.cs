using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Recipients
    {
        [JsonPropertyName("list_id")]
        public string ListId { get; set; }

        [JsonPropertyName("segment_opts")]
        public SegmentOpts SegmentOpts { get; set; }
    }
}