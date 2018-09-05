using Calendar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calendar.TestTools
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_NumberDivisibleByFour()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
        }
    }
}