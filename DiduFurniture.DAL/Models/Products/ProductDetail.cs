using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models
{
   public class ProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductDetailId { get; set; }
        [Required]
        public decimal Length { get; set; }
        [Required]
        public decimal Width { get; set; }
        [Required]
        public decimal Height { get; set; }
        public string Anyam { get; set; }

        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
