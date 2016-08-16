using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary.Entities
{
    public class Preview
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public DateTime YearEdition { get; set; }

        public double Rating { get; set; }

        public int NumOfViews { get; set; }

        public bool IsFavourite { get; set; }

        public double BookmarkPosition { get; set; }

        public double Length { get; set; }

        public string Address { get; set; }
    }
}
