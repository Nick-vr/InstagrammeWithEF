using System;
using System.Collections.Generic;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            PostTags = new List<PostTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}