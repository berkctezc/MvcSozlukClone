﻿using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
   public class ContentManager: IContentService
    {
        private IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetList(int id)
        {
            return _contentDal.List(x=>x.ContentID==id);
        }

        public void ContentAdd(Content content)
        {
            _contentDal.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }

        public Content GetByID(int id)
        {
            return _contentDal.Get(x => x.ContentID == id);
        }
    }
}