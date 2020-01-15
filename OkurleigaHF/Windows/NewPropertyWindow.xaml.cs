using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System;
using System.Windows;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewPropertyWindow.xaml
    /// </summary>
    public partial class NewPropertyWindow : Window
    {
        private Property p;

        public Property Property { get; set; }
        public Property CloneOfProperty { get; set; }

        public NewPropertyWindow(Property p)
        {
            InitializeComponent();

            CloneOfProperty = new Property()
            {
                Address = p.Address,
                ZipCode = p.ZipCode,
                Bedrooms = p.Bedrooms,
                PropertySize = p.PropertySize,
                RentCost = p.RentCost,
                IsAvailable = p.IsAvailable,
                DateRented = p.DateRented,
                DateReturned = p.DateReturned

            };

            Property = new Property();

            this.p = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < cbZipCode.Items.Count; i++)
            {
                string zipFromComboBox = cbZipCode.Items[i].ToString();
                
                if(zipFromComboBox == p.ZipCode)
                {
                    cbZipCode.SelectedIndex = i;
                    break;
                }
            }

            this.DataContext = CloneOfProperty;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            p.ZipCode = cbZipCode.SelectedIndex.ToString();
            p.Bedrooms = cbBedrooms.SelectedIndex;

            p.Address = CloneOfProperty.Address;
            p.ZipCode = CloneOfProperty.ZipCode;
            p.Bedrooms = CloneOfProperty.Bedrooms;
            p.PropertySize = CloneOfProperty.PropertySize;
            p.RentCost = CloneOfProperty.RentCost;
            p.IsAvailable = CloneOfProperty.IsAvailable;
            p.DateRented = CloneOfProperty.DateRented;
            p.DateReturned = CloneOfProperty.DateReturned;

            SharedContext.DBContext.Properties.Add(Property);
            SharedContext.DBContext.SaveChanges();

            this.Close();
        }
    }
}
