using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Responses
{
    public class ListResponse : SubscriberList, IBaseResponse
    {
        public int Status { get ; set; }
    }
}
