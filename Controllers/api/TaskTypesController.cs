using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class TaskTypesController : Controller
    {
         private readonly IUnitOfWork _unifOfWork;

         public TaskTypesController(IUnitOfWork unitOfWork)
         {
             _unifOfWork = unitOfWork;
         }

         public IActionResult Get()
         {
             var taskTypes = _unifOfWork.tasktypes.Get();

             return Json(taskTypes);
         }
    }
}