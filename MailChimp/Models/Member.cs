using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Member
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }

        [JsonPropertyName("unique_email_id")]
        public string UniqueEmailId { get; set; }

        [JsonPropertyName("email_type")]
        public string EmailType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("merge_fields")]
        public Interests MergeFields { get; set; }

        [JsonPropertyName("interests")]
        public Interests Interests { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("ip_signup")]
        public string IpSignup { get; set; }

        [JsonPropertyName("timestamp_signup")]
        public DateTimeOffset TimestampSignup { get; set; }

        [JsonPropertyName("ip_opt")]
        public string IpOpt { get; set; }

        [JsonPropertyName("timestamp_opt")]
        public DateTimeOffset TimestampOpt { get; set; }

        [JsonPropertyName("member_rating")]
        public int MemberRating { get; set; }

        [JsonPropertyName("last_changed")]
        public DateTimeOffset LastChanged { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("vip")]
        public bool Vip { get; set; }

        [JsonPropertyName("email_client")]
        public string EmailClient { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("last_note")]
        public LastNote LastNote { get; set; }

        [JsonPropertyName("tags_count")]
        public int TagsCount { get; set; }

        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        [JsonPropertyName("list_id")]
        public string ListId { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }
    }
}