using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeyboardChampion.ViewModel; 

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy UserMenu.xaml
    /// </summary>
    public partial class UserMenu : UserControl
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void RandomLines_Click(object sender, RoutedEventArgs e)
        {
            App.State = AppState.RandomTrybe; 

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            App.State = AppState.Practice;
            App.AppDataContext.GenerateLines(); 
        }
    }
}
