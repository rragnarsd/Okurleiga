using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for NewIncidentWindow.xaml
    /// </summary>
    public partial class NewIncidentWindow : Window
    {
        public Incident SentInIncident { get; set; }
        public Incident CloneOfIncident { get; set; }

        public ObservableCollection<Property> Properties { get; set; }

        public NewIncidentWindow(Incident sentInIncident)
        {
            InitializeComponent();

            SentInIncident = sentInIncident;

            CloneOfIncident = new Incident()
            {
                Title = SentInIncident.Title,
                Property = sentInIncident.Property,
                Description = SentInIncident.Description,
                IsActive = SentInIncident.IsActive,
                IncidentReportedDate = SentInIncident.IncidentReportedDate,
                IncidentClosedDate = SentInIncident.IncidentClosedDate,
                Priority = SentInIncident.Priority
            };

            Properties = new ObservableCollection<Property>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SharedContext.DBContext.Properties.Load();
            Properties = SharedContext.DBContext.Properties.Local;
            cbProperty.DataContext = Properties;
            this.DataContext = CloneOfIncident;

            cbProperty.SelectedItem = SentInIncident.Property;
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
            else if (string.IsNullOrWhiteSpace(cbProperty.Text))
            {
                MessageBox.Show("Verður að velja húsnæði");
            }
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
                SentInIncident.Property = cbProperty.SelectedItem as Property;

                SentInIncident.Title = CloneOfIncident.Title;
                //SentInIncident.Property = CloneOfIncident.Property;
                SentInIncident.Description = CloneOfIncident.Description;
                SentInIncident.IsActive = CloneOfIncident.IsActive;
                SentInIncident.IncidentReportedDate = CloneOfIncident.IncidentReportedDate;
                SentInIncident.IncidentClosedDate = CloneOfIncident.IncidentClosedDate;
                SentInIncident.Priority = CloneOfIncident.Priority;

                if (SentInIncident.Id == 0)
                {
                    SharedContext.DBContext.Incidents.Add(SentInIncident);
                }

                SharedContext.DBContext.SaveChanges();

                this.Close();
            }



        }
    }
}
