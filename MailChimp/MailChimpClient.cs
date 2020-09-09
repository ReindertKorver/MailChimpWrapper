using MailChimpWrapper.Models;
using MailChimpWrapper.Models.Exceptions;
using MailChimpWrapper.Models.Requests;
using MailChimpWrapper.Models.Responses;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MailChimpWrapper
{
    public class MailChimpClient
    {
        private string ApiKey { get; set; }
        private string Server { get; set; }
        /// <summary>
        /// A client to do requests
        /// <para>ApiKey and Server are required for more information: <see href="https://mailchimp.com/developer/guides/marketing-api-quick-start/">Api quick start</see></para>
        /// 
        /// </summary>
        /// <param name="apikey"></param>
        /// <param name="server"></param>
        public MailChimpClient(string apikey, string server)
        {
            this.ApiKey = apikey;
            this.Server = server;
        }
        public async Task<ResponseBody> Request<RequestBody, ResponseBody>(RequestBody requestBody) where RequestBody : Models.Requests.BaseRequest
        {
            var client = new HttpClient();
            var endpoint = string.Format("https://{0}.api.mailchimp.com/3.0/{1}", Server, requestBody.GetEndpoint());
            requestBody.ApiKey = ApiKey;
            string json = JsonSerializer.Serialize(requestBody);
            HttpResponseMessage responseBody;
            string response = "";

            var httpContent = new HttpRequestMessage(requestBody.GetMethod(), endpoint);
            var authenticationString = $"PleaseDont:{ApiKey}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
            httpContent.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            responseBody = await client.SendAsync(httpContent);

            if (responseBody != null)
            {
                if (responseBody.StatusCode == HttpStatusCode.OK)
                {
                    response = await responseBody.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<ResponseBody>(response, new JsonSerializerOptions() { MaxDepth = 10, PropertyNameCaseInsensitive = true });
                }
                else
                {
                    try
                    {
                        ErrorResponse errorResponse = JsonSerializer.Deserialize<ErrorResponse>(response,new JsonSerializerOptions() { MaxDepth=10,PropertyNameCaseInsensitive=true});
                        throw new ResponseException() { ErrorResponse = errorResponse };
                    }
                    catch (Exception ex)
                    {
                        throw new UnknownResponseException("UnknownResponseException: Response couldn't be deserialized to an ErrorResponse", responseBody);
                    }
                }
            }
            else
            {
                throw new Exception(response);
            }
        }
        public async Task<ResponseBody> GetRequest<ResponseBody>(string endpoint) 
        {
            return await Request<BaseGetRequest, ResponseBody>(new BaseGetRequest(endpoint));
        }
    }
}