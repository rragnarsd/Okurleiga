using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewPropertyWindow.xaml
    /// </summary>
    public partial class NewPropertyWindow : Window
    {
        public Property SentInProperty { get; set; }
        public Property CloneOfProperty { get; set; }

        public ObservableCollection<Property> Properties { get; set; }

        public NewPropertyWindow(Property sentInProperty)
        {
            InitializeComponent();

            SentInProperty = sentInProperty;

            CloneOfProperty = new Property
            {
                Address = SentInProperty.Address,
                ZipCode = SentInProperty.ZipCode,
                Bedrooms = SentInProperty.Bedrooms,
                PropertySize = SentInProperty.PropertySize,
                RentCost = SentInProperty.RentCost,
                IsAvailable = SentInProperty.IsAvailable,
                DateRented = SentInProperty.DateRented,
                DateReturned = SentInProperty.DateReturned
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            this.DataContext = CloneOfProperty;


            for (int i = 0; i < cbZipCode.Items.Count; i++)
            {
                string zipFromComboBox = (cbZipCode.Items[i] as ComboBoxItem).Content.ToString();

                if (zipFromComboBox == SentInProperty.ZipCode)
                {
                    cbZipCode.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cbBedrooms.Items.Count; i++)
            {
                string fromComboBox = (cbBedrooms.Items[i] as ComboBoxItem).Content.ToString();

                if (fromComboBox == SentInProperty.Bedrooms.ToString())
                {
                    cbBedrooms.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAddress.Text))
            {
                MessageBox.Show("Verður að skrifa heimilisfang");
            }
            else if (string.IsNullOrWhiteSpace(cbZipCode.Text))
            {
                MessageBox.Show("Verður að velja póstnúmer");
            }
            else if (string.IsNullOrWhiteSpace(TxtSize.Text))
            {
                MessageBox.Show("Stærð á húsnæðinu?");
            }
            else if (string.IsNullOrWhiteSpace(cbBedrooms.Text))
            {
                MessageBox.Show("Verður að velja svefnherbergi");
            }
            else if (string.IsNullOrWhiteSpace(TxtRentCost.Text))
            {
                MessageBox.Show("Til að halda áfram verður mánaðarleg greiðsla að koma fram!");
            }
            else
            {
                //SentInProperty.ZipCode = cbZipCode.SelectedIndex.ToString();
                //SentInProperty.Bedrooms = cbBedrooms.SelectedIndex;

                SentInProperty.Address = CloneOfProperty.Address;
                SentInProperty.ZipCode = CloneOfProperty.ZipCode;
                SentInProperty.Bedrooms = CloneOfProperty.Bedrooms;
                SentInProperty.PropertySize = CloneOfProperty.PropertySize;
                SentInProperty.RentCost = CloneOfProperty.RentCost;
                SentInProperty.IsAvailable = CloneOfProperty.IsAvailable;
                SentInProperty.DateRented = CloneOfProperty.DateRented;
                SentInProperty.DateReturned = CloneOfProperty.DateReturned;

                SharedContext.DBContext.Properties.Add(SentInProperty);
                SharedContext.DBContext.SaveChanges();

                this.Close();
            }




        }
    }
}
