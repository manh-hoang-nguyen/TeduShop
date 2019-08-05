using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int Id;

        [Required]
        [MaxLength(256)]
        public string Name;

        [Column(TypeName = "varchar")]//chi ra kieu du lieu cua alias la varchar
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        public string Content;

        //public string MateKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string MateDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}