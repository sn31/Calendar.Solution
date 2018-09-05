using Calendar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calendar.TestTools
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_NumberDivisibleByFour_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
        }

        [TestMethod]
        public void IsLeapYear_NumberNotDivisibleByFour_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
        }
        [TestMethod]
        public void IsLeapYear_MultiplesOfOneHundred_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(1800));
        }
        [TestMethod]
        public void IsLeapYear_MultiplesOFFourHundred_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
        }
    }
}