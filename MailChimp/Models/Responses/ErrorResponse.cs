using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public class ErrorResponse:IBaseResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }

        public int Detail { get; set; }
        public int Instance { get; set; }
    }
}
