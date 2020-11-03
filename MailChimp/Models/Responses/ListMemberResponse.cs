using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class ListMemberResponse
    {
        [JsonPropertyName("members")]
        public List<Member> Members { get; set; }

        [JsonPropertyName("list_id")]
        public string ListId { get; set; }

        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }
    }
}