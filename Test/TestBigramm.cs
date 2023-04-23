using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using ProjCharGenerator;
namespace Test
{
    [TestClass]
    public class TestBigramm
    {
        [TestMethod]
        public void TestBigrammChar1()
        {
            BigrammChar bigramm = new BigrammChar();

            int countTrue = 100;
            string ans = bigramm.GetText(countTrue);
            int countAns = ans.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();

            Assert.AreEqual(countTrue, countAns);
        }

        [TestMethod]
        public void TestBigrammWord1()
        {
            BigrammWord bigramm = new BigrammWord();

            int countTrue = 100;
            string ans = bigramm.GetText(countTrue);
            int countAns = ans.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();

            Assert.AreEqual(countTrue, countAns);
        }

        [TestMethod]
        public void TestBigrammPairWord1()
        {
            BigrammPairWord bigramm = new BigrammPairWord();

            int countTrue = 100;
            string ans = bigramm.GetText(countTrue);
            int countAns = ans.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();

            Assert.AreEqual(countTrue, countAns / 2);
        }

        [TestMethod]
        public void TestBigrammChar2()
        {
            Random rd1 = new Random(2);
            Random rd2 = new Random(2);

            BigrammChar bigramm1 = new BigrammChar(rd1);
            BigrammChar bigramm2 = new BigrammChar(rd2);

            int countTrue = 100;
            string ans1 = bigramm1.GetText(countTrue);
            string ans2 = bigramm2.GetText(countTrue);
        }

        [TestMethod]
        public void TestBigrammWord2()
        {
            Random rd1 = new Random(2);
            Random rd2 = new Random(2);

            BigrammWord bigramm1 = new BigrammWord(rd1);
            BigrammWord bigramm2 = new BigrammWord(rd2);

            int countTrue = 100;
            string ans1 = bigramm1.GetText(countTrue);
            string ans2 = bigramm2.GetText(countTrue);

            Assert.AreEqual(ans1, ans2);
        }

        [TestMethod]
        public void TestBigrammPairWord2()
        {
            Random rd1 = new Random(2);
            Random rd2 = new Random(2);

            BigrammPairWord bigramm1 = new BigrammPairWord(rd1);
            BigrammPairWord bigramm2 = new BigrammPairWord(rd2);

            int countTrue = 100;
            string ans1 = bigramm1.GetText(countTrue);
            string ans2 = bigramm2.GetText(countTrue);

            Assert.AreEqual(ans1, ans2);
        }
    }
}