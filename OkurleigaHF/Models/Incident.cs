using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
                if(IsActive == true)
                {
                    return "Active";
                }
                else
                {
                    return "Inactive";
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

        public enum Priority
        {
            Low,
            Medium,
            High
        }
    }
}
