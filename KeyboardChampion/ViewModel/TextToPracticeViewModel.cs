using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Model;
using KeyboardChampion.Interfaces;

using System.IO;
using Microsoft.Win32;
using System.Threading;

namespace KeyboardChampion.ViewModel
{
    public partial class MyViewModel : INotifyPropertyChanged
    {

        public string NextLetter { get; set; }
        public string PathToFile { get; set; }
        public string ToGenerateString { set; get; } 
        public SetGenerateMode GenerateMode { set; get;  }

        private int countLettersFromKeyboard = 0;
        private string allText;
        private Task task;
        private int mistake;
        private static Random random = new Random();
        private System.Windows.Forms.Timer timer1;
        private int counter = 0;


        public void clear()
        {
            safeData();
            NextLetter = "";
            ToGenerateString = "";
            allText = "";
            Mistakes = "0";
            Letters = "0";
            Time = "0"; 
            FirstLine = "";
            SecondLine = "";
            ThirdLine = "";
            PathToFile = ""; 
            counter = 0;
            countLettersFromKeyboard = 0;
            mistake = 0;
            FirstLineFromKey = generateSpace();
            SecondLineFromKey = generateSpace();
            ThirdLineFromKey = generateSpace();
            timer1.Interval = 100000000; 
        }


        public bool isCorrect(string letter)
        { 

            if (countLettersFromKeyboard < 80)
            {
                StringBuilder buildToLine = new StringBuilder(FirstLineFromKey);
                buildToLine[countLettersFromKeyboard] = char.Parse(letter);
                countLettersFromKeyboard++;
              //   buildToLine.Remove(buildToLine.Length - 1, 1);
                FirstLineFromKey = buildToLine.ToString();
              
            }
            else if (countLettersFromKeyboard >= 80 && countLettersFromKeyboard < 160)
            {
                StringBuilder buildToLine = new StringBuilder(SecondLineFromKey);
                buildToLine[countLettersFromKeyboard % 80] = char.Parse(letter);
                countLettersFromKeyboard++;
              //  buildToLine.Remove(buildToLine.Length - 1, 1);
                SecondLineFromKey = buildToLine.ToString();
            }
            else
            {
                StringBuilder buildToLine = new StringBuilder(ThirdLineFromKey);
                buildToLine[countLettersFromKeyboard % 80] = char.Parse(letter);
                countLettersFromKeyboard++;
              //  buildToLine.Remove(buildToLine.Length - 1, 1);
                ThirdLineFromKey = buildToLine.ToString();
            }
            Letters = countLettersFromKeyboard.ToString();
            try
            {
                NextLetter = allText[countLettersFromKeyboard].ToString();
                if (allText[countLettersFromKeyboard - 1].ToString() == letter) return true;
                mistake++;
                Mistakes = mistake.ToString();
                return false;
            }
            catch (System.IndexOutOfRangeException)
            {
                clear(); 
                App.State = AppState.ChosseTrybe; 
                return false;
            }

        }

        private void safeData()
        {
            var stat = statistics; 
            DataToSerializeBuilder dataToSerialize = new DataToSerializeBuilder();
            var dataToAdd = dataToSerialize.SetLettersNumber(ToGenerateString)
                           .SetStatiscs(statistics)
                           .SetSpeedWrite()
                           .SetPathToFile("")
                           .ReturnDataFromThis();
            App.DataToSerialaizes.Add(dataToAdd);
            
            
        }

        private void btnStart_Click_1()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            Time = counter.ToString();
        }

        public bool GenerateLines(IStrategyToGenerateLines strategy)
        {
            var lines = strategy.GenerateLines(ToGenerateString);
            if (lines.Count == 0) return false;
            getLine(lines);
            return true; 
        }
        private void getLine(List<string> lines)
        {
            FirstLine = lines[0];
            if (lines.Count > 1 ) SecondLine = lines[1];
            if (lines.Count > 2) ThirdLine = lines[2];

            ;
            allText = FirstLine + SecondLine + ThirdLine;
        }

        public void StartTimer()
        {
            task = new Task(() => {
                 btnStart_Click_1();
               
            });
            task.RunSynchronously();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            Time = counter.ToString();
        }

        public bool ChoseFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                PathToFile = openFileDialog.FileName; 
                ToGenerateString = File.ReadAllText(openFileDialog.FileName);
                return true;
            }
            return false;
        }

        private string generateSpace()
        {
            const string chars = " ";
            return new string(Enumerable.Repeat(chars, 80)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private MyViewModel()
        {
            textToPractice = new TextToPractice()
            {
                FirstLine = generateSpace(),
                SecondLine = generateSpace(),
                ThirdLine = generateSpace(),
                FirstLineFromKey = generateSpace(),
                SecondLineFromKey = generateSpace(),
                ThirdLineFromKey = generateSpace()
            };
            statistics = new Statistics()
            {
                Mistakes = 0.ToString(),
                Letters = 0.ToString(),
                Time = 0.ToString()
            };
            Visible = true;
            ToGenerateString = " "; 
            allText = FirstLine + SecondLine + ThirdLine;
          

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
