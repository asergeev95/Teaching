using BankBackend.ApplicationServices.Models;
using BankBackend.Core.Entities;
using BankBackend.Infrastructure;

namespace BankBackend.ApplicationServices
{
    public class AccountService : IAccountService
    {
        private readonly IDatabaseAccessor _databaseAccessor;

        public AccountService(IDatabaseAccessor databaseAccessor)
        {
            _databaseAccessor = databaseAccessor;
        }
        public void CreateNewAccount(AddAccountModel model)
        {
            var account = new Account
            {
                Currency = model.Currency,
                AccountName = model.AccountName,
                CreatorName = model.CreatorName
            };
            _databaseAccessor.CreateNewAccount(account);
        }
    }
}