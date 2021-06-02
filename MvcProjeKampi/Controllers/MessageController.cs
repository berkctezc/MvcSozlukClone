using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        private MessageManager mm = new MessageManager(new EfMessageDal());

        public ActionResult Inbox()
        {
            var messageList = mm.GetListInbox();
            return View(messageList);
        }
        public ActionResult Sentbox()
        {
            var messageList = mm.GetListSentbox();
            return View(messageList);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}
