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
    class ManageStudent_CheckBirthday
    {
        private ManageStudentForm _mngStd;
        [SetUp]
        public void SetUp()
        {
            _mngStd = new ManageStudentForm();
        }

        #region Test Cases
        [TestCase("01/01/2014", false)]
        [TestCase("01/01/2013", false)]
        [TestCase("12/31/2012", true)]
        [TestCase("11/01/2012", true)]
        [TestCase("10/11/2012", true)]
        [TestCase("01/01/2011", true)]
        #endregion

        public void Test_MngStd_Birthday(DateTime birthday, bool expected)
        {
            Assert.AreEqual(expected, _mngStd.CheckBirthday(birthday));
        }
    }
}
