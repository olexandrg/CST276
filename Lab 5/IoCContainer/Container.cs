using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class Container
    {
        public object GetInstance(Type type)
        {
            Type moduleType = type.GetType();
            Type[] types = new Type[1];
            types[0] = type.GetType();

            ConstructorInfo constructorInfoObj = moduleType.GetConstructor(types);

            return Activator.CreateInstance(type.GetType(), constructorInfoObj.GetParameters());
        }

        public T GetInstance<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
