using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface IDBManager : 
        IResourceManager,
        IFavouriteManager,
        ICategoryManager,
        ISubCategoryManager,
        IAuthorManager
    { }
}
