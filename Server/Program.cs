using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test Manager Server";

            LanServer server = new LanServer();
            server.Connect();

            Console.ReadKey();
        }
    }
}
