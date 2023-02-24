using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiparisController : Controller
    {
        [HttpGet]
        public ActionResult<List<VSiparis>> Index()
        {

            ETicaretContext ctx = new ETicaretContext();
            return ctx.VSiparisler.ToList();

        }
    }
}
