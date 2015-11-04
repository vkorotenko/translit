using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kvn.Translit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvn.Translit.Tests
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