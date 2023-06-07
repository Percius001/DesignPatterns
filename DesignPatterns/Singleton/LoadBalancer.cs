using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer instance = new LoadBalancer();

        private readonly List<Server> servers;
        private readonly Random random = new Random();

        private LoadBalancer()
        {
            servers = new List<Server>
            {
                new Server{Name="Server I", IP="120.14.220.18"},
                new Server{Name="Server II", IP="120.14.220.19"},
                new Server{Name="Server III", IP="120.14.220.20"},
                new Server{Name="Server IV", IP="120.14.220.21"},
                new Server{Name="Server V", IP="120.14.220.22"}
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }
    }
}
