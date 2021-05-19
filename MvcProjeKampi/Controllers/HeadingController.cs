using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        private HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
    }
}