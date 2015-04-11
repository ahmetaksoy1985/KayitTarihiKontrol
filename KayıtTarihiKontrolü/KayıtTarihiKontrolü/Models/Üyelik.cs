using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KayıtTarihiKontrolü.Models
{

    public partial class Üyelik : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public Üyelik()
        {
            Guid = Guid.NewGuid();
            Üyelik_Tarih = DateTime.Now;
            ÜyelikYenileme_Tarih = DateTime.Now;
        }

        public System.Guid Guid { get; set; }
        public System.DateTime Üyelik_Tarih { get; set; }

        private System.DateTime _üyelikYenileme_Tarih;
        public System.DateTime ÜyelikYenileme_Tarih
        {
            get { return _üyelikYenileme_Tarih; }
            set 
            { 
                _üyelikYenileme_Tarih = value;
                NotifyPropertyChanged("ÜyelikYenileme_Tarih");
            }
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
}
