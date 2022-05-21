using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Numerics;
using System.Linq;


namespace test1
{
    public class Converter{
        Dictionary<char, string> MAP;
        Dictionary<string, char> REVMAP;
        List<char> ALPHABET = new List<char>() { 'a', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ь', 'ю', 'я' };
        List<string> TRANSCRIPTION = new List<string>() { "a", "b", "v", "g", "d", "e", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", "c", "ch", "sh", "sht", "x", "xx", "yu", "ya" };

        public Converter()
        {
            var map = new Dictionary<char, string>();
            for (int a = 0; a < ALPHABET.Count; a++)
            {
                map.Add(ALPHABET[a], TRANSCRIPTION[a]);
            }
            this.MAP = map;
            this.REVMAP = MAP.ToDictionary(x => x.Value, x => x.Key);
        }

        public string ConvertToBulgarian(string text)
        {
            text = text.ToLower();
            string result = "";
            foreach (char c in text)
            {
                if (MAP.ContainsKey(c))
                {
                    result += (string)MAP[c];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public string ConvertToShliokavica(string text)
        {
            text = text.ToLower();
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                char nextletter = '1';
                char currentletter = text[i];
                try
                {
                    nextletter = text[i + 1];
                }
                catch (Exception)
                
                {
                    
                }
                if (MAP.ContainsValue(String.Concat(currentletter, nextletter)))
                {
                    result += REVMAP[String.Concat(currentletter, nextletter)];
                    i++;
                }
                else if (REVMAP.ContainsKey(currentletter.ToString()))
                {
                    result += REVMAP[currentletter.ToString()];
                }
                else
                {
                    result.Append(currentletter);
                }
            }
            return result;
        }
    }
}