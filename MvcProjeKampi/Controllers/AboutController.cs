using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutValues = abm.GetList();
            return View(aboutValues);
        }

        public ActionResult AddAbout(About p)
        {
            abm.AboutAdd(p);
            return RedirectToAction("Index");
        }
    }
}