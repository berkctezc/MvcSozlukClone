using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        Writer GetByID(int id);
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);

    }
}