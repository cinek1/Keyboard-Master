using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.Utils
{
    [TestFixture]
    class TestGenerateRandomLines
    {
        [TestCase]
        public void TestNumberLines()
        {
            var test = new GenerateRandomLines();

            var result = test.GenerateLines("asdfvc");

            Assert.AreEqual(3, result.Count); 
        }

        [TestCase]
        public void TestNumberLettersInLines()
        {
            var test = new GenerateRandomLines();

            var result = test.GenerateLines("asdfvc");

            Assert.AreEqual(80, result[0].Length);
        }

        [TestCase]
        public void TestContainsLetterAnother()
        {
            var test = new GenerateRandomLines();

            var result = test.GenerateLines("QWERTYUIOPLKJHGFDSAZXCVBN");

            Assert.IsFalse(result[0].Contains("M"));
        }

        [TestCase]
        public void TestContainsLetterToUpper()
        {
            var test = new GenerateRandomLines();

            var result = test.GenerateLines("fgh");

            Assert.IsTrue(result[0].Contains("F") && result[0].Contains("G") && result[0].Contains("H"));
        }
    }
}
