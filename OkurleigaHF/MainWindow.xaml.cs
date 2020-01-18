using System.Windows;

namespace OkurleigaHF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnProperties_Click(object sender, RoutedEventArgs e)
        {
            PropertyWindow win = new PropertyWindow();
            win.ShowDialog();
        }

        private void BtnTenants_Click(object sender, RoutedEventArgs e)
        {
            TenantWindow win = new TenantWindow();
            win.ShowDialog();
        }


    }
}
