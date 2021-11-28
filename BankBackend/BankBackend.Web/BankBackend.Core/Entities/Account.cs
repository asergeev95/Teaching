namespace BankBackend.Core.Entities
{
    public class Account
    {
        /// <summary>
        /// ФИО открывателя счёта
        /// </summary>
        public string CreatorName { get; set; }
        
        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency { get; set; }
        
        /// <summary>
        /// Название счёта
        /// </summary>
        public string AccountName { get; set; }
    }
}