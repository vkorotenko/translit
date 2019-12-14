#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  20.08.2019 23:16
#endregion

using Kvn.Translit.Countries;
using System;

namespace Kvn.Translit
{
    /// <summary>
    /// Fabric create instance of transliterate class. 
    /// </summary>
    public class Fabric
    {
        /// <summary>
        /// Get instance of transliterate class, by default create russian instance <see cref="Countries.RU"/>
        /// </summary>
        /// <param name="country">Transliterate language</param>
        /// <param name="schema">Transliterate on schema B - default</param>
        /// <returns></returns>
        public static ITransliterate GetInstance(Lang lang = Lang.RU, Schema schema = Schema.B)
        {
            switch (lang)
            {
                case Lang.RU:
                    return new RuEngParser(schema);
                case Lang.BY:
                    return new ByEngParser(schema);
                case Lang.UA:
                    return new UaEngParser(schema);
                case Lang.HG:
                   return new HgEngParser(schema);
                case Lang.MK:
                    return new MkEngParser(schema);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
