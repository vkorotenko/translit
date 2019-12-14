#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:   


#endregion
using System.Net;

namespace Kvn.Translit
{
    public static class Helpers
    {
        /// <summary>
        /// Replace unsafe symbols and return HtmlEncoded string.
        /// Next symbols replace:
        /// " " -> "_"
        /// "`" -> ""
        /// "#" -> ""
        /// "'" -> ""
        /// </summary>
        /// <param name="source">String with unsafed for web symbols</param>
        /// <returns>String safe for web</returns>
        public static string GetWebSafe(this string source)
        {
            var value = source;
            value = value.Replace(" ", "_");
            value = value.Replace("`", "");
            value = value.Replace("#", "");
            value = value.Replace("'", "");
            return WebUtility.HtmlEncode(value);
        }
    }
}
