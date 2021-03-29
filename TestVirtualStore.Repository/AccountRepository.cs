using Microsoft.EntityFrameworkCore;
using System.Linq;
using TestVirtualStore.DataAccess;
using TestVirtualStore.DataAccess.ViewModels;
using TestVirtualStore.Repository.Helpers;

namespace TestVirtualStore.Repository
{
    public class AccountRepository : Repository<User>, IAccountRepository
    {
        private readonly ContextApplication _context;
        public AccountRepository(ContextApplication context) : base(context) 
        {
            _context = context;
        }

        public User Login(LoginViewModel login)
        {
            var encryptPassword = SecurityService.Encrypt(login.Password);
            return _context.Set<User>().FirstOrDefault(u => u.User_Name == login.User_Name && u.Password == encryptPassword);
        }
      
        public void Registration(RegistrationViewModel registration)
        {
            User user = new User();
            user.User_Name = registration.User_Name;
            user.Password = SecurityService.Encrypt(registration.Password);
            user.Rol = registration.Rol;
            this.Insert(user);
        }
    }
}
