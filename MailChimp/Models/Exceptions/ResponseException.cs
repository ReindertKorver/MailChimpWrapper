using MailChimpWrapper.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Exceptions
{
    public class ResponseException:Exception
    {
        public ErrorResponse ErrorResponse { get; set; }
    }
}
