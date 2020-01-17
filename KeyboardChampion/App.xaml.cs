using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KeyboardChampion.ViewModel;
using KeyboardChampion.Interfaces;
using KeyboardChampion.Utils;
using KeyboardChampion.Model; 

namespace KeyboardChampion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MyViewModel AppDataContext;
        public static AppState State;
        public static List<DataToSerialaize> DataToSerialaizes; 

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDataContext = MyViewModel.GetMyViewObj;
            App.State = AppState.ChosseTrybe;
            ISafeData safeData = new SerialToFileJSON();
            DataToSerialaizes = safeData.GetData();
            if (DataToSerialaizes == null) DataToSerialaizes = new List<DataToSerialaize>(); 
        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            ISafeData safeData = new SerialToFileJSON();
            safeData.SafeData(DataToSerialaizes); 
        }
    }
}
