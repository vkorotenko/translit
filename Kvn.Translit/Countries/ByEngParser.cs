using System.Collections.Generic;

namespace Kvn.Translit.Countries
{
    public class ByEngParser : BaseParser
    {
        public ByEngParser(Schema schema) : base(schema)
        {
        }
        protected override void Initialize()
        {
            TrDictionary = new Dictionary<char, string>
            {
                {'А', "a"},
                {'Б', "b"},
                {'В', "v"},
                {'Г', "h"},
                {'Д', "d"},
                {'Е', "e"},
                {'Ё', "yo"},
                {'Ж', "zh"},
                {'З', "z"},
                
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
                
                {'Ъ', "``"},
                {'Ы', "y`"},
                {'Ь', "`"},
                {'Э', "e`"},
                {'Ю', "yu"},
                {'Я', "ya"},
                {'’', "'"},
                {'№', "#"},
                {'_', "_"},
                {'-', "-"}
            };
        }
    }
}