using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Product
{
    public class Material_weaving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialWeavingId { get; set; }
        public int MaterialId { get; set; }
        public int WeavingId { get; set; }

        public Material Material { get; set; }
        public WeavingType WeavingType { get; set; }
    }
}
