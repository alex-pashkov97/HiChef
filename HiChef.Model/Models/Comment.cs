using System;

namespace HiChef.Model.Models
{
    public class Comment
    {
        public Guid Guid { get; set; }

        public DateTime CreationTime { get; set; }

        public User User { get; set; }

        public Recipe Recipe { get; set; }

        public string Description { get; set; }
    }
}
