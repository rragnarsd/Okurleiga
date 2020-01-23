using OkurleigaHF.Design;
using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
                MessageBoxCustom win = new MessageBoxCustom("Titil vantar");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(cbProperty.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Heimilisfang");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(TxtDescription.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Lýsing á atviki");
                win.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(cbPriority.Text))
            {
                MessageBoxCustom win = new MessageBoxCustom("Mikilvægi atviks");
                win.ShowDialog();
            }
            else
            {
                SentInIncident.Property = cbProperty.SelectedItem as Property;
                SentInIncident.Title = CloneOfIncident.Title;
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
