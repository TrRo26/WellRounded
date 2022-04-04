using System;
using System.Collections.Generic;
using WellRoundedCore.Data.Posts;

namespace WellRoundedCore.Models
{
    public class PostMetadata
    {
        private string tags;

        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Tags {
            get { return PostsUtility.TagPresenter(tags); }
            set { tags = value; } }
        public string Url { get; set; }
    }
}
