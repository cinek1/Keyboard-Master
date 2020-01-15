using System.Collections.Generic;
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
            foreach (var child in Keyboards.Children)
            {
                KeyToBorder.Add(child.ToString(), child);
            }
        }
        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
                switch (App.State)
                {

                    case AppState.Practice:
                        playTrybe(e.Key.ToString());
                        break;
                    case AppState.RandomTrybe:
                        chosseLetters(e.Key.ToString());
                        break;
                }
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
            KeyToBorder.TryGetValue(App.AppDataContext.nextLetter, out object nextKey);
            nextKeyColor = nextKey as KeyShape;
            nextKeyColor.KeyboardKey.Background = Brushes.LightBlue;
        }
        private void chosseLetters(string key)
        {
            KeyToBorder.TryGetValue(key, out object keyToMark);
            var typeToMark = keyToMark as KeyShape;
            typeToMark.KeyboardKey.Background = Brushes.Orange;
            App.AppDataContext.toGenerateString += key; 
        }
    }
}
