using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericClass.Custom
{
    class GenericObject<T> : IGenericObject<T> where T : class, new()
    {
        public string GetStringFromObject(T obj, string type)
        {
            string res = string.Empty;
            PropertyInfo prop = obj.GetType().GetProperty(type);
            if (prop != null)
            {
                res = prop.GetValue(obj).ToString();
            }
            return res;
        }

        public T SetValueObject(Dictionary<string, string> values, Dictionary<string, string> l)
        {
            T obj = new T();

            foreach (KeyValuePair<string, string> kvp in l)
            {
                if (values.ContainsKey(kvp.Key))
                {
                    PropertyInfo prop = obj.GetType().GetProperty(values[kvp.Key]);
                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(obj, kvp.Value, null);
                    }
                }
            }


            return obj;
        }
    }
}
