using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.Models
{
    public class Property : INotifyPropertyChanged
    {
        //public Property()
        //{
        //    IsAvailable = true;
        //}


        public int Id { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int Bedrooms { get; set; }

        [NotMapped]
        public string AddressZipCode
        { 
            get
            {
                return $"{Address}, {ZipCode}";
            }
        }


        public int PropertySize { get; set; }
        public decimal RentCost { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
