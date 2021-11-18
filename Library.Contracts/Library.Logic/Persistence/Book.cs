using Library.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Persistence
{
    class Book : VersionEntity, IBook
    {
        public string Title { get; set; }
        public IAuthor Author { get; set; }
        public IGenre Genre { get; set; }
        public string Description { get; set; }
    }
}
