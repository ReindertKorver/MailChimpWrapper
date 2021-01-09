using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Ecommerce
	{
		[JsonPropertyName("total_orders")]
		public int TotalOrders { get; set; }

		[JsonPropertyName("total_spent")]
		public int TotalSpent { get; set; }

		[JsonPropertyName("total_revenue")]
		public int TotalRevenue { get; set; }

		[JsonPropertyName("currency_code")]
		public string CurrencyCode { get; set; }
	}
}