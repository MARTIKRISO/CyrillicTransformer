using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyrilicTransformer;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string _text = "Анко Разпопчето се спряпаше от срам, колчем срещнеше човек в панталони от черно сукно. \n -Като беше постоянно слисан с търговските си работи, Марко само на трапезата виждаше народа си вкуп и тогава допълняше възпитанието му по доста своеобразен начин";
        CyrilicTransformer.ConverterV2 _converter = new CyrilicTransformer.ConverterV2();
        
        [TestMethod]
        public void Test()
        {
            string encoded = _converter.Encode(_text);
            string decoded = _converter.Decode(encoded);

            Assert.AreEqual(_text, decoded);
        }
    }
}