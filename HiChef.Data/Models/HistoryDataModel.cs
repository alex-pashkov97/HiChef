using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("UserHistory")]
    public class HistoryDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public DateTime CreatinDate { get; set; }

        public UserDataModel User { get; set; }

        public RecipeDataModel Recipe { get; set; }
    }
}
