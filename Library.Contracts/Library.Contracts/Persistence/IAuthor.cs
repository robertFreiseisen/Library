using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts.Persistence
{
    public interface IAuthor : IIdentifiable
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
