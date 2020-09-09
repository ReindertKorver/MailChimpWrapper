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
        public const string Lists="lists";
        /// <summary>
        /// A health check for the API that won't return any account-specific information.
        /// <para>
        /// <see href="https://mailchimp.com/developer/api/marketing/ping/ping/">Docs /ping</see>
        /// </para>
        /// </summary>
        public const string Ping="ping";
    }
}
