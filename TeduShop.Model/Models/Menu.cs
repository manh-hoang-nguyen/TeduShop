using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupId { set; get; }

        [ForeignKey("GroupeId")]
        public virtual MenuGroup MenuGroup { set; get; }// viet nhu the nay thi groupeId tro den khoa chinh cua MenuGroup

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
    }
}