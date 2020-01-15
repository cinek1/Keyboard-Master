using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.ViewModel;
using KeyboardChampion.Interfaces; 

namespace KeyboardChampion.ViewModel
{
    public class SetGenerateMode
    {
       private  List<string> _lines; 
        public bool SetStrategyChooseLetters(IStrategyToGenerateLines strategy, string input)
        {
            _lines = strategy.GenerateLines(input);
            if (_lines.Count > 0) return true;
            return false; 
        }
        public  List<string> GetLines()
        {
            return _lines; 
        }
    }
}
