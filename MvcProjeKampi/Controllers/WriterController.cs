using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {
        private WriterManager wm = new WriterManager(new EfWriterDal());
        
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
    }
}