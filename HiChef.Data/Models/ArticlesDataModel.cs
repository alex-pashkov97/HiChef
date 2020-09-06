using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Articles")]
    public class ArticlesDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public UserDataModel User { get; set; }
    }
}
