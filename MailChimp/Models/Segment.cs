using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
	public class Segment
	{
		[JsonPropertyName("id")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("member_count")]
		public long MemberCount { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("created_at")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonPropertyName("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonPropertyName("options")]
		public SegmentOpts Options { get; set; }

		[JsonPropertyName("list_id")]
		public string ListId { get; set; }

		[JsonPropertyName("_links")]
		public Link[] Links { get; set; }
	}
}