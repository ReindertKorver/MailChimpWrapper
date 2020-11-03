using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get information about members in a specific Mailchimp list.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/list-members/">Docs /lists/{list_id}/members</see>
    /// </para>
    /// </summary>
    public class ListMembersGetRequest : IBaseRequest
    {
        private readonly string _id;

        public ListMembersGetRequest(string listId)
        {
            _id = listId;
        }

        string IBaseRequest.Endpoint { get => Endpoints.Lists + "/" + _id + "/members"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}