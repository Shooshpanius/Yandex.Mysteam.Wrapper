using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YandexMystem.Wrapper.Enums;

namespace YandexMystem.Wrapper.Tests
{
    [TestClass]
    public class OptionsToolTest
    {
        [TestMethod]
        public void GetArgsStringTest()
        {
            var options = (MystemExecuteOptions.WordPerLineOutput | MystemExecuteOptions.OnlyLems);
            var result = Tools.MystemOptionsTool.GetStringArgs(options);

            Assert.AreEqual(result, "-n -l");
        }
    }
}
