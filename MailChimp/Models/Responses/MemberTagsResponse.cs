using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class MemberTagsResponse : IBaseResponse
    {
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }

        public int Status { get; set; }
    }
}