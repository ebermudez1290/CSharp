using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class WheelComposite : Component, IComposite
    {
        public int Diameter { get; set; }

        private List<Component> InternalComponents { set; get; }

        public WheelComposite(int size, int cost, int diameter) : base(size,cost) {
            this.Diameter = diameter;
            InternalComponents = new List<Component>();
        }

        public void Add(Component component) {
            InternalComponents.Add(component);
        }

        public void Remove(Component component)
        {
            InternalComponents.Remove(component);
        }

        public override void PrintComponentInfo()
        {
            Console.WriteLine($"Wheel: My Diameter is : {Diameter} and these are my components:");
            foreach (var internalComponent in InternalComponents)
            {
                internalComponent.PrintComponentInfo();
            }
        }
    }
}
