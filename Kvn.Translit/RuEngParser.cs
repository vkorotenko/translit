#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  20.08.2019 23:16
#endregion
using System.Collections.Generic;
using System.Net;
using System.Text;

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
                {'№', "#"},
                {'_', "_"},
                {'-', "-"}
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
                try
                {
                    sb.Append(_ruEngDict[ch]);
                }
                catch
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Кодирует сроку в ЧПУ строку, выбрасывает мусорные символы
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public string TransliteUrlSafe(string source)
        {
            var translite = Transliterate(source);
            translite = translite.Replace(" ", "_");
            translite = translite.Replace("`", "");
            translite = translite.Replace("#", "");
            translite = translite.Replace("'", "");
            return WebUtility.HtmlEncode(translite);
        }
    }
}
