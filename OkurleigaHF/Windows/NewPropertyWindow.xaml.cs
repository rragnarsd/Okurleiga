using OkurleigaHF.Design;
using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
                MessageBoxCustom win = new MessageBoxCustom("Heimilisfang vantar");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(cbZipCode.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Póstnúmer vantar");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtSize.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Stærð á húsnæði í m²?");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(cbBedrooms.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Herbergjafjöldi?");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtRentCost.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Leiguverð");
                win.ShowDialog();
            }
            else
            {
                SentInProperty.ZipCode = (cbZipCode.SelectedItem as ComboBoxItem).Content.ToString();
                SentInProperty.Bedrooms = int.Parse((cbBedrooms.SelectedItem as ComboBoxItem).Content.ToString());

                SentInProperty.Address = CloneOfProperty.Address;
                SentInProperty.PropertySize = CloneOfProperty.PropertySize;
                SentInProperty.RentCost = CloneOfProperty.RentCost;
                SentInProperty.IsAvailable = CloneOfProperty.IsAvailable;
                SentInProperty.DateRented = CloneOfProperty.DateRented;
                SentInProperty.DateReturned = CloneOfProperty.DateReturned;

                if (SentInProperty.Id == 0)
                {
                    SharedContext.DBContext.Properties.Add(SentInProperty);
                }

                SharedContext.DBContext.SaveChanges();

                this.Close();
            }




        }
    }
}
