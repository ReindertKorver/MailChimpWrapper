using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class ListsResponse: IBaseResponse
    {
        [JsonPropertyName("lists")]
        public List<SubscriberList> Lists { get; set; }

        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        [JsonPropertyName("constraints")]
        public Constraints Constraints { get; set; }

        [JsonPropertyName("_links")]
        public Link[] Links { get; set; }
        public int Status { get ; set ; }
    }
}
