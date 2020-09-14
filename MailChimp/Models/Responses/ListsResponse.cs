using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
    /// <summary>
    /// This is the result of a request:
    /// <para>
    /// <see cref="ListsGetRequest"></see>
    /// </para>
    /// </summary>
    public class ListsResponse : IBaseResponse
    {
        [JsonPropertyName("lists")]
        public List<SubscriberList> Lists { get; set; }

        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        [JsonPropertyName("constraints")]
        public Constraints Constraints { get; set; }

        [JsonPropertyName("_links")]
        public Link[] Links { get; set; }

        public int Status { get; set; }
    }
}