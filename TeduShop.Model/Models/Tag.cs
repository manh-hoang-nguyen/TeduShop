using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        [MaxLength(50)] //Post tag co do dai la 50 thi tag cung phai co do dai la 50
        public int Id { set; get; }

        public string Name;
        public string Type;
    }
}