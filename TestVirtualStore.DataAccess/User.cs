using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class User
    {
        public int ID_User { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public int ID_Rol { get; set; }
        public Roles Roles { get; set; }
    }
}
