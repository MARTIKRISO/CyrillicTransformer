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
            string hui = conv.Encode("Спас Мирише!?.");
            Console.WriteLine(hui);
            string hui2 = conv.Decode(hui);
            Console.WriteLine(hui2);
            //TODO: Write unit tests to see if it works for longer texts
            //TODO: Handle numbers
        }
    }
}
