using Microsoft.AspNet.Mvc;
using webservice.Infrastructure.Interface.Service;

namespace webservice.Controllers
{
    public class AccountController : Controller
    {
        private  readonly IAccountService  _accountService ;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public object Login()
        {
            return _accountService.IsUserVerfied("", "");
        }
    }
}