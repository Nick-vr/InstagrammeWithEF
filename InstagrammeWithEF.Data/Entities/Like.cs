using System;
using System.Collections.Generic;
using InstagrammeWithEF.Data.Entities;

#nullable disable

namespace InstagrammeWithEF.Data
{
    public partial class Like
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}