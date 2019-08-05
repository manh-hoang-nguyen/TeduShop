using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        string CreatedBy { set; get; }

        DateTime? UpdatedDate { set; get; }

        string UpdatedBy { set; get; }
    }
}