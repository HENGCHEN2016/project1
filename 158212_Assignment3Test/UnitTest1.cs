using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _158212_Assignment3;

namespace _158212_Assignment3Test
{
    [TestClass]
    public class UnitTest1
    {
        public string countryLeft;
        public string countryRight;

        [TestMethod]
        public void TestTeamFields()
        {
            Form1 frm = new Form1();
            Assert.AreEqual("", frm.countryLeft);
            Assert.AreEqual("", frm.countryRight);
        }

        [TestMethod]
        public void TestTeam1Try()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team1Try();
            int expected = 5;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam2Try()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team2Try();
            int expected = 5;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam1Coversion()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team1Conversion();
            int expected = 2;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam2Coversion()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team2Conversion();
            int expected = 2;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam1Penalty()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team1Penalty();
            int expected = 3;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam2Penalty()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team2Penalty();
            int expected = 3;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam1DropKick()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team1DropKick();
            int expected = 3;
            int actual = form.t1_score;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTeam2DropKick()
        {
            Form2 form = new Form2(countryLeft, countryRight);
            form.Team2DropKick();
            int expected = 3;
            int actual = form.t2_score;
            Assert.AreEqual(expected, actual);
        }   
    }
}
