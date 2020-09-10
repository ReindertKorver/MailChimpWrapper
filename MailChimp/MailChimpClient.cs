using MailChimpWrapper.Models;
using MailChimpWrapper.Models.Exceptions;
using MailChimpWrapper.Models.Requests;
using MailChimpWrapper.Models.Responses;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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

        public async Task<ResponseBody> Request<RequestBody, ResponseBody>(RequestBody requestBody) where RequestBody : Models.Requests.IBaseRequest
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var endpoint = string.Format("https://{0}.api.mailchimp.com/3.0/{1}", Server, requestBody.Endpoint);
            string json = JsonSerializer.Serialize(requestBody, new JsonSerializerOptions() { IgnoreNullValues = true });
            HttpResponseMessage responseBody;
            string response = "";
            var httpContent = new HttpRequestMessage(requestBody.Method, endpoint);
            if (requestBody.Method == HttpMethod.Post || requestBody.Method == HttpMethod.Put || requestBody.Method == HttpMethod.Patch)
            {
                httpContent.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            var authenticationString = $"key:{ApiKey}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
            httpContent.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            responseBody = await client.SendAsync(httpContent);

            if (responseBody != null)
            {
                if (responseBody.IsSuccessStatusCode)
                {
                    if (responseBody.Content != null)
                    {
                        response = await responseBody.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(response))
                        {
                            return JsonSerializer.Deserialize<ResponseBody>(response, new JsonSerializerOptions() { MaxDepth = 10, PropertyNameCaseInsensitive = true });
                        }
                        else
                        {
                            return default;
                        }
                    }
                    else
                    {
                        return default;
                    }
                }
                else
                {
                    ErrorResponse errorResponse;
                    try
                    {
                        var resp = await responseBody.Content.ReadAsStringAsync();
                        errorResponse = JsonSerializer.Deserialize<ErrorResponse>(resp, new JsonSerializerOptions() { MaxDepth = 10, PropertyNameCaseInsensitive = true });
                    }
                    catch (Exception ex)
                    {
                        throw new UnknownResponseException("UnknownResponseException: Response couldn't be deserialized to an ErrorResponse", responseBody);
                    }
                    throw new ResponseException() { ErrorResponse = errorResponse };
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

        public async Task Request<RequestBody>(RequestBody requestBody) where RequestBody : Models.Requests.IBaseRequest
        {
            await Request<RequestBody, EmptyResponse>(requestBody);
        }
    }
}