using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class Settings
    {
        [JsonPropertyName("subject_line")]
        public string SubjectLine { get; set; }

        [JsonPropertyName("preview_text")]
        public string PreviewText { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("from_name")]
        public string FromName { get; set; }

        [JsonPropertyName("reply_to")]
        public string ReplyTo { get; set; }

        [JsonPropertyName("use_conversation")]
        public bool UseConversation { get; set; }

        [JsonPropertyName("to_name")]
        public string ToName { get; set; }

        [JsonPropertyName("folder_id")]
        public string FolderId { get; set; }

        [JsonPropertyName("authenticate")]
        public bool Authenticate { get; set; }

        [JsonPropertyName("auto_footer")]
        public bool AutoFooter { get; set; }

        [JsonPropertyName("inline_css")]
        public bool InlineCss { get; set; }

        [JsonPropertyName("auto_tweet")]
        public bool AutoTweet { get; set; }

        [JsonPropertyName("auto_fb_post")]
        public List<object> AutoFbPost { get; set; }

        [JsonPropertyName("fb_comments")]
        public bool FbComments { get; set; }

        [JsonPropertyName("template_id")]
        public int TemplateId { get; set; }
    }
}