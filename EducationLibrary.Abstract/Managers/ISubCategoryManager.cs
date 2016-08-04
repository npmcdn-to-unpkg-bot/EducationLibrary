using EducationLibrary.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface ISubCategoryManager
    {
        SubCategory GetSubCategory(int subCategoryId);

        int AddSubCategory(SubCategory subCategory);

        bool DeleteSubCategory(int subCategoryId);

        int UpdateSubCategory(SubCategory subCategory);
    }
}
