using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly IUnitOfWork _unifOfWork;

        public ContactsController(IUnitOfWork unitOfWork)
        {
            _unifOfWork = unitOfWork;
        }

        public IActionResult Get()
        {
            var contacts = _unifOfWork.contacts.Get();

            return Json(contacts);
        }
    }
}