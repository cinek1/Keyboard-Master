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
           window.SizeChanged += UserControl_SizeChanged; 
        }
        private int iter = 0;   
        public ScreenToText()
        {
            InitializeComponent();
            this.DataContext = App.AppDataContext;
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void UserControl_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
        }
    }
}
