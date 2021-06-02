using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();

        Category GetByID(int id);

        void CategoryAdd(Category category);

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);
    }
}