using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CheckAttendance
{
    public static class Extensions
    {
        public static List<Type> GetAssainableTypes<T>(this Assembly assembly)
        {
            return assembly.GetAssainableTypes(typeof(T));
        }

        public static List<Type> GetAssainableTypes(this Assembly assembly, Type currentType)
        {
            var result = new List<Type>();
            foreach(var t in assembly.DefinedTypes)
            {
                if(currentType.IsAssignableFrom(t) && currentType != t)
                    result.Add(t);
            }

            return result;
        }
    }
}
