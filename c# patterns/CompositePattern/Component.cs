using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class  Component
    {
        public int Size { get; set; }
        public int Cost { get; set; }

        public Component(int size, int cost) {
            this.Size = Size;
            this.Cost = cost;
        }
        public abstract void PrintComponentInfo();
    }
}
