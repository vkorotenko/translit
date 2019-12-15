using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kvn.Translit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kvn.TranslitTests
{
    [TestClass]
    public class ByTests
    {
        [TestMethod]
        public void InstantiateTest()
        {
            var src = "жыццё";
            var expected = "zhyczczyo";
            var actual = src
                .Translit(Lang.BY)
                .GetWebSafe();
            Assert.AreEqual(expected, actual);
        }
    }
}
