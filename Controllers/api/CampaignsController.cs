using Microsoft.AspNetCore.Mvc;
using SalesforceCore.Data;

namespace SalesforceCore.Controllers.api
{
    [Route("api/[controller]")]
    public class CampaignsController : Controller
    {
        private readonly IUnitOfWork _unifOfWork;

        public CampaignsController(IUnitOfWork unitOfWork)
        {
            _unifOfWork = unitOfWork;
        }

        public IActionResult Get()
        {
            var campaigns = _unifOfWork.campaigns.Get();

            return Json(campaigns);
        }
    }
}