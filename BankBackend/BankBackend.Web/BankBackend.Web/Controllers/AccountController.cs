using BankBackend.ApplicationServices.Interfaces;
using BankBackend.ApplicationServices.Models;
using BankBackend.Web.Requests;
using BankBackend.Web.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BankBackend.Web.Controllers
{
    [Route("api/v1/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("add")]
        public AddAccountResponse AddAccount([FromBody] AddAccountRequest request)
        {
            var result = _accountService.AddAccount(new AddAccountModel
            {
                Currency = request.Currency,
                AccountName = request.AccountName,
                CreatorName = request.CreatorName
            });
            return new AddAccountResponse
            {
                AccountId = result.AccountId
            };
        }
    }
}