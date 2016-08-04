using EducationLibrary.Entities.Entities;
using EducationLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface IResourceManager
    {
        Resource Get(int resourceId);

        IEnumerable<Resource> GetMany(int[] resourcesId, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetMany(ResourseType mediaType, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetMany(int subcategoryId, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetMany(Location location, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetMany(Languages language, Dictionary<string, object> opts = null);

        bool Delete(int resourceId);

        int Add(Resource resource);

        int Update(Resource recource);
    }
}
