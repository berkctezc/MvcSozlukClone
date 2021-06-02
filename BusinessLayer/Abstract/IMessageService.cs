using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSentbox();

        Message GetByID(int id);

        void MessageAdd(Message message);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);

    }
}