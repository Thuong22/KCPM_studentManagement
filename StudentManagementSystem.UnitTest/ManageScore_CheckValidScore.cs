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
    class ManageScore_CheckValidScore
    {
        private ManageScoreForm _mngScr;
        [SetUp]
        public void SetUp()
        {
            _mngScr = new ManageScoreForm();
        }

        #region Test Cases
        [TestCase("  ",-2)]
        [TestCase("abc",-2)]
        [TestCase(null,null)]
        [TestCase("-1",-1)]
        [TestCase("0",0)]
        [TestCase("101",-1)]
        [TestCase("1",1)]
        [TestCase("59.52",60)]
        [TestCase("75.25",75)]
        [TestCase("100",100)]
        #endregion

        public void Test_MngScr_ValidScore(string tbxScore, Nullable<double> expected)
        {
            Assert.AreEqual(expected, _mngScr.CheckValidScore(tbxScore));
        }
    }
}
