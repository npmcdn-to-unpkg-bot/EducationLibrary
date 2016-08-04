using EducationLibrary.Entities.Entities;
using EducationLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface ICategoryManager
    {
        Category GetCategory(int categoryId);

        int AddCategory(Category category);

        bool DeleteCategory(int categotyId);

        int UpdateCategory(Category category);
    }
}
