using OkurleigaHF.EF;
using OkurleigaHF.Models;
using OkurleigaHF.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace OkurleigaHF
{
    /// <summary>
    /// Interaction logic for TenantWindow.xaml
    /// </summary>
    public partial class TenantWindow : Window
    {
        public ObservableCollection<Tenant> Tenants { get; set; }
        public static WindowStartupLocation OkurleigaHF { get; internal set; }

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

        private void btnNewTenant_Click(object sender, RoutedEventArgs e)
        {
            NewTenantWindow win = new NewTenantWindow();

            win.ShowDialog();
        }
    }
}
