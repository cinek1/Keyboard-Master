using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyboardChampion.Model;
using KeyboardChampion.Utils;


namespace KeyboardChampion.ViewModel
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private int countLettersFromKeyboard = 0; 
        public string nextLetter { get; set; }
        public string toGenerateString { set; get; } 
        public SetGenerateMode generateMode { set; get;  }
        private string allText; 
        private TextToPractice textToPractice;
        private Statistics statistics;
        private int mistake; 

        public string FirstLine
        {
            get { return textToPractice.FirstLine; }
            set
            {
                if (textToPractice.FirstLine != value)
                {
                    textToPractice.FirstLine = value;
                    OnPropertyChange("FirstLine");
                }
            }
        }
        public string SecondLine
        {
            get { return textToPractice.SecondLine; }
            set
            {
                if (textToPractice.SecondLine != value)
                {
                    textToPractice.SecondLine = value;
                    OnPropertyChange("SecondLine");

                }
            }
        }
        public string ThirdLine
        {
            get { return textToPractice.ThirdLine; }
            set
            {
                if (textToPractice.ThirdLine != value)
                {
                    textToPractice.ThirdLine = value;
                    OnPropertyChange("ThirdLine");
                }
            }
        }

        public string FirstLineFromKey
        {
            get { return textToPractice.FirstLineFromKey; }
            set
            {
                if (textToPractice.FirstLineFromKey != value)
                {
                    textToPractice.FirstLineFromKey = value;
                    OnPropertyChange("FirstLineFromKey");
                }
            }
        }
        public string SecondLineFromKey
        {
            get { return textToPractice.SecondLineFromKey; }
            set
            {
                if (textToPractice.SecondLineFromKey != value)
                {
                    textToPractice.SecondLineFromKey = value;
                    OnPropertyChange("SecondLineFromKey");

                }
            }
        }
        public string ThirdLineFromKey
        {
            get { return textToPractice.ThirdLineFromKey; }
            set
            {
                if (textToPractice.ThirdLineFromKey != value)
                {

                    textToPractice.ThirdLineFromKey = value;
                    OnPropertyChange("ThirdLineFromKey");
                }
            }
        }
        public string Mistakes
        {
            get { return statistics.Mistakes; }
            set
            {
                if (statistics.Mistakes != value)
                {
                    statistics.Mistakes = value;
                    OnPropertyChange("Mistakes");
                }
            }
        }
        public string Letters
        {
            get { return statistics.Letters; }
            set
            {
                if (statistics.Letters != value)
                {
                    statistics.Letters = value;
                    OnPropertyChange("Letters");
                }
            }
        }
        public string Time
        {
            get { return statistics.Time; }
            set
            {
                if (statistics.Time != value)
                {
                    statistics.Time = value;
                    OnPropertyChange("Time");
                }
            }
        }


        public bool isCorrect(string letter)
        { 

            if (countLettersFromKeyboard < 80)
            {
                StringBuilder buildToLine = new StringBuilder(FirstLineFromKey);
                buildToLine[countLettersFromKeyboard] = char.Parse(letter);
                countLettersFromKeyboard++;
                buildToLine.Remove(buildToLine.Length - 1, 1);
                FirstLineFromKey = buildToLine.ToString();
              
            }
            else if (countLettersFromKeyboard >= 80 && countLettersFromKeyboard < 160)
            {
                StringBuilder buildToLine = new StringBuilder(SecondLineFromKey);
                buildToLine[countLettersFromKeyboard % 80] = char.Parse(letter);
                countLettersFromKeyboard++;
                buildToLine.Remove(buildToLine.Length - 1, 1);
                SecondLineFromKey = buildToLine.ToString();
            }
            else
            {
                StringBuilder buildToLine = new StringBuilder(ThirdLineFromKey);
                buildToLine[countLettersFromKeyboard % 80] = char.Parse(letter);
                countLettersFromKeyboard++;
                buildToLine.Remove(buildToLine.Length - 1, 1);
                ThirdLineFromKey = buildToLine.ToString();
            }
            Letters = countLettersFromKeyboard.ToString(); 
            nextLetter = allText[countLettersFromKeyboard].ToString();
            if (allText[countLettersFromKeyboard - 1].ToString() == letter) return true;
            mistake++;
            Mistakes = mistake.ToString(); 
            return false; 
        }

        //public string ReturnPartOne()
        //{
        //    if (countLettersFromKeyboard < 80)
        //    {
        //        return FirstLine.Substring(0, countLettersFromKeyboard + 1);
        //    }
        //    else if (countLettersFromKeyboard >= 80 && countLettersFromKeyboard < 160)
        //    {
        //        return SecondLine.Substring(0, countLettersFromKeyboard + 1);
        //    }
        //    else
        //    {
        //        return ThirdLine.Substring(0, countLettersFromKeyboard + 1);
        //    }

        //}
        //public string ReturnPartTwo()
        //{
        //    if (countLettersFromKeyboard < 79)
        //    {
        //        return FirstLine[countLettersFromKeyboard + 1].ToString();
        //    }
        
        //    else if (countLettersFromKeyboard >= 79 && countLettersFromKeyboard < 160)
        //    {
        //        return SecondLine[countLettersFromKeyboard % 79 + 1].ToString();
        //    }
        //    else
        //    {
        //        return ThirdLine[countLettersFromKeyboard % 160 + 1].ToString();
        //    }
        //}

        //public string ReturnPartThird()
        //{
        //    if (countLettersFromKeyboard < 79)
        //    {
        //        return FirstLine.Substring(countLettersFromKeyboard + 2, FirstLine.Length - countLettersFromKeyboard - 2);
        //    }

        //    else if (countLettersFromKeyboard >= 79 && countLettersFromKeyboard < 160)
        //    {
        //        return SecondLine.Substring((countLettersFromKeyboard + 2) % 79, FirstLine.Length - (countLettersFromKeyboard + 2) % 79 - 2);
        //    }
        //    else
        //    {
        //        return ThirdLine.Substring(countLettersFromKeyboard + 2, FirstLine.Length - countLettersFromKeyboard - 2);
        //    }
        //}
        private static Random random = new Random();
        private System.Windows.Forms.Timer timer1;
        private int counter = 0;
        private void btnStart_Click_1()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            Time = counter.ToString();
        }

        public void GenerateLines()
        {
            var mode = new SetGenerateMode();
            if (mode.SetStrategyChooseLetters(new GenerateRandomLines(), toGenerateString))
            {
                var lines = mode.GetLines();
                
                    FirstLine = lines[0];
                    SecondLine = lines[1];
                    ThirdLine = lines[2];
                FirstLineFromKey = generateSpace();
                SecondLineFromKey = generateSpace();
                ThirdLineFromKey = generateSpace();
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            Time = counter.ToString();
        }
        private string generateSpace()
        {
            const string chars = " ";
            return new string(Enumerable.Repeat(chars, 160)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public MyViewModel()
        {
            textToPractice = new TextToPractice()
            {

                FirstLineFromKey = generateSpace(),
                SecondLineFromKey = generateSpace(),
                ThirdLineFromKey = generateSpace(),
            };
            statistics = new Statistics()
            {
                Mistakes = 0.ToString(),
                Letters = 0.ToString(),
                Time = 0.ToString()
            };
            allText = FirstLine + SecondLine + ThirdLine;
            Task task = new Task(() => btnStart_Click_1());
            task.RunSynchronously(); 
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
