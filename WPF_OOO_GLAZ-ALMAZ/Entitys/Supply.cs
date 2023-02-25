using System;
using System.Collections.Generic;

namespace WPF_OOO_GLAZ_ALMAZ.Entitys
{
    public partial class Supply
    {
        public int SupplyId { get; set; }
        public string SupplyName { get; set; } = null!;
        public string SupplyCost { get; set; } = null!;
        public string SupplyDescription { get; set; } = null!;
        public byte[] Suppliescol { get; set; } = null!;
        public int CategoryId { get; set; }
        public int? SellersId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Seller? Sellers { get; set; }
    }
}
