using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    public class SupportOnline : ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Departement;

        [MaxLength(50)]
        public string Skype;

        [MaxLength(50)]
        public string Mobile;

        [MaxLength(50)]
        public string Email;

        [MaxLength(50)]
        public string Yahoo;

        [MaxLength(50)]
        public string Facebook;

        public int? DisplayOrder { set; get; }

        [MaxLength(50)]
        public bool Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}