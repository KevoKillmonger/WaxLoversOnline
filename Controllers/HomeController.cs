using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WaxLoversOnline.Models;

namespace WaxLoversOnline.Controllers
{
    public class HomeController : Controller
    {
        MVCMUSICSTOREEntities storeDB = new MVCMUSICSTOREEntities();
        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);

            return View(albums);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

    }
}
