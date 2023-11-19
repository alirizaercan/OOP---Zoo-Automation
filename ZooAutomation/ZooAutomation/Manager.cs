using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Manager : Personnel
    {
        public override void Work()
        {
            Console.WriteLine("The manager handles administrative work.");
        }
        public override void GiveReport()
        {
            Console.WriteLine("The manager reports the performance of the personnels.");
        }
    }
}
