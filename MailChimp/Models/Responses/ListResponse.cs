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
    /// <see cref="ListGetRequest"></see>
    /// </para>
    /// </summary>
    public class ListResponse : SubscriberList, IBaseResponse
    {
        public int Status { get; set; }
    }
}