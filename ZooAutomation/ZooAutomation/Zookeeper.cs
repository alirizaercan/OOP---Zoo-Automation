using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Zookeeper : Personnel
    {
        public override void Work()
        {
            Console.WriteLine("The zookeeper feeds the animals.");
        }
        public override void GiveReport()
        {
            Console.WriteLine("The zookeeper reports the health status of the animals.");
        }
    }
}
