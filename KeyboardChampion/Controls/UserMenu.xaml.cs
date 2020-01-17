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
using KeyboardChampion.Utils;
using KeyboardChampion.Interfaces;
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
            App.AppDataContext.FirstLine = "Press keys to chose letters and next click start"; 
        }
        private void File_Button_Click(object sender, RoutedEventArgs e)
        {
            if (App.AppDataContext.ChoseFile())
            {
                App.State = AppState.ChosseTrybe;
                App.AppDataContext.FirstLine = "Next click start";
            }

        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            LinesFromFile.IsEnabled = false;
            StartButton.IsEnabled = false;
            RandomLines.IsEnabled = false;
            App.AppDataContext.Visible = false; 
            IStrategyToGenerateLines strategy;
            strategy = new GenerateRandomLines();
            switch (App.State)
            {
                case AppState.RandomTrybe:
                    strategy = new GenerateRandomLines();
                    App.AppDataContext.PathToFile = App.AppDataContext.ToGenerateString; 
                    break;
                case AppState.ChosseTrybe:
                    strategy = new GenerateLinesFromFiles();
                    break; 
            }
            if (App.AppDataContext.GenerateLines(strategy)) App.State = AppState.Practice;
            App.AppDataContext.StartTimer(); 

        }
        private void StatButton_Click(object sender, RoutedEventArgs e)
        {
            Statictics stat = new Statictics();
            stat.Show(); 

        }
    }
}
