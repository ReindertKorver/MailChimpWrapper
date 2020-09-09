using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Exceptions
{
    public class UnknownResponseException : Exception
    {
        public UnknownResponseException(string message, HttpResponseMessage responseMessage) : base(message)
        {
            ResponseMessage = responseMessage;
        }
        public HttpResponseMessage ResponseMessage { get; set; }
    }
}
