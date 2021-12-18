using System;

namespace ConsoleApp
{
    public class ExternalServiceProxy
    {
        private readonly string _token;
        private readonly string _login;
        private readonly string _password;

        public ExternalServiceProxy(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public ExternalServiceProxy(string token)
        {
            _token = token;
        }

        public void MakeRequest()
        {
            var dateNow = DateTime.Now;
            if (string.IsNullOrEmpty(_token))
            {
                //выполнение вызова, используя логин и пароль
            }
            else
            {
                //сделать вызов с помощью токена
            }
        }
    }
}