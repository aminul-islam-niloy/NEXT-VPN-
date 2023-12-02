using NEXT_VPN.Core;
using NEXT_VPN.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NEXT_VPN.MVVM.ViewModel
{
    internal class MainViewModel: ObservableObject
    {

        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShutdownWindowCommand { get; set; }
        public RelayCommand MaximizedWindowCommand { get; set; }        
        public RelayCommand MinimizeWindowCommand { get; set; } 

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyCanged();
            }
        }

        public  ProtctionViewModel ProtectionVM { get; set; }

        public MainViewModel()
        {
            //for currnt view
            ProtectionVM = new ProtctionViewModel();
            CurrentView = ProtectionVM;

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutdownWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizedWindowCommand = new RelayCommand(o =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                }
            });

            MinimizeWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized;  });

        }
    }
}
