using System.Collections.Generic;
using System.Text;

namespace Kvn.Translit.Countries
{
    public abstract class BaseParser: ITransliterate
    {
        private Schema schema;
        public BaseParser(Schema schema = Schema.B)
        {
            this.schema = schema;
            Initialize();
        }
        protected Dictionary<char, string> TrDictionary; 
        /// <summary>
        /// Transliterate by this https://ru.wikipedia.org/wiki/ISO_9
        /// </summary>
        /// <param name="source">Source</param>
        /// <returns>Transliterate string</returns>
        public string Transliterate(string source)
        {
            var sb = new StringBuilder();
            source = source.ToUpper();
            foreach (var ch in source)
            {
                try
                {
                    sb.Append(TrDictionary[ch]);
                }
                catch
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }

        protected abstract void Initialize();
    }
}
