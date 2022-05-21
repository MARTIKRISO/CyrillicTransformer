using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrilicTransformer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string _text = "Анко Разпопчето се спряпаше от срам, колчем срещнеше човек в панталони от черно сукно. \n -Като беше постоянно слисан с търговските си работи, Марко само на трапезата виждаше народа си вкуп и тогава допълняше възпитанието му по доста своеобразен начин";
            CyrilicTransformer.ConverterV2 _converter = new CyrilicTransformer.ConverterV2();
            Console.OutputEncoding = Encoding.UTF8;
            ConverterV2 conv = new ConverterV2();
            string hui = conv.Encode(_text);
            Console.WriteLine(hui);
            string hui2 = conv.Decode(hui);
            Console.WriteLine(hui2);
        }
    }
}
