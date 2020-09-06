using System;

namespace HiChef.Model.Models
{
    public class Rating
    {
        public Guid RecipeGuid { get; set; }

        public double Mark { get; set; }
    }
}
