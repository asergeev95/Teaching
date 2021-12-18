using System.Threading.Tasks;

namespace ConsoleApp.WorkWithObjectc
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
        
        public Task MakeRequest(object model)
        {
            if (string.IsNullOrEmpty(_token))
            {
                //сделать запрос, используя логин и пароль
            }
            else
            {
                //сделать запрос, используя токен
            }
            return Task.CompletedTask;
        }
    }
}