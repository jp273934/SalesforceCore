using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IUnitOfWork _unifOfWork;

        public AccountsController(IUnitOfWork unitOfWork)
        {
            _unifOfWork = unitOfWork;
        }

        public IActionResult GetAction()
        {
            var accounts = _unifOfWork.accounts.Get();

            return Json(accounts);
        }
    }
}