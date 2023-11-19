using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Reptilian : Animal
    {
        public override void Nutrition()
        {
            Console.WriteLine("A reptile is an insect-eating animal.");
        }
        public override void Movement()
        {
            Console.WriteLine("Reptile moves by crawling.");
        }
    }
}
