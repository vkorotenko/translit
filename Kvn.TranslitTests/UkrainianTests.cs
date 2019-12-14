using Kvn.Translit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kvn.TranslitTests
{
    [TestClass]
    public class UkrainianTests
    {
        [TestMethod]
        public void TransliterateTest()
        {
            var sample = "З початку доби бойовики 5 разів порушили режим тиші, загинув український боєць";
            var trans = Fabric.GetInstance(Lang.UA);
            var actual = trans.Transliterate(sample);
            var expected = "z pochatku dobi bojoviki 5 razІv porushili rezhim tishІ, zahinuv ukrains`kij boyecz`";
            Assert.AreEqual(actual,expected);
        }
    }
}