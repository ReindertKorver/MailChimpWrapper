using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Condition
	{
		[JsonPropertyName("condition_type")]
		public string ConditionType { get; set; }

		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonPropertyName("op")]
		public string Operator { get; set; }

		[JsonPropertyName("value")]
		public string Value { get; set; }
	}
}