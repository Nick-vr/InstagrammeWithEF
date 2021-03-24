using System;
using System.Collections.Generic;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
{
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
            PostTags = new HashSet<PostTag>();
        }

        public int PostId { get; set; }
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}