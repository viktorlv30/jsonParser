using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JSON_PARSE
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ser = new DataContractJsonSerializer(typeof(Order),
                new List<Type>()
                {
                    typeof(SearchDump),
                    typeof(Product),
                    typeof(CreateDump),
                    typeof(User)
                });

            var ord = (Order) ser.ReadObject(new FileStream(@"d:\docs\C#\JSON_PARSE\source.json",
                FileMode.Open, FileAccess.Read));
            Console.ReadKey();

        }
    }
}
