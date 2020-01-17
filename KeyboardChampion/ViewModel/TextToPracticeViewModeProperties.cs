using KeyboardChampion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardChampion.ViewModel
{
    public partial class MyViewModel
    {
        private TextToPractice textToPractice;
        private Statistics statistics;
        private bool _visible;



        private static MyViewModel obj = null;
        // mutex lock used forthread-safety.
        private static readonly object mutex = new object();



        public static MyViewModel GetMyViewObj
        {
            get
            {
                lock (mutex)
                {
                    if (obj == null)
                    {
                        obj = new MyViewModel();
                    }
                    return obj;
                }
            }
        }

        public bool Visible
        {
            get { return _visible; }
            set
            {
                if (_visible != value)
                {
                    _visible = value;
                    OnPropertyChange("Visible");
                }
            }
        }

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

    }
}
