using System;
using System.Linq;
using System.Reflection;

namespace iZet.DC.VIP.Helpers
{
    public static class ObjectHelper
    {
        public static object InstantinateClass(Type @class, Type[] types, params object[] parameters)
        {
            var ci = @class.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null,
                                           types, null);
//            if (ci == null)
//                ExceptionService.ThrowError(null, "Не найден конструктор для типа {0}", @class.ToString());

            return ci.Invoke(parameters);
        }

        public static Type[] GetParameterTypes(params object[] parameters)
        {
            return parameters.Select(o => o.GetType()).ToArray();
        }

        public static object InstantiateGenericClass(Type @class, Type genericType, Type[] types, params object[] parameters)
        {
            var specificType = @class.MakeGenericType(new[] { genericType });

            return InstantinateClass(specificType, types, parameters);
        }

        public static T InstantinateClass<T>(Type[] types, params object[] parameters)
        {
            return (T)InstantinateClass(typeof(T), types, parameters);
        }

        public static T InstantinateClass<T>()
        {
            return InstantinateClass<T>(Type.EmptyTypes);
        }
    }
}
