using System.Net.Http;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Requests
{
    public interface IBaseRequest
    {
        public string Endpoint { get; }
        public HttpMethod Method { get; }
    }
}