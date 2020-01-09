﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface IComposite
    {
        void Add(Component component);
        void Remove(Component component);
    }
}
