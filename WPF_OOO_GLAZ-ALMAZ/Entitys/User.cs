using System;
using System.Collections.Generic;

namespace WPF_OOO_GLAZ_ALMAZ.Entitys
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string UserRole { get; set; } = null!;
    }
}
