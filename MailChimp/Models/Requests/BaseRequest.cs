using System.Net.Http;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Requests
{
    public abstract class BaseRequest
    {
        public string ApiKey { get; set; }
        protected abstract string Endpoint { get; set; }
        public string GetEndpoint()
        {
            return Endpoint;
        }
        protected abstract HttpMethod Method { get; }
        public HttpMethod GetMethod()
        {
            return Method;
        }
    }
}