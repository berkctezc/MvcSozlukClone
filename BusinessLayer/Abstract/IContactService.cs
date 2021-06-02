﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();

        Contact GetByID(int id);

        void ContactAdd(Contact contact);

        void ContactDelete(Contact contact);

        void ContactUpdate(Contact contact);
    }
}