using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Constraints
	{
		[JsonPropertyName("may_create")]
		public bool MayCreate { get; set; }

		[JsonPropertyName("max_instances")]
		public int MaxInstances { get; set; }

		[JsonPropertyName("current_total_instances")]
		public int CurrentTotalInstances { get; set; }
	}
}