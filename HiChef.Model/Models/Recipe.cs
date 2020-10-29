using System;
using System.Collections.Generic;

namespace HiChef.Model.Models
{
    public class Recipe
    {
        public Guid Guid { get; set; }

        public User Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int TimeToCookInMinutes { get; set; }

        public byte[] Image { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Comment> Comments { get; set; }

        public double Rating { get; set; }
    }
}
