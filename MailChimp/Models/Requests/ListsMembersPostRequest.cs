using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Batch subscribe or unsubscribe list members.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/lists/batch-subscribe-or-unsubscibe/">Docs /lists/{list_id}</see>
    /// </para>
    /// <para>
    /// Result of this request will be of type <see cref="ListMembersResponse"/>
    /// </para>
    /// </summary>
    public class ListMembersPostRequest : IBaseRequest
    {
        private readonly string _id;

        public ListMembersPostRequest(string id, List<Member> members, bool updateExisting = false)
        {
            _id = id;
            Members = members;
            UpdateExisting = updateExisting;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Lists + "/" + _id; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Post; }

        [JsonPropertyName("members")]
        public List<Member> Members { get; set; }

        [JsonPropertyName("update_existing")]
        public bool UpdateExisting { get; set; }
    }
}