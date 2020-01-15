using System;
using System.Collections.Generic;
using System.Data.Linq;
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
using KeyboardChampion.Model;
using KeyboardChampion.ViewModel;

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Interaction logic for ScreenToText.xaml
    /// </summary>
    public partial class ScreenToText : UserControl
    {
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += Grid_KeyDown;
        }
        private int iter = 0;   
        public ScreenToText()
        {
            InitializeComponent();
            this.DataContext = App.AppDataContext;
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
           // LineOneText.Inlines.Clear();
           // LineOneText.Inlines.Add(new Run(App.AppDataContext.ReturnPartOne()));
          //  LineOneText.Inlines.Add(new Run(App.AppDataContext.ReturnPartTwo()) { Foreground = Brushes.Blue });
        //    LineOneText.Inlines.Add(new Run(App.AppDataContext.ReturnPartThird()));
        }

    }
}
