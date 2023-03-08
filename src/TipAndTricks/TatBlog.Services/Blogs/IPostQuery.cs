﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatBlog.Services.Blogs
{
    public interface IPostQuery
    {
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string CategorySlug { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string KeyWord { get; set; }
        public bool PublishedOnly { get; set; }
    }
}
