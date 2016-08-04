using EducationLibrary.Entities.Entities;
using EducationLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface IFavouriteManager
    {
        IEnumerable<Resource> GetFavourites(Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(ResourseType mediaType, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(int subcategoryId, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(Location location, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(Languages language, Dictionary<string, object> opts = null);

        int AddFavourite(int recourseId);

        bool DeleteFavourite(int recourseId);
    }
}
