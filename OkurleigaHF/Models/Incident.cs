using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OkurleigaHF.Models
{
    public class Incident : INotifyPropertyChanged
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

        public bool IsActive { get; set; }

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

        public DateTime IncidentReportedDate { get; set; }
        public DateTime? IncidentClosedDate { get; set; }
        public string Priority { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
    }

