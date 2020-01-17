using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Interfaces;
using KeyboardChampion.Model;
using Newtonsoft.Json;

namespace KeyboardChampion.Utils
{
    class SerialToFileJSON : ISafeData
    {
        private string path = "seriaflModel.json"; 
        public List<DataToSerialaize> GetData()
        {
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }
            else
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    string line = file.ReadToEnd();
                    var y = JsonConvert.DeserializeObject<List<DataToSerialaize>>(line);
                    return y;
                }
            }
            return null;
        }

        public void SafeData(List<DataToSerialaize> dataToSerialaize)
        {
            string js = JsonConvert.SerializeObject(dataToSerialaize);
            System.IO.File.WriteAllText(path, js);
        }
    }
}
