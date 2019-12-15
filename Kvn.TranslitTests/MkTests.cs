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
    public class MkTests
    {
        [TestMethod]
        public void InstantiateTest()
        {
            var src = "Жизнь";
            var expected = "zhizn";
            var actual = src
                .Translit(Lang.MK)
                .GetWebSafe();
            Assert.AreEqual(expected, actual);
        }
    }
}
