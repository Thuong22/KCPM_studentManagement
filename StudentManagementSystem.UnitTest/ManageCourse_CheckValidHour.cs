using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transparent_Form;
using NUnit.Framework;

namespace StudentManagementSystem.UnitTest
{
    [TestFixture]
    class ManageCourse_CheckValidHour
    {
        private ManageCourseForm _mngCour;
        [SetUp]
        public void SetUp()
        {
            _mngCour = new ManageCourseForm();
        }

        #region Test Cases
        [TestCase("   ", 0)]
        [TestCase(null, 0)]
        [TestCase("abc", 0)]
        [TestCase("-1", 0)]
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        #endregion

        public void Test_MngCour_ValidHour(string cHour, int expected)
        {
            Assert.AreEqual(expected, _mngCour.CheckValidHour(cHour));
        }
    }
}
