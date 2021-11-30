using System;

namespace BankBackend.ApplicationServices.Models
{
    public class GetAccountHistoryModel
    {
        public Guid AccountId { get; set; }
        
        public int? NumberOfRecords { get; set; }
    }
}