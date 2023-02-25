using System;
using System.Collections.Generic;

namespace WPF_OOO_GLAZ_ALMAZ.Entitys
{
    public partial class Seller
    {
        public Seller()
        {
            Supplies = new HashSet<Supply>();
        }

        public int SellersId { get; set; }
        public string SellersName { get; set; } = null!;
        public string SellersAdress { get; set; } = null!;
        public string SellersPhone { get; set; } = null!;

        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
