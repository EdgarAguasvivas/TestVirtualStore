using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;
using TestVirtualStore.DataAccess.ViewModels;
using TestVirtualStore.Repository;

namespace TestVirtualStore.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _userRepository;


        public AccountService(IAccountRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public User Login(LoginViewModel login)
        {
            return _userRepository.Login(login);
        }
       
        public void Registration(RegistrationViewModel registration)
        {
             _userRepository.Registration(registration);
        }
    }
}
