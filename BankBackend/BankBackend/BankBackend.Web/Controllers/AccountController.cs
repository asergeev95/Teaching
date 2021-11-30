using BankBackend.ApplicationServices;
using BankBackend.ApplicationServices.Models;
using BankBackend.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BankBackend.Controllers
{
    [Route("api/v1/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost("create")]
        public void CreateNewAccount([FromBody] AddAccountRequest request)
        {
            _accountService.CreateNewAccount(new AddAccountModel
            {
                Currency = request.Currency,
                AccountName = request.AccountName,
                CreatorName = request.CreatorName
            });
        }
    }
}