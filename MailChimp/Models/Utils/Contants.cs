using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Utils
{
    public static class MailChimpWrapperContants
    {
        public static JsonSerializerOptions JsonSerializerResponseOptions
        {
            get
            {
                var jsonserializeroptions = new JsonSerializerOptions()
                {
                    MaxDepth = 10,
                    PropertyNameCaseInsensitive = true,
                };
                jsonserializeroptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                return jsonserializeroptions;
            }
        }

        public static JsonSerializerOptions JsonSerializerRequestOptions
        {
            get
            {
                var jsonserializeroptions = new JsonSerializerOptions()
                {
                    IgnoreNullValues = true,
                    MaxDepth = 10,
                    PropertyNameCaseInsensitive = true,
                };
                jsonserializeroptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
                return jsonserializeroptions;
            }
        }
    }
}