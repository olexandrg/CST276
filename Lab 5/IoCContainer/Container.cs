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
        private ConstructorInfo GetMostParameters(ConstructorInfo[] infos)
        {
            ConstructorInfo largest = infos[0];

            int max_num = 0;

            foreach (var t in infos)
            {
                // loop thru and get the one with largest params
                int numParams = t.GetParameters().Length;
                if (numParams > max_num)
                {
                    largest = t;
                    max_num = numParams;
                }
            }

            return largest;
        }
        public object GetInstance(Type type)
        {
            ConstructorInfo[] infos = type.GetConstructors();
            ParameterInfo[] parameterinfos = GetMostParameters(infos).GetParameters();

            object[] parameters = new object[parameterinfos.Length];

            for (int i = 0; i < parameterinfos.Length; i++)
            {
                Type parameterType = parameterinfos[i].ParameterType;
                parameters[i] = GetInstance(parameterType);
            }

            return Activator.CreateInstance(type, parameters);
        }

        public T GetInstance<T>()
        {
            return (T) GetInstance(typeof(T));
        }
    }
}
