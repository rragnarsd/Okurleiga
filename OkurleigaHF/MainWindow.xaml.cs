using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OkurleigaHF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnProperties_Click(object sender, RoutedEventArgs e)
        {
            PropertyWindow win = new PropertyWindow();
            win.ShowDialog();
        }

        private void btnTenants_Click(object sender, RoutedEventArgs e)
        {
            TenantWindow win = new TenantWindow();
            win.ShowDialog();
        }

        
    }
}
