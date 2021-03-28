using System.Collections.Generic;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Repository;

namespace TestVirtualStore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        

        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;           
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {           
            User user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }
}
