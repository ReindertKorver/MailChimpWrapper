using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Ecommerce
	{
		[JsonPropertyName("total_orders")]
		public long TotalOrders { get; set; }

		[JsonPropertyName("total_spent")]
		public long TotalSpent { get; set; }

		[JsonPropertyName("total_revenue")]
		public long TotalRevenue { get; set; }

		[JsonPropertyName("currency_code")]
		public string CurrencyCode { get; set; }
	}
}