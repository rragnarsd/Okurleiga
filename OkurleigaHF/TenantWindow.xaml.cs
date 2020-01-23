using OkurleigaHF.EF;
using OkurleigaHF.Models;
using OkurleigaHF.Windows;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace OkurleigaHF
{
    /// <summary>
    /// Interaction logic for TenantWindow.xaml
    /// </summary>
    public partial class TenantWindow : Window
    {
        public ObservableCollection<Tenant> Tenants { get; set; }

        public TenantWindow()
        {
            InitializeComponent();

            Tenants = new ObservableCollection<Tenant>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SharedContext.DBContext.Tenants.Include(x => x.PropertyForRent).Load();

            Tenants = SharedContext.DBContext.Tenants.Local;

            this.DataContext = Tenants;
        }

        private void BtnNewTenant_Click(object sender, RoutedEventArgs e)
        {
            Tenant t = new Tenant();

            NewTenantWindow win = new NewTenantWindow(t);

            win.ShowDialog();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Tenant t = ((sender as Button).DataContext) as Tenant;

            NewTenantWindow win = new NewTenantWindow(t);
            win.ShowDialog();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Tenant t = ((sender as Button).DataContext) as Tenant;

            SharedContext.DBContext.Tenants.Remove(t);
            SharedContext.DBContext.SaveChanges();
        }

    }
}
