using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Screw : Component
    {
        public string Color { get; set; }

        public Screw(int size, int cost, string color): base (size,cost) {
            this.Color = color;
            this.Cost = cost;
        }
        public override void PrintComponentInfo()
        {
            Console.WriteLine($"Screw: size={Size} and Cost {Cost}");
        }
    }
}
