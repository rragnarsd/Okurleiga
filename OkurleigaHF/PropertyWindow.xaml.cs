using OkurleigaHF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using OkurleigaHF.EF;
using System.Data.Entity;

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
    }
}
