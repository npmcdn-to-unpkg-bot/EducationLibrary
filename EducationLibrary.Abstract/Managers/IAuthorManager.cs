using EducationLibrary.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary.Abstract.Managers
{
    public interface IAuthorManager
    {
        Author GetAuthor(int authorId);

        int AddAuthor(Author author);

        bool DeleteAuthor(int authorId);

        int UpdateAuthor(Author author);
    }
}
