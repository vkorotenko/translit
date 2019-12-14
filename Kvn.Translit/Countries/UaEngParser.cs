#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  20.08.2019 23:16
#endregion

using System.Collections.Generic;

namespace Kvn.Translit.Countries
{
    public class UaEngParser : BaseParser
    {
        public UaEngParser(Schema schema) : base(schema)
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
                {'Ы', "y`"},
                {'Ь', "`"},
                {'Ъ', "a`"},
                {'Э', "e`"},
                {'Ю', "yu"},
                {'Я', "ya"},
                {'’', "'"},
                {'№', "#"},
                {'_', "_"},
                {'-', "-"},
                {'ї'.ToString().ToUpper()[0],"i" },
                {'Є',"ye"}
            };
        }
    }
}
