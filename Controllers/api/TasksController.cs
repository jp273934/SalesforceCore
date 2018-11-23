using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly IUnitOfWork _unifOfWork;

        public TasksController(IUnitOfWork unitOfWork)
        {
            _unifOfWork = unitOfWork;
        }

        public IActionResult Get()
        {
            var tasks = _unifOfWork.tasks.Get();

            return Json(tasks);
        }
    }
}