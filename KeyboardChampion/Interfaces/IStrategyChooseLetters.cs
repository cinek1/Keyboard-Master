using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.Interfaces
{
    public interface IStrategyToGenerateLines
    {
         List<string> GenerateLines(string input); 
    }
}
