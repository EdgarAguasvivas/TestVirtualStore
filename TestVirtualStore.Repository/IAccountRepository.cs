using TestVirtualStore.DataAccess;
using TestVirtualStore.DataAccess.ViewModels;

namespace TestVirtualStore.Repository
{
    public interface IAccountRepository : IRepository<User>
    {
        User Login(LoginViewModel login);
        void Registration(RegistrationViewModel registration);
    }
}
