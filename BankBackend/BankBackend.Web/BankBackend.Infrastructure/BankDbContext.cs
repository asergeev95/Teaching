using BankBackend.Core.Entities;
using BankBackend.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BankBackend.Infrastructure
{
    public class BankDbContext : DbContext, IDatabase
    {
        //Entity Framework 5.0.12
        public void AddAccount(Account account)
        {
            Add(account);
        }
    }
}