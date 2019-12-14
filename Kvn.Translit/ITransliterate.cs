namespace Kvn.Translit
{
    public interface ITransliterate
    {
        /// <summary>
        /// Транслитерирует согласно стандарту https://ru.wikipedia.org/wiki/ISO_9
        /// </summary>
        /// <param name="source">Входящая строка</param>
        /// <returns></returns>
        string Transliterate(string source);
    }
}