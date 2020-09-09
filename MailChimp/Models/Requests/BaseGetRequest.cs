using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    public class BaseGetRequest : BaseRequest
    {
        public BaseGetRequest(string endpoint)
        {
            _endpoint = endpoint;
        }
        protected override string Endpoint { get => _endpoint; set => _endpoint = value; }
        private string _endpoint;

        protected override HttpMethod Method => HttpMethod.Get;
    }
}
