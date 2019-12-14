using System.Collections.Generic;

namespace Kvn.Translit.Countries
{
    public class MkEngParser : BaseParser
    {
        public MkEngParser(Schema schema) : base(schema)
        {
        }
        protected override void Initialize()
        {
            TrDictionary = new Dictionary<char, string>
            {
                {'А', "a"},
                {'Б', "b"},
                {'В', "v"},
                {'Г', "g"},
                {'Д', "d"},
                {'Е', "e"},
                
                {'Ж', "zh"},
                {'З', "z"},
                {'И', "i"},
                
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