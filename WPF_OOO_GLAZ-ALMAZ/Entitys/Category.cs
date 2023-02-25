using System;
using System.Collections.Generic;

namespace WPF_OOO_GLAZ_ALMAZ.Entitys
{
    public partial class Category
    {
        public Category()
        {
            Supplies = new HashSet<Supply>();
        }

        public int CategoryId { get; set; }
        public string Category1 { get; set; } = null!;

        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
