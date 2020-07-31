﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Container
    {
        public object GetInstance(Type type)
        {
            return Activator.CreateInstance(type);
        }

        public T GetInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
