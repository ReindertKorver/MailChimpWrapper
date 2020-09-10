using MailChimpWrapper.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get the tags on a list member.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/list-member-tags/list-member-tags/">Docs /lists/{list_id}/members/{subscriber_hash}/tags</see>
    /// </para>
    /// </summary>
    public class MemberTagsGetRequest : IBaseRequest
    {
        internal readonly string _queryParams;
        private readonly string _listId;
        internal readonly string _emailaddress;

        public MemberTagsGetRequest(string listId, string emailaddress, string queryParams = "")
        {
            _queryParams = queryParams;
            _listId = listId;
            _emailaddress = emailaddress;
        }

        string IBaseRequest.Endpoint { get => $"{Endpoints.Lists}/{_listId}/members/{Hasher.CreateHash(_emailaddress)}/tags{_queryParams}"; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}