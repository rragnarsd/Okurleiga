using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.Models
{
    public class Tenant : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public Property PropertyForRent { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
