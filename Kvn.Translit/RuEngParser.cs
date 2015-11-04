using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvn.Translit
{
    public class RuEngParser
    {
        private Dictionary<char, string> _ruEngDict; 
        public RuEngParser()
        {
            InitialiseRuEng();
        }

        private void InitialiseRuEng()
        {
            _ruEngDict = new Dictionary<char, string>
            {
                {'А', "a"},
                {'Б', "b"},
                {'В', "v"},
                {'Г', "g"},
                {'Д', "d"},
                {'Е', "e"},
                {'Ё', "yo"},
                {'Ж', "zh"},
                {'З', "z"},
                {'И', "i"},
                {'Й', "j"},
                {'К', "k"},
                {'Л', "l"},
                {'М', "m"},
                {'Н', "n"},
                {'О', "o"},
                {'П', "p"},
                {'Р', "r"},
                {'С', "s"},
                {'Т', "t"},
                {'У', "u"},
                {'Ф', "f"},
                {'Х', "x"},
                {'Ц', "cz"},
                {'Ч', "ch"},
                {'Ш', "sh"},
                {'Щ', "shh"},
                {'Ъ', "``"},
                {'Ы', "y`"},
                {'Ь', "`"},
                {'Э', "e`"},
                {'Ю', "yu"},
                {'Я', "ya"},
                {'’', "'"},
                {'№', "#"}
            };
        }
        /// <summary>
        /// Транслитерирует согласно стандарту https://ru.wikipedia.org/wiki/ISO_9
        /// </summary>
        /// <param name="source">Входящая строка</param>
        /// <returns></returns>
        public string Transliterate(string source)
        {
            var sb = new StringBuilder();
            source = source.ToUpper();
            foreach (var ch in source)
            {
                sb.Append(_ruEngDict[ch]);
            }
            return sb.ToString();
        }
    }
}
