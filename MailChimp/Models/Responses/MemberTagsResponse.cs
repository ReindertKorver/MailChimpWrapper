using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
    ///<summary>
    /// This is the result of a request:
    /// <para>
    /// <see cref="MemberTagsGetRequest"></see>
    /// </para>
    /// </summary>
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