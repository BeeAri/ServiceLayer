using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TahsilatController : Controller
    {
        [HttpGet]
        public ActionResult<List<VTahsilat>> Index()
        {

            ETicaretContext ctx = new ETicaretContext();
            return ctx.VTahsilatlar.ToList();

        }
    }
}
