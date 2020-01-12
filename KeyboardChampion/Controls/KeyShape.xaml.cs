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

namespace KeyboardChampion.Controls
{
    /// <summary>
    /// Interaction logic for KeyShape.xaml
    /// </summary>
    public partial class KeyShape : UserControl
    {
        public KeyShape()
        {
            InitializeComponent();
            this.DataContext = this; 
        }
        public string Letter { get; set; }

        public override string ToString()
        {
            return Letter;
        }
    }

  
     
    
}
