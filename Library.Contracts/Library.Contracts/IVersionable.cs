using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Contracts
{
    public interface IVersionable : IIdentifiable
    {
        public byte[] RowVersion { get; set; }
    }
}
