using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
	/// <summary>
	/// This is the result of a request:
	/// <para>
	/// <see cref="ListSegmentsGetRequest"></see>
	/// </para>
	/// </summary>
	public class ListSegmentsResponse
	{
		[JsonPropertyName("segments")]
		public Segment[] Segments { get; set; }

		[JsonPropertyName("list_id")]
		public string ListId { get; set; }

		[JsonPropertyName("total_items")]
		public int TotalItems { get; set; }

		[JsonPropertyName("_links")]
		public Link[] Links { get; set; }
	}
}