using System;

#nullable disable

namespace InstagrammeWithEF.Data.Entities
{
    public partial class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}