using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int OrderId { set; get; }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int ProductId { set; get; }

        public int? Quantity { set; get; }

        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}