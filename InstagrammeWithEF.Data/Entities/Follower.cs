using System;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
{
    public partial class Follower
    {
        public int FollowerId { get; set; }
        public int FolloweeId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User Followee { get; set; }
        public virtual User FollowerNavigation { get; set; }
    }
}