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
    class ManageCourse_CheckEmptyField
    {
        private ManageCourseForm _mngCour;
        [SetUp]
        public void SetUp()
        {
            _mngCour = new ManageCourseForm();
        }

        #region Test Cases
        [TestCase("  ", "  ", false)]
        [TestCase(null, null, false)]
        [TestCase("Python", "  ", false)]
        [TestCase("Python", null, false)]
        [TestCase("", "3", false)]
        [TestCase(null, "3", false)]
        [TestCase("Python", "3", true)]
        #endregion

        public void Test_MngCour_EmptyField(string cName, string cHour, bool expected)
        {
            Assert.AreEqual(expected, _mngCour.CheckEmptyField(cName, cHour));
        }
    }
}
