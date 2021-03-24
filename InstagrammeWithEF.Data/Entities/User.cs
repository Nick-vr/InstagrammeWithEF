using System;
using System.Collections.Generic;
using InstagrammeWithEF.Data.Entities;

#nullable disable

namespace InstagrammeWithEF.Data
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            FollowerFollowees = new HashSet<Follower>();
            FollowerFollowerNavigations = new HashSet<Follower>();
            Likes = new HashSet<Like>();
            Posts = new HashSet<Post>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Follower> FollowerFollowees { get; set; }
        public virtual ICollection<Follower> FollowerFollowerNavigations { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}