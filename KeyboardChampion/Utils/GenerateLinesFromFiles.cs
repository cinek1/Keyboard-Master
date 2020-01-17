using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Interfaces; 

namespace KeyboardChampion.Utils
{
    class GenerateLinesFromFiles : IStrategyToGenerateLines
    {
        public List<string> GenerateLines(string input)
        {
            List<string> lines = new List<string>(); 
            input = removeAnotherChar(input);
            input = input.ToUpper(); 
            for (int i = 0; i < 240; i += 80)
            {
                if (i + 80 > input.Length) lines.Add(input.Substring(i, input.Length - i));
                lines.Add(input.Substring(i, 80)); 
            }
            return lines; 
        }

        private string removeAnotherChar(string input)
        {
            return new string((from c in input
                               where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                               select c
        ).ToArray());
        }
    }
}
