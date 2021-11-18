using Library.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Persistence
{
    class Author : VersionEntity, IAuthor
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
