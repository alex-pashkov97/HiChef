using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Users")]
    public class UserDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public List<CommentDataModel> Comments { get; set; }

        public List<RecipeDataModel> Recipes { get; set; }

        public List<BookmarkDataModel> Bookmarks { get; set; }

        public List<RatingDataModel> Ratings { get; set; }
    }
}
