using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Comments")]
    public class CommentDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public DateTime CreationTime { get; set; }

        public UserDataModel User { get; set; }

        public RecipeDataModel Recipe { get; set; }
    }
}
