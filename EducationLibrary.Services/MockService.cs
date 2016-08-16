using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationLibrary.Entities;

namespace EducationLibrary.DAL
{
    public static class FakeResourceRepository
    {
        private static List<Preview> _fakeDB = new List<Preview> {
            new Preview { Id = 1, Name = "Priview1", AuthorId = 1 },
            new Preview { Id = 2, Name = "Priview2", AuthorId = 2 },
            new Preview { Id = 3, Name = "Priview3", AuthorId = 3 },
            new Preview { Id = 4, Name = "Priview4", AuthorId = 4 },
            new Preview { Id = 5, Name = "Priview5", AuthorId = 5 },
            new Preview { Id = 6, Name = "Priview6", AuthorId = 6 },
            new Preview { Id = 7, Name = "Priview7", AuthorId = 7 },
            new Preview { Id = 8, Name = "Priview8", AuthorId = 8 }
        };
        public static IList<Preview> FakeDB {
            get
            {
                return _fakeDB;
            }
            
        }


    }
}
