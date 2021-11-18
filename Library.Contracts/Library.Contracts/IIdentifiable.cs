using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    public interface IIdentifiable
    { 
        public int Id { get; set; }
    }
}
