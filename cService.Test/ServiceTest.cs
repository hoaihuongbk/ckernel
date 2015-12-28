using System;
using System.Configuration;
using cModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace cService.Test
{
    [TestClass]
    public class ServiceTest
    {
        private const string Cs = "server=103.254.12.130;database=GCORE_001;uid=gcore;password=K8HqJaOGZR;";

        [TestMethod]
        public void TestGetMethod()
        {
            try
            {
                var s = new S(Cs);
                var obj = new GCRequest()
                {
                    _a = "fGet"
                };
            }
            catch (Exception)
            {
                
            }
        }


    }
}
