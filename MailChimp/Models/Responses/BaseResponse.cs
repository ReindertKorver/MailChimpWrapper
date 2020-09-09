using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimpWrapper.Models.Responses
{
    public interface IBaseResponse
    {
        public int Status { get; set; }
    }
}
