using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class MemberError
	{
		[JsonPropertyName("email_address")]
		public string EmailAddress { get; set; }

		[JsonPropertyName("error")]
		public string ErrorError { get; set; }

		[JsonPropertyName("error_code")]
		public string ErrorCode { get; set; }
	}
}