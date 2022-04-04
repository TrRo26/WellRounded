using System;
using System.Collections.Generic;
using WellRoundedCore.Data.Posts;

namespace WellRoundedCore.Models
{
    public class Post
    {
        private string body;

        public PostMetadata Metadata { get; set; }
        public string Body
            {
                get { return PostsUtility.MarkdownToHtml(body); }
                set { body = value;  }
            }
        public Dictionary<string, string> ImageUrls { get; set; }
    }
}
