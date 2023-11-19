using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Mamallian : Animal
    {
        public override void Nutrition()
        {
            Console.WriteLine("The mammal is an omnivorous animal.");
        }
        public override void Movement()
        {
            Console.WriteLine("The mammal moves by walking");
        }
    }
}
