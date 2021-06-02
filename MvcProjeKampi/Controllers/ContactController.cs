using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        private ContactManager cm = new ContactManager(new EfContactDal());
        private ContactValidator cv = new ContactValidator();

        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }
    }
}