using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class ConverterV2
    {
        Dictionary<char, string> MAP;
        Dictionary<string, char> REVMAP;
        List<char> ALPHABET = new List<char>() { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь', 'ю', 'я', '?', '!', '.', ' ' };
        List<string> TRANSCRIPTION = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "00"};
        public ConverterV2()
        {
            var map = new Dictionary<char, string>();
            for (int a = 0; a < ALPHABET.Count; a++)
            {
                map.Add(ALPHABET[a], TRANSCRIPTION[a]);
            }
            this.MAP = map;
            this.REVMAP = MAP.ToDictionary(x => x.Value, x => x.Key);
        }
        private bool IsCapital(char letter) => letter == Char.ToUpper(letter);
        private bool CharToBool(char letter) => Convert.ToBoolean(Convert.ToInt16(letter.ToString()));


        public string Encode(string text)
        {
            string result = "";

            foreach(char letter in text)
            {
                int isCapital = Convert.ToInt16(IsCapital(letter));
                char lowletter = Char.ToLower(letter);

                if (MAP.ContainsKey(lowletter))
                {
                    string equiv = isCapital + MAP[lowletter];
                    result += equiv;
                    Console.WriteLine("Appended {0} equivelent: {1}", letter, equiv);
                }
                else
                {
                    throw new Exception(String.Format("No equivelent for letter [{0}]", lowletter));
                }
            }

            return result;
        }
        public string Decode(string text)
        {
            string result = "";

            if (text.Length % 3 != 0) throw new Exception("Invalid input string");

            for(int i = 0; i < text.Length; i += 3)
            {
                string inputstr = text.Substring(i, 3);
                bool capital = CharToBool(inputstr[0]);
                string lettercode = String.Concat(inputstr[1], inputstr[2]);

                if (REVMAP.ContainsKey(lettercode))
                {
                    char letter = capital ? Char.ToUpper(REVMAP[lettercode]) : REVMAP[lettercode];
                    result += letter;
                    Console.WriteLine("Appended {0} equivelent: {1}", inputstr, letter);
                }
                else
                {
                    throw new Exception(String.Format("No equivelent for letter code [{0}]", inputstr));
                }
            }

            return result;

        }
    }
}
