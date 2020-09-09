﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    /// <summary>
    /// Get information about a specific list in your Mailchimp account. Results include list members who have signed up but haven't confirmed their subscription yet and unsubscribed or cleaned.
    /// <para>
    /// <see href="https://mailchimp.com/developer/api/marketing/lists/get-list-info/">Docs /lists/{list_id}</see>
    /// </para>
    /// </summary>
    public class ListGetRequest : BaseRequest
    {
        internal readonly string _queryParams;
        internal readonly string _id;
        public ListGetRequest(string id,string queryParams="")
        {
            _queryParams = queryParams;
            _id = id;
        }
        protected override string Endpoint { get => Endpoints.Lists+"/"+ _id; set  { } }

        protected override HttpMethod Method => HttpMethod.Get;
    }
}
