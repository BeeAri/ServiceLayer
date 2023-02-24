using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models;
using System.Collections;

namespace ServiceLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusteriController : Controller
    {
        [HttpGet]
        public ActionResult<List<VMusteri>> Index()
        {
            ETicaretContext ctx = new ETicaretContext();
            return ctx.VMusteriler.ToList();
        }




        //[HttpGet]
        //public ActionResult<IEnumerable> Index()
        //{
        //    ETicaretContext ctx = new ETicaretContext();
        //    return ctx.Musteris.Select(m => new Kisi 
        //    {
        //     //MusteriId=m.MusteriId,
        //     Ad=m.MusteriAdi,
        //     Soyad=m.MusteriSoyadi,
        //     Id=System.Guid.NewGuid(), //id verir otomatik
        //     //Adres=m.Adres,
        //     //DogumTarihi=m.DogumTarihi,
        //     //Email=m.Email,
        //     //Gsm=m.Gsm

        //    }).ToList();
        //}

        //public class Kisi
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set; }
        //    public Guid Id { get; internal set; }

        //    //public string Id { get; set; }
        //}

    }
}
