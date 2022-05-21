using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ConverterV2 conv = new ConverterV2();
            string hui = conv.Encode("12Спас 34Мирише!?.");
            Console.WriteLine(hui);
            string hui2 = conv.Decode(hui);
            Console.WriteLine(hui2);
        }
    }
}
