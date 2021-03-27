using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class Roles : BaseEntity
    {        
        public string Rol_Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
