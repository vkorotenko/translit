﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kvn.Translit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kvn.TranslitTests
{
    [TestClass]
    public class HgTests
    {
        [TestMethod]
        public void InstantiateTest()
        {
            var src = "Жизнь";
            var expected = "zhizn";
            var actual = src
                .Translit(Lang.HG)
                .GetWebSafe();
            Assert.AreEqual(expected, actual);
        }
    }
}
