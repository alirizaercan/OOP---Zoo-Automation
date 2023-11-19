using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Veterinarian : Personnel
    {
        public override void Work()
        {
            Console.WriteLine("Veterinarian treats animals.");
        }
        public override void GiveReport()
        {
            Console.WriteLine("The veterinarian reports the treated animals.");
        }
    }
}
