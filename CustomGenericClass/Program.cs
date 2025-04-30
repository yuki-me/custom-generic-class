using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenericClass.Custom;

namespace CustomGenericClass
{
    class Program
    {
        private static Dictionary<string, string> mapping = new Dictionary<string, string>{
            {"SampleName", "Name" },
            {"SampleGender", "Gender" },
            {"SampleEmail", "Email" }
        };

        private static Dictionary<string, string> value = new Dictionary<string, string>
        {
            {"SampleName", "Bro" },
            {"SampleGender", "Male" },
            {"SampleEmail", "Bro@Bro.com" }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Start App");
            SampleClass obj = new GenericObject<SampleClass>().SetValueObject(mapping, value);
            Console.WriteLine(new GenericObject<SampleClass>().GetStringFromObject(obj, "Gender"));


            Console.ReadKey();
        }
    }
}
