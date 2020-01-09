using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.Models
{
    public class Property : INotifyPropertyChanged
    {
        public Property()
        {
            IsAvailable = true;
        }


        public int Id { get; set; }

        private string _Address;
        public string Address 
        { 
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
                OnPropertyChanged();
            }
        }


        private string _ZipCode;
        public string ZipCode 
        { 
            get
            {
                return _ZipCode;
            }
            set
            {
                _ZipCode = value;
                OnPropertyChanged();
            }
        }

        private int _Bedrooms;
        public int Bedrooms 
        {   
            get
            {
                return _Bedrooms;
            }
            set
            {
                _Bedrooms = value;
                OnPropertyChanged();
            }
        }

        [NotMapped]
        public string AddressZipCode
        { 
            get
            {
                return $"{Address}, {ZipCode}";
            }
        }

        private int _PropertySize;
        public int PropertySize 
        { 
            get
            {
                return _PropertySize;
            }
            set
            {
                _PropertySize = value;
                OnPropertyChanged();
            }
        }

        private decimal _RentCost;
        public decimal RentCost 
        { 
            get
            {
                return _RentCost;
            }
            set
            {
                _RentCost = value;
                OnPropertyChanged();
            }
        }

        private bool _IsAvailable;
        public bool IsAvailable 
        { 
            get
            {
                return _IsAvailable;
            }
            set
            {
                _IsAvailable = value;
                OnPropertyChanged();
            }
        }

        public string IsAvailableToString
        {
            get
            {
                if (IsAvailable == true)
                {
                    return "Laus";
                }
                else
                {
                    return "Í leigu";
                }
            }
        }

        private DateTime? _DateRented;
        public DateTime? DateRented 
        { 
            get
            {
                return _DateRented;
            }
            set
            {
                _DateRented = DateTime.Now;
                OnPropertyChanged();
            }
        }

        private DateTime? _DateReturned;
        public DateTime? DateReturned 
        { 
            get
            {
                return _DateReturned;
            }
            set
            {
                _DateReturned = DateTime.Now;
                OnPropertyChanged();
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
    }
}
