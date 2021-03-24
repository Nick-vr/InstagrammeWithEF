using System;
using System.Collections.Generic;

#nullable disable

namespace InstagrammeWithEF.Data
{
    public partial class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
