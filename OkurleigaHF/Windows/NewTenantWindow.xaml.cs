using OkurleigaHF.Design;
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
                MessageBoxCustom win = new MessageBoxCustom("Nafn vantar");
                win.ShowDialog();

            }
            else if (string.IsNullOrWhiteSpace(TxtPhoneNumber.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Símanúmer vantar");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Netfang vantar");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(cbPropertyAddress.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Leiguhúsnæði vantar");
                win.ShowDialog();
            }
            else
            {
                SentInTenant.PropertyForRent = cbPropertyAddress.SelectedItem as Property;
                SentInTenant.FullName = CloneOfTenant.FullName;
                SentInTenant.Email = CloneOfTenant.Email;
                SentInTenant.Phone = CloneOfTenant.Phone;

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
