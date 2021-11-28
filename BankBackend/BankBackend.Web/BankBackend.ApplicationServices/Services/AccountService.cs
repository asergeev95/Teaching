using System;
using BankBackend.ApplicationServices.Interfaces;
using BankBackend.ApplicationServices.Models;
using BankBackend.ApplicationServices.Results;
using BankBackend.Core.Entities;
using BankBackend.Infrastructure.EntityFramework;

namespace BankBackend.ApplicationServices.Services
{
    public class AccountService : IAccountService
    {
        private readonly IDatabase _database;

        public AccountService(IDatabase database)
        {
            _database = database;
        }
        public AddAccountResult AddAccount(AddAccountModel model)
        {
            var accountEntity = new Account
            {
                Currency = model.Currency,
                AccountName = model.AccountName,
                CreatorName = model.CreatorName
            };
            _database.AddAccount(accountEntity);
            //какая-то логика по сохранению в базу
            //сущность, entity
            return new()
            {
                AccountId = Guid.NewGuid()
            };
        }

        public void UpdateAccount(UpdateAccountModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}