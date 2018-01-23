using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>(); //With autofac (dependency injection) no need of this line of code: new MainWindow(new ViewModel.MainViewModel(new FriendDataService()));
            MainWindow.Show();
        }
    }
}
