using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int Id { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAdrress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}