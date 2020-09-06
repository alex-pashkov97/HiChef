using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Bookmarks")]
    public class BookmarkDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public UserDataModel User { get; set; }

        public RecipeDataModel Recipe { get; set; }
    }
}
