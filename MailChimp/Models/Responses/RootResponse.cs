using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;
using MailChimpWrapper;

namespace MailChimpWrapper.Models.Responses
{
    ///<summary>
    /// This is the result of a request:
    /// <para>
    /// <see cref="RootGetRequest"></see>
    /// </para>
    /// </summary>
    public class RootResponse : IBaseResponse
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("member_since")]
        public string MemberSince { get; set; }

        [JsonPropertyName("pricing_plan_type")]
        public string PricingPlanType { get; set; }

        [JsonPropertyName("first_payment")]
        public string FirstPayment { get; set; }

        [JsonPropertyName("account_timezone")]
        public string AccountTimezone { get; set; }

        [JsonPropertyName("account_industry")]
        public string AccountIndustry { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("pro_enabled")]
        public bool ProEnabled { get; set; }

        [JsonPropertyName("last_login")]
        public string LastLogin { get; set; }

        [JsonPropertyName("total_subscribers")]
        public int TotalSubscribers { get; set; }

        [JsonPropertyName("industry_stats")]
        public IndustryStats IndustryStats { get; set; }

        [JsonPropertyName("_links")]
        public List<Link> Links { get; set; }

        public int Status { get; set; }
    }
}