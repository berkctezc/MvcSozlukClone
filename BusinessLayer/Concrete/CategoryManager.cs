﻿using System;
using System.Collections.Generic;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();


        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" ||
                p.CategoryName.Length >= 51)
            {
                //hata
            }
            else
            {
                repo.Insert(p);
            }
        }

    }
}