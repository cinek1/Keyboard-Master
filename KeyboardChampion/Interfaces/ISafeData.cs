using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Model; 

namespace KeyboardChampion.Interfaces
{
    interface ISafeData
    {
        void SafeData(List <DataToSerialaize> dataToSerialaize);
        List <DataToSerialaize> GetData();
    }
}
