using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public class EmptyResponse : IBaseResponse
    {
        public int Status { get; set; }
    }
}