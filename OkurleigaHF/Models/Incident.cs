using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OkurleigaHF.Models
{
    public class Incident
    {
        public Incident()
        {
            IncidentReportedDate = DateTime.Now;
            IsActive = true;
            Property = new Property();

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public Property Property { get; set; }
        public string Description { get; set; }

        private bool _IsActive;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
                OnPropertyChanged();
            }
        }

        public string IsActiveToString
        {
            get
            {
                if (IsActive == true)
                {
                    return "Virkt";
                }
                else
                {
                    return "Óvirkt";
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed(this, new PropertyChangedEventArgs(name));
        }

        public DateTime IncidentReportedDate { get; set; }
        public DateTime? IncidentClosedDate { get; set; }

        private string _Priority;
        public string Priority
        {
            get
            {
                return _Priority;
            }
            set
            {
                _Priority = value;
                OnPropertyChanged();
            }
        }
    }
}
