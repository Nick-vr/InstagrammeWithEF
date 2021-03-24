using System;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
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