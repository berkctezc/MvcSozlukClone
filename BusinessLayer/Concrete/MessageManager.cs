using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@admin.com");
        }

        public List<Message> GetListSentbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@admin.com");
        }

        public Message GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new System.NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
