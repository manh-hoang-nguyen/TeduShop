using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Seoable : ISeoable
    {
        [MaxLength(256)]
        public string MateKeyword { set; get; }

        [MaxLength(256)]
        public string MateDescription { set; get; }
    }
}