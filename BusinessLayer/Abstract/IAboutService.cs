﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();

        About GetByID(int id);

        void AboutAdd(About about);

        void AboutDelete(About about);

        void AboutUpdate(About about);
    }
}