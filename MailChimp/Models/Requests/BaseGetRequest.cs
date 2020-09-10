using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MailChimpWrapper.Models.Requests
{
    public class BaseGetRequest : IBaseRequest
    {
        private string _endpoint;

        public BaseGetRequest(string endpoint)
        {
            _endpoint = endpoint;
        }

        string IBaseRequest.Endpoint { get => _endpoint; }
        HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
    }
}