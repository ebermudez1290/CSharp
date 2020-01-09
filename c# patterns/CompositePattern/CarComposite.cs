using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class CarComposite : Component, IComposite
    {
        public string Material { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        private List<Component> InternalComponents { get; set; }

        public CarComposite(int size, int cost, string material, string color, string brand) : base (size,cost) {
            this.Color = color;
            this.Material = material;
            this.Brand = brand;
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
            Console.WriteLine($"Car: My Material is : {Material} and my Color is:{Color}, and my brand is {Brand}, and these are my components:");
            foreach (var internalComponent in InternalComponents)
            {
                internalComponent.PrintComponentInfo();
            }
        }
    }
}
