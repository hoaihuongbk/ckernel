using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cKernel;

namespace CKernel.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = new X2("",true);
            var str = x.SlashQuote("Đắk G'Long");
            var expertStr = @"Đắk G''Long";
            //var insert = string.Format("INSERT INTO tbl_Area(Name) VALUES(N'{0}')", str);

            Assert.Equals(str, expertStr);
        }
    }
}
