using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.Utils
{
    [TestFixture]

    class TestGenerateLineFromFiles
    {
        
        [TestCase]
        public void TestSearchLetters()
        {
            GenerateLinesFromFiles test = new GenerateLinesFromFiles();

            var resultList = test.GenerateLines("123456789abcdfghijklmnop[]';.,/");

            Assert.AreEqual("ABCDFGHIJKLMNOP", resultList[0]);
        }

        [TestCase]
        public void TestLengtchLetters()
        {
            GenerateLinesFromFiles test = new GenerateLinesFromFiles();

            var resultList = test.GenerateLines("123456789abcdfghijklmnop[]';.,/");

            Assert.AreEqual(15, resultList[0].Length);
        }


        [TestCase]
        public void TestZeroLines()
        {
            GenerateLinesFromFiles test = new GenerateLinesFromFiles();

            var resultList = test.GenerateLines("");

            
            Assert.AreEqual(0, resultList.Count); 

        }

        [TestCase]
        public void TestOneContentLines()
        {
            GenerateLinesFromFiles test = new GenerateLinesFromFiles();

            var resultList = test.GenerateLines("a");

            Assert.AreEqual("A", resultList[0]);

        }
    }
}
