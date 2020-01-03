using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Quotation
{
   public class StoreLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoreLocationId { get; set; }
        [Required]
        public string StoreName { get; set; }
        [Required]
        public string StoreAddress { get; set; }
        [Required]
        public string ZipCode { get; set; }
    }
}
