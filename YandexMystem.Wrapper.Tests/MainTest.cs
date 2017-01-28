using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexMystem.Wrapper.Tests
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void CheckMystemExists()
        {
            var mst = new Mysteam();
            Assert.IsTrue(File.Exists(mst.FilePath), "Файл mystem.exe не найден");
        }

        [TestMethod]
        public void GetResultTest()
        {
            var str = "включи тестовый режим";
            var mst = new Mysteam();
            var result2 = mst.GetWords(str);

            Assert.IsTrue(result2.Count>0);
        }
    }
}
