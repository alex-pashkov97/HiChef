using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Recipes")]
    public class RecipeDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int TimeToCookInMinutes { get; set; }

        public List<IngredientDataModel> Ingredients { get; set; }

        public UserDataModel User { get; set; }

        public List<CommentDataModel> Comments { get; set; }

        public List<RatingDataModel> Ratings { get; set; }

        public byte[] Image { get; set; }
    }
}
