using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Schedule
    {
        [JsonPropertyName("hour")]
        public int Hour { get; set; }

        [JsonPropertyName("daily_send")]
        public DailySend DailySend { get; set; }

        [JsonPropertyName("weekly_send_day")]
        public string WeeklySendDay { get; set; }

        [JsonPropertyName("monthly_send_date")]
        public int MonthlySendDate { get; set; }
    }
}