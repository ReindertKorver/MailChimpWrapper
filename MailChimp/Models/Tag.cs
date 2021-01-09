using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Tag
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <summary>
		/// The name of the tag.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// The status for the tag on the member, pass in active to add a tag or inactive to remove it. Possible values: "inactive" or "active".
		/// </summary>
		[JsonPropertyName("status")]
		public string Status { get; set; }
	}
}