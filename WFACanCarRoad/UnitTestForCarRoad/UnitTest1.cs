using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFACanCarRoad;

namespace UnitTestForCarRoad
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string aPlate = "ABC-0001";
            string aDate = "03/26/2016";
            string aTime = "09:15";

            CarInfo objTest = new CarInfo(aPlate, aDate, aTime);

            bool Result = objTest.ValidationCanCarRoad();

            Assert.AreEqual(true, Result,"Test OK");
        }
    }
}
