using System;
using System.Collections.Generic;

#nullable disable

namespace InstagrammeWithEF.Data
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
