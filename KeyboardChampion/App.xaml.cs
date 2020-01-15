using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KeyboardChampion.ViewModel; 

namespace KeyboardChampion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MyViewModel AppDataContext;
        public static AppState State; 

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDataContext = new MyViewModel();
            App.State = AppState.ChosseTrybe; 
        }
    }
}
