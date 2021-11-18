using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    internal abstract partial class IdentityEntity : IIdentifiable
    {
        public int Id { get; set; }
    }
}
