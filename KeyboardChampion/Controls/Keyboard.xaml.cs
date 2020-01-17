using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using KeyboardChampion.ViewModel; 

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class Keyboard : UserControl
    {
        private KeyShape lastType;
        private KeyShape nextKeyColor;
        public Dictionary<string, object> KeyToBorder;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += Grid_KeyDown;
        }
        public Keyboard()
        {
            InitializeComponent();
            initializeKeyToBorder(); 
        }
        private void initializeKeyToBorder()
        {
            KeyToBorder = new Dictionary<string, object>();
            var a = 3; 
            foreach (var child in Keyboards.Children)
            {
                
                KeyToBorder.Add(child.ToString(), child);
            }
        }
        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.Key.ToString();
            if (e.Key.ToString() == "Space") key = " "; 
                switch (App.State)
                {
                    case AppState.Practice:
                        playTrybe(key);
                        break;
                    case AppState.RandomTrybe:
                        chosseLetters(key);
                        break;
                }
            if (e.Key.ToString() == "Escape")
            {
                reloadWindow(); 
            }
        }

        private void reloadWindow()
        {
            App.AppDataContext.Visible = true;
            App.AppDataContext.clear(); 
            App.State = AppState.ChosseTrybe;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
            MainWindow mw = new MainWindow();
            mw.Top = Application.Current.MainWindow.Top;
            mw.Left = Application.Current.MainWindow.Left;
            var dw = (Application.Current.MainWindow as MainWindow);
            dw.Close();
            Application.Current.MainWindow = mw;
            mw.ShowDialog();
        }

        private void playTrybe(string key)
        {
            if (lastType != null) lastType.KeyboardKey.Background = Brushes.White;
            if (nextKeyColor != null) nextKeyColor.KeyboardKey.Background = Brushes.White;
            KeyToBorder.TryGetValue(key, out object keyToMark);
            lastType = keyToMark as KeyShape;
            if (lastType != null)
            {
                if (App.AppDataContext.isCorrect(key)) lastType.KeyboardKey.Background = Brushes.Blue;
                else lastType.KeyboardKey.Background = Brushes.Red;
            }
            KeyToBorder.TryGetValue(App.AppDataContext.NextLetter, out object nextKey);
            if (nextKey != null)
            {
                nextKeyColor = nextKey as KeyShape;
                nextKeyColor.KeyboardKey.Background = Brushes.LightBlue;
            }

        }
        private void chosseLetters(string key)
        {
            KeyToBorder.TryGetValue(key, out object keyToMark);
            var typeToMark = keyToMark as KeyShape;
            typeToMark.KeyboardKey.Background = Brushes.Orange;
            App.AppDataContext.ToGenerateString += key; 
        }
    }
}
