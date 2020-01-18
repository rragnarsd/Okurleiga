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
                IncidentClosedDate = SentInIncident.IncidentClosedDate,
                Priority = SentInIncident.Priority
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = CloneOfIncident;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Verður að skrifa titill");
            }
            //else if (string.IsNullOrWhiteSpace(cbProperty.Text))
            //{
            //    MessageBox.Show("Verður að velja húsnæði");
            //}
            else if (string.IsNullOrWhiteSpace(TxtDescription.Text))
            {
                MessageBox.Show("Það vantar lýsingu á atvikinu");
            }
            else if (string.IsNullOrWhiteSpace(cbPriority.Text))
            {
                MessageBox.Show("Hversu mikilvægt er atvikið?");
            }
            else
            {
                SentInIncident.Title = CloneOfIncident.Title;
                SentInIncident.Property = CloneOfIncident.Property;
                SentInIncident.Description = CloneOfIncident.Description;
                SentInIncident.IsActive = CloneOfIncident.IsActive;
                SentInIncident.IncidentReportedDate = CloneOfIncident.IncidentReportedDate;
                SentInIncident.IncidentClosedDate = CloneOfIncident.IncidentClosedDate;
                SentInIncident.Priority = CloneOfIncident.Priority;

                SharedContext.DBContext.Incidents.Add(SentInIncident);
                SharedContext.DBContext.SaveChanges();

                this.Close();
            }



        }
    }
}
