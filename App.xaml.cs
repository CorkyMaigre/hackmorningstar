using hackmorningstar.View;
using hackmorningstar.ViewModel;
using System.Windows;

namespace hackmorningstar
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            }.Show();
        }
    }
}
