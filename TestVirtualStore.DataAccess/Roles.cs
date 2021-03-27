using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class Roles
    {
        public int ID_Rol { get; set; }
        public string Rol_Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
