using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public class Factory<T>
    {
        private Factory()
        {
        }

        static readonly Dictionary<string,Type> _dictionary = new Dictionary<string, Type>();

        public static T Create(string name,params object[] args)
        {
            Type type = null;
            if(_dictionary.TryGetValue(name,out type))
            {
                return (T)Activator.CreateInstance(type,args);
            }
            throw new ArgumentException("No type registered for this name");
        }

        public static void Register<Tderived>(string name) where Tderived:T
        {
            var type = typeof(Tderived);
            if(type.IsInterface || type.IsAbstract)
            {
                throw new ArgumentException("Invalid type");
            }
            _dictionary.Add(name,type);
        }
    }
}