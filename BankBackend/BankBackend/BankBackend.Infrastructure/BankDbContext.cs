using BankBackend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankBackend.Infrastructure
{
    public class BankDbContext : DbContext, IDatabaseAccessor
    {
        public void CreateNewAccount(Account account)
        {
            Add(account);
        }
    }
}