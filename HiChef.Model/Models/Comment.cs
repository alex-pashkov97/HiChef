using System;

namespace HiChef.Model.Models
{
    public class Comment
    {
        public Guid RecipeGuid { get; set; }

        public Author Author { get; set; }

        public string Description { get; set; }
    }
}
