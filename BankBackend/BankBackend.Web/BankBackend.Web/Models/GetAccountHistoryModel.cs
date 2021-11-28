using System;

namespace BankBackend.Web.Models
{
    public class GetAccountHistoryModel
    {
        public Guid AccountId { get; set; }
        
        public int? NumberOfRecords { get; set; }
    }
}