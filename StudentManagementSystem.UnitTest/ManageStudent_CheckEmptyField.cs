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
    public class ManageStudent_CheckEmptyField
    {
        private ManageStudentForm _mngStd;
        [SetUp]
        public void SetUp()
        {
            _mngStd = new ManageStudentForm();
        }

        #region Test Cases
        [TestCase("  ", "Ellen", "0123456789", "Washington DC", false)]
        [TestCase(null, "Ellen", "0123456789", "Washington DC", false)]
        [TestCase("Adrian", "  ", "0123456789", "Washington DC", false)]
        [TestCase("Adrian", null, "0123456789", "Washington DC", false)]
        [TestCase("Adrian", "Ellen", "  ", "Washington DC", false)]
        [TestCase("Adrian", "Ellen", null, "Washington DC", false)]
        [TestCase("Adrian", "Ellen", "0123456789", "  ", false)]
        [TestCase("Adrian", "Ellen", "0123456789", null, false)]
        [TestCase("Adrian", "Ellen", "0123456789", "Washington DC", true)]
        #endregion

        public void Test_MngStd_EmptyField(string lname, string fname, string phone, string address, bool expected)
        {
            Assert.AreEqual(expected, _mngStd.CheckEmptyField(lname, fname, phone, address));
        }
    }
}
