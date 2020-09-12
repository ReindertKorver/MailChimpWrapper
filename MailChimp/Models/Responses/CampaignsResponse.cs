using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class CampaignsResponse : IBaseResponse
    {
        public int Status { get; set; }

        [JsonPropertyName("campaigns")]
        public List<Campaign> Campaigns { get; set; }

        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        [JsonPropertyName("_links")]
        public Link[] Links { get; set; }
    }
}