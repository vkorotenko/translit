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
        [TestMethod()]
        public void TransliterateTest()
        {
            var trans = new RuEngParser();
            var result = trans.Transliterate("Тест");
            Assert.AreEqual("test",result);
        }
    }
}