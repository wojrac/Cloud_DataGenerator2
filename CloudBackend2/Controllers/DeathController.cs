using System.Collections.Generic;
using CloudBackend1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudBackend1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeathController : Controller
    {

        //HTTP GET : api/death
        [HttpGet]
        public ActionResult GetStatistics()
        {
            AreaManager areaManager = new AreaManager();
            areaManager.GenerateDeaths();
            var list = areaManager.Areas;
            return Json(list);
        }
    }
}
