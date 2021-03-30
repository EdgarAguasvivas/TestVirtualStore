using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;
using TestVirtualStore.DataAccess.ViewModels;

namespace TestVirtualStore.Services
{
    public interface IAccountService
    {
        User Login(LoginViewModel login);
        void Registration(RegistrationViewModel registration);
    }
}
