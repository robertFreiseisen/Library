using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Persistence
{
    public interface IBook : IIdentifiable
    {
        public string Title { get; set; }
        public IAuthor Author { get; set; }
        public IGenre Genre { get; set; }
        public string Description { get; set; }
    }
}
