using System;
using System.Collections.Generic;
using System.IO;
using WellRoundedCore.Models;
using Markdig;
using Markdig.Syntax;
using System.Linq;

namespace WellRoundedCore.Data.Posts
{
    public class PostsUtility
    {
        public PostsUtility()
        {
        }

        public static string MarkdownToHtml(string markdownFile)
        {
            StreamWriter markdownStream = File.CreateText(markdownFile);

            string markdownText = markdownStream.ToString();

            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .Build();

            return Markdown.ToHtml(markdownText, pipeline);
        }

        public static string TagPresenter(string tags)
        {
            string htmlTags = String.Empty;

            List<string> tagList = tags.Split(',').ToList();

            foreach (var tag in tagList)
            {
                htmlTags += $"<span class='post-tag'>{tag}</span>";
            }

            return htmlTags;
        }
    }
}
