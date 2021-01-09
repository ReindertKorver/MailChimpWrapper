using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class VariateSettings
	{
		[JsonPropertyName("winner_criteria")]
		public string WinnerCriteria { get; set; }

		[JsonPropertyName("wait_time")]
		public int WaitTime { get; set; }

		[JsonPropertyName("test_size")]
		public int TestSize { get; set; }

		[JsonPropertyName("subject_lines")]
		public List<object> SubjectLines { get; set; }

		[JsonPropertyName("send_times")]
		public List<object> SendTimes { get; set; }

		[JsonPropertyName("from_names")]
		public List<object> FromNames { get; set; }

		[JsonPropertyName("reply_to_addresses")]
		public List<object> ReplyToAddresses { get; set; }
	}
}