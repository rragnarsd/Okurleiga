using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

        public ObservableCollection<Property> Properties { get; set; }

        public NewTenantWindow(Tenant sentInTenant)
        {
            InitializeComponent();

            //cbPropertyAddress.ItemsSource = typeof(Property).GetProperties();

            SentInTenant = sentInTenant;

            CloneOfTenant = new Tenant()
            {
                FullName = SentInTenant.FullName,
                Email = SentInTenant.Email,
                Phone = SentInTenant.Phone,
                PropertyForRent = sentInTenant.PropertyForRent
            };

            Properties = new ObservableCollection<Property>();
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SharedContext.DBContext.Properties.Load();
            Properties = SharedContext.DBContext.Properties.Local;
            cbPropertyAddress.DataContext = Properties;
            this.DataContext = CloneOfTenant;

            cbPropertyAddress.SelectedItem = SentInTenant.PropertyForRent;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("Verður að skrifa nafn");
            }
            else if (string.IsNullOrWhiteSpace(TxtPhoneNumber.Text))
            {
                MessageBox.Show("Verður að skrifa símanúmer");
            }
            else if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("Verður að skrifa netfang");
            }
            else
            {
                SentInTenant.PropertyForRent = cbPropertyAddress.SelectedItem as Property;

                SentInTenant.FullName = CloneOfTenant.FullName;
                SentInTenant.Email = CloneOfTenant.Email;
                SentInTenant.Phone = CloneOfTenant.Phone;
                //SentInTenant.PropertyForRent = CloneOfTenant.PropertyForRent;

                if (SentInTenant.Id == 0)
                {
                    SharedContext.DBContext.Tenants.Add(SentInTenant);
                }

                SharedContext.DBContext.SaveChanges();

                this.Close();
            }

            
        }
    }
}
