#region License
// Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// email: koroten@ya.ru
// skype:vladimir-korotenko 
// https://vkorotenko.ru
// Создано:  20.08.2019 23:16
#endregion
using Kvn.Translit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kvn.TranslitTests
{
    [TestClass()]
    public class RuEngParserTests
    {
        private readonly ITransliterate _trans = Fabric.GetInstance();
        [TestMethod()]
        public void TransliterateTest()
        {            
            var result = _trans.Transliterate("Тест");
            Assert.AreEqual("test",result);
        }
        [TestMethod()]
        public void TransliterateSpecialTest()
        {            
            var result = _trans.Transliterate("Кабардино-Балкарская");
            Assert.AreEqual("kabardino-balkarskaya", result);
        }
        [TestMethod]
        public void MariyAlTest()
        {
            var teststring = "Марий Эл";            
            var result = _trans.Transliterate(teststring);
            Assert.AreEqual("marij e`l", result);
        }

        [TestMethod]
        public void TransliteUrlSafeTest()
        {
            var teststring = "Марий Эл";
            var result = _trans.Transliterate(teststring).GetWebSafe();
            Assert.AreEqual("marij_el", result);
        }
    }
}