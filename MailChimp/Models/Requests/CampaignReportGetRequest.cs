using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MailChimpWrapper.Models.Responses;

namespace MailChimpWrapper.Models.Requests
{
	/// /// <summary>
	/// Get report details for a specific sent campaign.
	/// <para>
	/// <see href="https://mailchimp.com/developer/api/marketing/reports/get-campaign-report/">Docs /reports/{campaign_id}</see>
	/// </para>
	/// <para>
	/// Result of this request will be of type <see cref="CampaignReportResponse"/>
	/// </para>
	/// </summary>
	public class CampaignReportGetRequest : IBaseRequest
	{
		private readonly string _queryParams;
		private readonly string _id;

		public CampaignReportGetRequest(string id, string queryParams = "")
		{
			_queryParams = queryParams;
			_id = id;
		}

		string IBaseRequest.Endpoint { get => Endpoints.Reports + "/" + _id + "" + _queryParams; }
		HttpMethod IBaseRequest.Method { get => HttpMethod.Get; }
	}
}