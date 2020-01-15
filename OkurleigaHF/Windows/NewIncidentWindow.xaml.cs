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
    /// Interaction logic for NewIncidentWindow.xaml
    /// </summary>
    public partial class NewIncidentWindow : Window
    {
        private Incident i;

        public Incident Incident { get; set; }

        public NewIncidentWindow(Incident i)
        {
            InitializeComponent();

            Incident = new Incident();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = Incident;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.DBContext.Incidents.Add(Incident);
            SharedContext.DBContext.SaveChanges();

            this.Close();
        }
    }
}
