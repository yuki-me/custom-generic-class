using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericClass.Custom
{
    interface IGenericObject<T>
    {
        T SetValueObject(Dictionary<string, string> values, Dictionary<string, string> lists);
        string GetStringFromObject(T obj, string type);
    }
}
