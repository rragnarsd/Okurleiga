using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewIncidentWindow.xaml
    /// </summary>
    public partial class NewIncidentWindow : Window
    {
        public Incident SentInIncident { get; set; }
        public Incident CloneOfIncident { get; set; }

        public ObservableCollection<Incident> Incidents { get; set; }

        public NewIncidentWindow(Incident sentInIncident)
        {
            InitializeComponent();

            SentInIncident = sentInIncident;

            CloneOfIncident = new Incident()
            {
                Title = SentInIncident.Title,
                Property = SentInIncident.Property,
                Description = SentInIncident.Description,
                IsActive = SentInIncident.IsActive,
                IncidentReportedDate = SentInIncident.IncidentReportedDate,
                IncidentClosedDate = SentInIncident.IncidentClosedDate
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = CloneOfIncident;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SentInIncident.Title = CloneOfIncident.Title;
            SentInIncident.Property = CloneOfIncident.Property;
            SentInIncident.Description = CloneOfIncident.Description;
            SentInIncident.IsActive = CloneOfIncident.IsActive;
            SentInIncident.IncidentReportedDate = CloneOfIncident.IncidentReportedDate;
            SentInIncident.IncidentClosedDate = CloneOfIncident.IncidentClosedDate;

            SharedContext.DBContext.Incidents.Add(SentInIncident);
            SharedContext.DBContext.SaveChanges();

            this.Close();
        }
    }
}
