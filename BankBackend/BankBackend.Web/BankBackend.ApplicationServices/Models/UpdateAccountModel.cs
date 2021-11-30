using System;

namespace BankBackend.ApplicationServices.Models
{
    public class UpdateAccountModel
    {
        public Guid AccountId { get; set; }
        
        /// <summary>
        /// Название счёта
        /// </summary>
        public string AccountName { get; set; }
    }
}