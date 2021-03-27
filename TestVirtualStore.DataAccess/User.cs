using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class User : BaseEntity
    {
        public string User_Name { get; set; }
        public string Password { get; set; }
        public int RolFK { get; set; }
        public Roles Roles { get; set; }

        public ICollection<Sales> Sales { get; set; }
    }
}
