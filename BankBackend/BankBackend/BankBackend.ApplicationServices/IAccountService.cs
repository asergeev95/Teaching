using BankBackend.ApplicationServices.Models;

namespace BankBackend.ApplicationServices
{
    public interface IAccountService
    {
        void CreateNewAccount(AddAccountModel model);
    }
}