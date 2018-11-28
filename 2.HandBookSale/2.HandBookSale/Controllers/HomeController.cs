using _2.HandBookSale.Models.EntityFramework;
using System.Linq;
using System.Web.Mvc;


namespace _2.HandBookSale.Controllers
{
    public class HomeController : Controller
        {

        BookSaleEntities db = new BookSaleEntities();

            public ActionResult Index()
            {
                var model = db.books.ToList();
                return View(model);

            }
            [Route("UyeOl")]

            public ActionResult UyeOl()
            {
                return View();
            }
            [Route("UyeGirisi")]
            public ActionResult UyeGirisi()
            {
                return View();
            }
            [Route("BizeUlasin")]
            public ActionResult BizeUlasin()
            {
                return View();
            }
        }
}
