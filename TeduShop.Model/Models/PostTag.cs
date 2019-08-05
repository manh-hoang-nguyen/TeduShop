using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int PostId { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int TagId { set; get; }

        [ForeignKey("PostId")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }
    }
}