using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Interfaces;

namespace KeyboardChampion.Utils
{
    public class GenerateRandomLines : IStrategyToGenerateLines
    {
        public GenerateRandomLines()
        {

        }
        Random random = new Random(); 
        public List<string> GenerateLines(string input)
        {
            List<string> listWithLetters = new List<string>();
            listWithLetters.Add(randomString(input));
            listWithLetters.Add(randomString(input));
            listWithLetters.Add(randomString(input));
            return listWithLetters; 
        }

        private  string randomString(string letters)
        {
            string chars = letters;
            return new string(Enumerable.Repeat(chars, 80)
              .Select(s => s[random.Next(s.Length)]).ToArray()).ToUpper();
        }
        private string generateSpace()
        {
            const string chars = " ";
            return new string(Enumerable.Repeat(chars, 160)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
