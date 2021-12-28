using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGraphQL.Abstraction
{
    public interface IEntity
    {
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
    }
}
