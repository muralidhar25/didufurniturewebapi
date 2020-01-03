using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Product
{
    public class WeavingType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WeavingId { get; set; }
        [Required]
        public string WeavingName { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
