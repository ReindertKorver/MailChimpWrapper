using MailChimpWrapper.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public class ErrorResponse : IBaseResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }

        public string Detail { get; set; }
        public string Instance { get; set; }
        public List<Error> Errors { get; set; }
    }
}