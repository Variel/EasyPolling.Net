using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPolling.Net
{
    public class ConnectionPool
    {
        public Lazy<List<PollingConnection>> Connections = new Lazy<List<PollingConnection>>();
    }
}
