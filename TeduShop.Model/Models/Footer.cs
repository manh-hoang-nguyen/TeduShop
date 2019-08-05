using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public string Id { set; get; }

        [Required]
        public string Content { set; get; }
    }
}