using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }

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


    }
}
