﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();

        Heading GetByID(int id);

        void HeadingAdd(Heading heading);

        void HeadingDelete(Heading heading);

        void HeadingUpdate(Heading heading);
    }
}