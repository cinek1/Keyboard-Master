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
using System.Windows.Shapes;

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy Statictics.xaml
    /// </summary>
    public partial class Statictics : Window
    {
        public Statictics()
        {
            InitializeComponent();
            lvDataBinding.ItemsSource = App.DataToSerialaizes; 
        }
    }
}
