using OkurleigaHF.EF;
using OkurleigaHF.Models;
using OkurleigaHF.Windows;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace OkurleigaHF
{
    /// <summary>
    /// Interaction logic for PropertyWindow.xaml
    /// </summary>
    public partial class PropertyWindow : Window
    {
        public ObservableCollection<Property> Properties { get; set; }

        public PropertyWindow()
        {
            InitializeComponent();

            Properties = new ObservableCollection<Property>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SharedContext.DBContext.Properties.Load();

            Properties = SharedContext.DBContext.Properties.Local;

            this.DataContext = Properties;
        }

        private void btnNewProp_Click(object sender, RoutedEventArgs e)
        {
            Property p = new Property();

            NewPropertyWindow win = new NewPropertyWindow(p);

            win.ShowDialog();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Property p = ((sender as Button).DataContext) as Property;

            NewPropertyWindow win = new NewPropertyWindow(p);
            win.ShowDialog();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Property p = ((sender as Button).DataContext) as Property;

            SharedContext.DBContext.Properties.Remove(p);
            SharedContext.DBContext.SaveChanges();
        }
    }
}
