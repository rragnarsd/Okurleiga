using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewTenantWindow.xaml
    /// </summary>
    public partial class NewTenantWindow : Window
    {
        public Tenant SentInTenant { get; set; }
        public Tenant CloneOfTenant { get; set; }

        public ObservableCollection<Tenant> Tenants { get; set; }

        public NewTenantWindow(Tenant sentInTenant)
        {
            InitializeComponent();

            SentInTenant = sentInTenant;

            CloneOfTenant = new Tenant()
            {
                FullName = SentInTenant.FullName,
                Email = SentInTenant.Email,
                Phone = SentInTenant.Phone,
                PropertyForRent = SentInTenant.PropertyForRent
            };
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = CloneOfTenant;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SentInTenant.FullName = CloneOfTenant.FullName;
            SentInTenant.Email = CloneOfTenant.Email;
            SentInTenant.Phone = CloneOfTenant.Phone;
            SentInTenant.PropertyForRent = CloneOfTenant.PropertyForRent;

            SharedContext.DBContext.Tenants.Add(SentInTenant);
            SharedContext.DBContext.SaveChanges();

            this.Close();
        }
    }
}
