using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class Keyboard : UserControl
    {
        private KeyShape lastType; 
        public Dictionary<string, object> KeyToBorder;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += Grid_KeyDown;
        }


        public Keyboard()
        {
            InitializeComponent();
            KeyToBorder = new Dictionary<string, object>();
            foreach (var child in Keyboards.Children)
            {
                KeyToBorder.Add(child.ToString(), child); 
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (lastType != null) lastType.KeyboardKey.Background = Brushes.White; 
            KeyToBorder.TryGetValue(e.Key.ToString(), out object keyToMark);
            lastType = keyToMark as KeyShape; 
            if (lastType != null) lastType.KeyboardKey.Background = Brushes.Red;
           
        }
    }
}
