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
    }
}