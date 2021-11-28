using BankBackend.Core.Entities;

namespace BankBackend.Infrastructure.EntityFramework
{
    public interface IDatabase
    {
        void AddAccount(Account account);
    }
}