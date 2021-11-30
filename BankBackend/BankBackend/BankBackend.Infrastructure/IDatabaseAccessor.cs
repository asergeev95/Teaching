using BankBackend.Core.Entities;

namespace BankBackend.Infrastructure
{
    public interface IDatabaseAccessor
    {
        void CreateNewAccount(Account account);
        //Entity Framework
    }
}