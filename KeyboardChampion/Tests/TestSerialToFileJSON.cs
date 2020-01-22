using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.Utils
{
    [TestFixture]
    class TestSerialToFileJSON
    {
        [SetUp]
        public void SetupTests()
        {
            if (!System.IO.File.Exists("lll.json"))
            {
                System.IO.File.Delete("lll.json");
            }
        }

        [TestCase]
        public void TestCreateFile()
        {
            var serial = new SerialToFileJSON();

            var result = serial.GetData();

            Assert.AreEqual(null, result); 
        }

        [TestCase]
        public void TestWriteFile()
        {
            var serial = new SerialToFileJSON();

            var result = serial.GetData();

            var elemenstToSafe = new List<Model.DataToSerialaize>();
            var elementToAdd = new Model.DataToSerializeBuilder();
            elementToAdd.SetStatiscs(new Model.Statistics
            {
                Letters = "43",
                Mistakes = "43",
                Time = "123"
            }).SetSpeedWrite()
              .ReturnDataFromThis();
            elemenstToSafe.Add(new Model.DataToSerialaize(elementToAdd));
            serial.SafeData(elemenstToSafe);

            result = serial.GetData(); 
            Assert.AreEqual(1, result.Count());
        }

        [TestCase]
        public void TestWriteFileTwo()
        {
            var serial = new SerialToFileJSON();

            var result = serial.GetData();

            var elemenstToSafe = new List<Model.DataToSerialaize>();
            var elementToAdd = new Model.DataToSerializeBuilder();
            elementToAdd.SetStatiscs(new Model.Statistics
            {
                Letters = "43",
                Mistakes = "43",
                Time = "123"
            }).SetSpeedWrite()
              .ReturnDataFromThis();
            elemenstToSafe.Add(new Model.DataToSerialaize(elementToAdd));
            serial.SafeData(elemenstToSafe);

            result = serial.GetData();
            Assert.AreEqual(elementToAdd.ToString(), result[0].ToString());
        }
    }
}
