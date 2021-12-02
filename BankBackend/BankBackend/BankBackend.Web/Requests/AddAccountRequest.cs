namespace BankBackend.Requests
{
    public class AddAccountRequest
    {
        /// <summary>
        /// ФИО открывателя счёта
        /// </summary>
        public string CreatorName { get; set; }
        
        /// <summary>
        /// Валюта
        /// </summary>
        public int Currency { get; set; }
        
        /// <summary>
        /// Название счёта
        /// </summary>
        public string AccountName { get; set; }
    }
}