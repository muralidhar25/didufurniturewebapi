using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Quotations
{
   public class Quotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuotationId { get; set; }

        [Required]
        public string QuotationCode { get; set; }
     
        [Required]
        public string QuotationStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int PaymentId { get; set; }
        public virtual PaymentSummary PaymentSummary { get; set; }

    }
}
