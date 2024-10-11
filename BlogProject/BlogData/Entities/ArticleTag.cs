﻿using BlogData.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BlogData.Entities
{
    public class ArticleTag
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}