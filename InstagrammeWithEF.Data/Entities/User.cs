using System;
using System.Collections.Generic;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Comments = new List<Comment>();
            FollowerFollowees = new List<Follower>();
            FollowerFollowerNavigations = new List<Follower>();
            Likes = new List<Like>();
            Posts = new List<Post>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Follower> FollowerFollowees { get; set; }
        public List<Follower> FollowerFollowerNavigations { get; set; }
        public List<Like> Likes { get; set; }
        public List<Post> Posts { get; set; }
    }
}