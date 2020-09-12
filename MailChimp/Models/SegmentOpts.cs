using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class SegmentOpts
    {
        [JsonPropertyName("saved_segment_id")]
        public int SavedSegmentId { get; set; }

        [JsonPropertyName("prebuilt_segment_id")]
        public string PrebuiltSegmentId { get; set; }

        [JsonPropertyName("match")]
        public string Match { get; set; }

        [JsonPropertyName("conditions")]
        public List<object> Conditions { get; set; }
    }
}