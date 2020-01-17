using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.Model
{
    public class DataToSerialaize
    {
        public Statistics SesionStatiscs { get; set; }
        public string SpeedWrite { get; set; }
        public string Letters { get; set; }
        public string Files { get; set; }
        public string Time { get; set; }
         public DataToSerialaize() { }
        public DataToSerialaize  (DataToSerializeBuilder dataToSerialize)
        {
            SesionStatiscs = new Statistics()
            {
                Letters = dataToSerialize.SesionStatiscs.Letters,
                Mistakes = dataToSerialize.SesionStatiscs.Mistakes,
                Time = dataToSerialize.SesionStatiscs.Time
            };
            SpeedWrite = dataToSerialize.SpeedWrite;
            Letters = dataToSerialize.Letters;
            Files = dataToSerialize.Files;
            Time = dataToSerialize.Time;
        }

        public override string ToString()
        {
            return "Letters:" + SesionStatiscs.Letters + " Mistakes: " + SesionStatiscs.Mistakes + " Time: " + SesionStatiscs.Time + " Speed Write: " + SpeedWrite + " Letters Or File: " + Letters + Files + "\n";  
        }

    }

    public class DataToSerializeBuilder
    {
        public Statistics SesionStatiscs { get; set; }
        public string SpeedWrite { get; set; }
        public string Letters { get; set; }
        public string Files { get; set; }
        public string Time { get; set; }

        public DataToSerializeBuilder SetStatiscs(Statistics statistics)
        {
            SesionStatiscs = statistics; 
            return this; 
        }
        public DataToSerializeBuilder SetSpeedWrite()
        {
            SpeedWrite = (Double.Parse(SesionStatiscs.Letters) / Double.Parse(SesionStatiscs.Time)).ToString(); 
            return this;
        }
        public DataToSerializeBuilder SetLettersNumber(string letters)
        {
          //  Letters = letters;
            return this; 
        }
        public DataToSerializeBuilder SetPathToFile (string path)
        {
            Files = path;
            return this; 
        }
        public DataToSerialaize ReturnDataFromThis()
        {
            return new DataToSerialaize(this); 
        }
    }
}
