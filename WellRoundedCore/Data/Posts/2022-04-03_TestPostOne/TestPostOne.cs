using System;
using System.Collections.Generic;
using WellRoundedCore.Models;

namespace WellRoundedCore.Data.Posts
{
    public class TestPostOne
    {
        public TestPostOne()
        {
        }

        public static Post GetPost()
        {
            Post post = new Post
            {
                Metadata = new PostMetadata
                {
                    Id = 1,
                    Title = "Test Post One",
                    SubTitle = "SubTitle for Test Post One",
                    Author = "Travis Roy",
                    Date = "2022-04-03",
                    Tags = "weather, entertainment",
                    Url = ""
                },
                Body = "Data/Posts/2022-04-03_TestPostOne/Clouds.md",
                ImageUrls = new Dictionary<string, string>
                {
                    { "ImageOne", "ImageOneURL" },
                    { "ImageTwo", "ImageTwoURL" }
                }
            };

            return post;
        }
    }
}

