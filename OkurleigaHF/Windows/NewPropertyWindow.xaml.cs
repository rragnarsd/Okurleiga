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

        public NewPropertyWindow(Property p)
        {
            InitializeComponent();

            Property = new Property();

            this.p = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            this.DataContext = Property;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Property.ZipCode = cbZipCode.SelectedIndex.ToString();
            Property.Bedrooms = cbBedrooms.SelectedIndex;

            SharedContext.DBContext.Properties.Add(Property);
            SharedContext.DBContext.SaveChanges();

            this.Close();
        }
    }
}
