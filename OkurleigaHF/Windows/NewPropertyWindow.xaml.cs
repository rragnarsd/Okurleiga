using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System;
using System.Collections.Generic;
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

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewPropertyWindow.xaml
    /// </summary>
    public partial class NewPropertyWindow : Window
    {
        public Property Property { get; set; }

        public NewPropertyWindow()
        {
            InitializeComponent();

            Property = new Property();
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
            //Console.WriteLine(Property.Address);
            //Console.WriteLine(Property.Bedrooms);
            //Console.WriteLine(Property.ZipCode);
            //Console.WriteLine(Property.PropertySize);
            //Console.WriteLine(Property.RentCost);
            //Console.WriteLine(Property.IsAvailable);
        }
    }
}
