using MailChimpWrapper.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class ListMembersResponse : IBaseResponse
    {
        [JsonPropertyName("new_members")]
        public List<Member> NewMembers { get; set; }

        [JsonPropertyName("updated_members")]
        public List<Member> UpdatedMembers { get; set; }

        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }

        [JsonPropertyName("total_created")]
        public int TotalCreated { get; set; }

        [JsonPropertyName("total_updated")]
        public int TotalUpdated { get; set; }

        [JsonPropertyName("error_count")]
        public int ErrorCount { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }

        public int Status { get; set; }
    }
}