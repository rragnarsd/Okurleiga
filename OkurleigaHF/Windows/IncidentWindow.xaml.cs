﻿using OkurleigaHF.EF;
using OkurleigaHF.Models;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace OkurleigaHF.Windows
{
    /// <summary>
    /// Interaction logic for IncidentWindow.xaml
    /// </summary>
    public partial class IncidentWindow : Window
    {

        public ObservableCollection<Incident> Incidents { get; set; }

        public IncidentWindow(Incident i)
        {
            InitializeComponent();

            Incidents = new ObservableCollection<Incident>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //SharedContext.DBContext.Incidents.Load();
            SharedContext.DBContext.Incidents.Include(x => x.Property).Load();

            Incidents = SharedContext.DBContext.Incidents.Local;

            this.DataContext = Incidents;
        }

        private void btnNewIncident_Click(object sender, RoutedEventArgs e)
        {
            Incident i = new Incident();
            NewIncidentWindow win = new NewIncidentWindow(i);

            win.ShowDialog();
        }

        private void btnEditIncident_Click(object sender, RoutedEventArgs e)
        {
            Incident i = ((sender as Button).DataContext) as Incident;


        }

        private void btnDeleteIncident_Click(object sender, RoutedEventArgs e)
        {
            Incident i = ((sender as Button).DataContext) as Incident;

            SharedContext.DBContext.Incidents.Remove(i);
            SharedContext.DBContext.SaveChanges();
        }
    }
}
