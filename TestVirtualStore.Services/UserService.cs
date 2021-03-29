using System.Collections.Generic;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Repository;
using TestVirtualStore.Repository.Helpers;

namespace TestVirtualStore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        

        public UserService(IRepository<User> userRepository)
        {
            this._userRepository = userRepository;           
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return _userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            user.Password = SecurityService.Encrypt(user.Password);
            _userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {           
            User user = GetUser(id);
            _userRepository.Remove(user);
            _userRepository.SaveChanges();
        }
    }
}
