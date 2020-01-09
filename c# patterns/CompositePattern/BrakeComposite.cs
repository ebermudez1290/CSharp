using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class BrakeComposite : Component, IComposite
    {
        public string Material { get; set; }
        public string Color { get; set; }

        private List<Component> InternalComponents { get; set; }

        public BrakeComposite(int size, int cost, string material, string color) : base (size,cost) {
            this.Color = color;
            this.Material = material;
            InternalComponents = new List<Component>();
        }

        public void Add(Component component)
        {
            InternalComponents.Add(component);
        }

        public void Remove(Component component)
        {
            InternalComponents.Remove(component);
        }

        public override void PrintComponentInfo()
        {
            Console.WriteLine($"Brake: My Material is : {Material} and my Color is:{Color}, and these are my components:");
            foreach (var internalComponent in InternalComponents)
            {
                internalComponent.PrintComponentInfo();
            }
        }
    }
}
