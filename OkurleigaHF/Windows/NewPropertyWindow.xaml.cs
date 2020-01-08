using OkurleigaHF.Models;
using System.Windows;

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

        }
    }
}
