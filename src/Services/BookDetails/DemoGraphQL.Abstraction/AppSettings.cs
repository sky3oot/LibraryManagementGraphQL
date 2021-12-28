using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGraphQL.Abstraction
{
    public class AppSettings
    {
        public string VirtualDirectory { get; set; }

        public string MongoServerName { get; set; }

        public string MongoDatabaseName { get; set; }
    }
}
