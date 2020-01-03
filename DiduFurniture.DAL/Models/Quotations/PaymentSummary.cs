using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiduFurniture.DAL.Models.Quotations
{
   public class PaymentSummary
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [Required]
        public string SalesPerson { get; set; }
        [Required]
        public string ShippedBy { get; set; }
        [Required]
        public string ConfirmedBy { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DueDate { get; set; }       
        public string DeliveryNotes { get; set; }
        [Required]
        public decimal Deposit { get; set; }
        public decimal Discount { get; set; }
    }
}
