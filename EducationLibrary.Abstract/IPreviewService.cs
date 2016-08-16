using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationLibrary.Entities;

namespace EducationLibrary.Abstract
{
    public interface IPreviewService
    {
        IEnumerable<Preview> GetAllPreviews();

        void DeletePreview(Preview preview);

        void DeletePreview(IEnumerable<Preview> previews);

        Preview GetPreviewById(int previewId);

        void InsertPreview(Preview preview);

        void InsertPreview(IEnumerable<Preview> previews);

        void UpdatePreview(Preview preview);

        void UpdatePreview(IEnumerable<Preview> previews);
    }
}
