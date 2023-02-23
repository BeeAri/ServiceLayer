using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusteriController : Controller
    {
        [HttpGet]
        public ActionResult<List<Musteri>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.Musteris.ToList();
        }
    }
}
