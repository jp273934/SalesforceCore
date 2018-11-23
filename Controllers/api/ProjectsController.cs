using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly IUnitOfWork _unifOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unifOfWork = unitOfWork;
        }

        public IActionResult Get()
        {
            var projects = _unifOfWork.projects.Get();

            return Json(projects);
        }
    }
}