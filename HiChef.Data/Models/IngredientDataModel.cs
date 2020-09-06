using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiChef.Data.Models
{
    [Table("Ingredients")]
    public class IngredientDataModel
    {
        [Key]
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }
    }
}
