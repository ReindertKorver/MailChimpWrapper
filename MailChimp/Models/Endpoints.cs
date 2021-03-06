namespace MailChimpWrapper.Models
{
	public class Endpoints
	{
		/// <summary>
		/// Get information about all lists in the account.
		/// <para>
		/// <see href="https://mailchimp.com/developer/api/marketing/lists/">Docs /lists</see>
		/// </para>
		/// </summary>
		public const string Lists = "lists";

		/// <summary>
		/// A health check for the API that won't return any account-specific information.
		/// <para>
		/// <see href="https://mailchimp.com/developer/api/marketing/ping/ping/">Docs /ping</see>
		/// </para>
		/// </summary>
		public const string Ping = "ping";

		/// <summary>
		/// Get links to all other resources available in the API.
		/// <para>
		/// <see href="https://mailchimp.com/developer/api/marketing/root/list-api-root-resources/">Docs /</see>
		/// </para>
		/// </summary>
		public const string Root = "";

		/// <summary>
		/// Campaigns are how you send emails to your Mailchimp list. Use the Campaigns API calls to manage campaigns in your Mailchimp account.
		/// <para>
		/// <see href="https://mailchimp.com/developer/api/marketing/campaigns">Docs /Campaigns</see>
		/// </para>
		/// </summary>
		public const string Campaigns = "/campaigns";

		/// <summary>
		/// Manage campaign reports for your Mailchimp account. All Reports endpoints are read-only.
		/// <para>Mailchimp's campaign and Automation reports analyze clicks, opens, subscribers' social activity, e-commerce data, and more. </para>
		/// <para>Note: Campaign IDs for A/B Testing Campaigns are available through the Campaign API Endpoint's Read method.</para>
		/// </summary>
		public const string Reports = "/reports";

		/// <summary>
		/// Manage your Mailchimp templates. A template is an HTML file used to create the layout and basic design for a campaign.
		/// <para>
		/// <see href="https://mailchimp.com/developer/api/marketing/templates">Docs /Templates</see>
		/// </para>
		/// </summary>
		public const string Templates = "/templates";
	}
}