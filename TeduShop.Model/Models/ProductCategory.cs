using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models

{
    [Table("ProductCategories")]
    public class ProductCategory : ISeoable, IAuditable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Chi ra cho Id tu dong tang
        public int Id;

        [Required]
        [MaxLength(256)]
        public string Name;

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentId { set; get; }
        public int? DisplayOrder { get; set; }
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        public string MateKeyword { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string MateDescription { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}