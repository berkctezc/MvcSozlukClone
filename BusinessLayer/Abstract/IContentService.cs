using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();

        List<Content> GetListByHeadingID(int id);

        Content GetByID(int id);

        void ContentAdd(Content content);

        void ContentDelete(Content content);

        void ContentUpdate(Content content);
    }
}