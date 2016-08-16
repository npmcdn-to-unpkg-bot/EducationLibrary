using EducationLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationLibrary.Entities;

namespace EducationLibrary.Services
{
    public class PreviewService : IPreviewService
    {
        public void DeletePreview(IEnumerable<Preview> previews)
        {
            throw new NotImplementedException();
        }

        public void DeletePreview(Preview preview)
        {
            _col.Remove(preview);
        }

        public IEnumerable<Preview> GetAllPreviews()
        {
            return _col;
        }

        public Preview GetPreviewById(int previewId)
        {
            return _col.Find(o => o.Id == previewId);
        }

        public void InsertPreview(IEnumerable<Preview> previews)
        {
            _col.AddRange(previews);
        }

        public void InsertPreview(Preview preview)
        {
            _col.Add(preview);
        }

        public void UpdatePreview(IEnumerable<Preview> previews)
        {
            throw new NotImplementedException();
        }

        public void UpdatePreview(Preview preview)
        {
            int index = _col.FindIndex(i => i.Id == preview.Id);
            _col[index].Name = preview.Name;
            _col[index].Address = preview.Address;
            _col[index].AuthorId = preview.AuthorId;
            _col[index].BookmarkPosition = preview.BookmarkPosition;
            _col[index].IsFavourite = preview.IsFavourite;
            _col[index].YearEdition = preview.YearEdition;
            _col[index].Rating = preview.Rating;
            _col[index].Length = preview.Length;

        }

        #region Mock collection

        private static List<Preview> _col = new List<Preview>()
        {
            new Preview {
                Id = 1,
                Address = "Some adreses 1",
                AuthorId = 100,
                BookmarkPosition = 0,
                Length = 1111,
                IsFavourite = false,
                Name = "Some book 1",
                NumOfViews = 1,
                Rating = 1,
                YearEdition = DateTime.Now },
            new Preview {
                Id = 2,
                Address = "Some adreses 2",
                AuthorId = 109,
                BookmarkPosition = 0,
                Length = 1112,
                IsFavourite = true,
                Name = "Some book 2",
                NumOfViews = 2,
                Rating = 3,
                YearEdition = DateTime.Now },
            new Preview {
                Id = 3,
                Address = "Some adreses 3",
                AuthorId = 160,
                BookmarkPosition = 0,
                Length = 1113,
                IsFavourite = false,
                Name = "Some book 3",
                NumOfViews = 3,
                Rating = 4,
                YearEdition = DateTime.Now },
            new Preview {
                Id = 4,
                Address = "Some adreses 4",
                AuthorId = 105,
                BookmarkPosition = 0,
                Length = 1114,
                IsFavourite = true,
                Name = "Some book 4",
                NumOfViews = 4,
                Rating = 5,
                YearEdition = DateTime.Now },
            new Preview {
                Id = 5,
                Address = "Some adreses 5",
                AuthorId = 123,
                BookmarkPosition = 0,
                Length = 1115,
                IsFavourite = false,
                Name = "Some book 5",
                NumOfViews = 5,
                Rating = 1,
                YearEdition = DateTime.Now },
        };

        #endregion
    }
}
