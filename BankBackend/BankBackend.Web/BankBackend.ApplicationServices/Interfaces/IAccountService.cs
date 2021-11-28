using BankBackend.ApplicationServices.Models;
using BankBackend.ApplicationServices.Results;

namespace BankBackend.ApplicationServices.Interfaces
{
    public interface IAccountService
    {
        AddAccountResult AddAccount(AddAccountModel model);
        void UpdateAccount(UpdateAccountModel model);
    }
}