using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public class Bird : Animal
    {
        public override void Nutrition()
        {
            Console.WriteLine("The bird is feeding on seeds.");
        }
        public override void Movement()
        {
            Console.WriteLine("The bird moves by flying.");
        }
    }
}
