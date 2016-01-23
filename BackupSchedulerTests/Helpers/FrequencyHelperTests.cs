using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackupScheduler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupScheduler.Helpers.Tests
{
    [TestClass()]
    public class FrequencyHelperTests
    {
        [TestMethod()]
        public void FrequencyEveryMinuteIsValidTest()
        {
            string testString = "* * * * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyOnceEveryYearIsValidTest()
        {
            string testString = "0 0 1 1 *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyOnceEveryYearAtEndIsValidTest()
        {
            string testString = "0 0 31 12 *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyFirstDayMonthIsValidTest()
        {
            string testString = "0 0 1 * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyLastDayMonthIsValidTest()
        {
            string testString = "0 0 31 * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyEverySundayIsValidTest()
        {
            string testString = "0 0 * * 0";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyEveryMondayIsValidTest()
        {
            string testString = "0 0 * * 5";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyEveryDayIsValidTest()
        {
            string testString = "0 0 * * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyAtTenAMsIsValidTest()
        {
            string testString = "0 10 * * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyEveryHourIsValidTest()
        {
            string testString = "0 * * * *";

            Assert.IsTrue(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyMinutesIsInvalidTest()
        {
            string testString = "60 * * * *";

            Assert.IsFalse(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyHoursIsInvalidTest()
        {
            string testString = "* 25 * * *";

            Assert.IsFalse(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyDaysIsInvalidTest()
        {
            string testString = "* * 35 * *";

            Assert.IsFalse(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyMonthsIsInvalidTest()
        {
            string testString = "* * * 25 *";

            Assert.IsFalse(FrequencyHelper.FrequencyIsValid(testString));
        }

        [TestMethod()]
        public void FrequencyDowIsInvalidTest()
        {
            string testString = "* * * * 15";

            Assert.IsFalse(FrequencyHelper.FrequencyIsValid(testString));
        }
    }
}