using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models
{
   public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialId { get; set; }
        [Required]
        public string MaterialName { get; set; }
        [Required]
        public string Color { get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
