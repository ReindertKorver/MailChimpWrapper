using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MailChimpWrapper.Models.Requests;

namespace MailChimpWrapper.Models.Responses
{
	///<summary>
	/// This is the result of a request:
	/// <para>
	/// <see cref="CampaignReportGetRequest"></see>
	/// </para>
	/// </summary>
	public class CampaignReportResponse : IBaseResponse
	{
		public int Status { get; set; }

		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("campaign_title")]
		public string CampaignTitle { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("list_id")]
		public string ListId { get; set; }

		[JsonPropertyName("list_is_active")]
		public bool ListIsActive { get; set; }

		[JsonPropertyName("list_name")]
		public string ListName { get; set; }

		[JsonPropertyName("subject_line")]
		public string SubjectLine { get; set; }

		[JsonPropertyName("preview_text")]
		public string PreviewText { get; set; }

		[JsonPropertyName("emails_sent")]
		public int EmailsSent { get; set; }

		[JsonPropertyName("abuse_reports")]
		public int AbuseReports { get; set; }

		[JsonPropertyName("unsubscribed")]
		public int Unsubscribed { get; set; }

		[JsonPropertyName("send_time")]
		public string SendTime { get; set; }

		[JsonPropertyName("rss_last_send")]
		public string RssLastSend { get; set; }

		[JsonPropertyName("bounces")]
		public Bounces Bounces { get; set; }

		[JsonPropertyName("forwards")]
		public Forwards Forwards { get; set; }

		[JsonPropertyName("opens")]
		public Opens Opens { get; set; }

		[JsonPropertyName("clicks")]
		public Clicks Clicks { get; set; }

		[JsonPropertyName("facebook_likes")]
		public FacebookLikes FacebookLikes { get; set; }

		[JsonPropertyName("industry_stats")]
		public IndustryStats IndustryStats { get; set; }

		[JsonPropertyName("list_stats")]
		public ListStats ListStats { get; set; }

		[JsonPropertyName("ab_split")]
		public AbSplit AbSplit { get; set; }

		[JsonPropertyName("timewarp")]
		public Timewarp[] Timewarp { get; set; }

		[JsonPropertyName("timeseries")]
		public Timesery[] Timeseries { get; set; }

		[JsonPropertyName("share_report")]
		public ShareReport ShareReport { get; set; }

		[JsonPropertyName("ecommerce")]
		public Ecommerce Ecommerce { get; set; }

		[JsonPropertyName("delivery_status")]
		public DeliveryStatus DeliveryStatus { get; set; }

		[JsonPropertyName("_links")]
		public Link[] Links { get; set; }
	}
}