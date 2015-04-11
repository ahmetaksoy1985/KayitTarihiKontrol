using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KayıtTarihiKontrolü.Models;
using System.Windows.Data;
using System.Data.Entity;

namespace KayıtTarihiKontrolü
{
    public class MainWindowViewModel
    {
        private CollectionViewSource _üyelikCVS = new CollectionViewSource();
        public CollectionViewSource ÜyelikCVS { get { return _üyelikCVS; } }

        VeritabanıContext _veritabanıcontext = new VeritabanıContext();
        public string ÜyeEkle_TextBoxAd_Text { get; set; }
        public string ÜyeEkle_TextBoxSoyad_Text { get; set; }

        public MainWindowViewModel()
        {
            if(!System.ComponentModel.DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
                ÜyelikVerileriniAl();
        }

        private void ÜyelikVerileriniAl()
        {
            _veritabanıcontext.Üyelik.Load();
            _üyelikCVS.Source = _veritabanıcontext.Üyelik.Local;
        }
        public bool ÜyeEkle()
        {
            try
            {
                _veritabanıcontext.Üyelik.Add(new Üyelik() { Ad = ÜyeEkle_TextBoxAd_Text, Soyad = ÜyeEkle_TextBoxSoyad_Text });
                _veritabanıcontext.SaveChanges();
                ÜyelikCVS.View.Refresh();
                ÜyeEkle_TextBoxAd_Text = "";
                ÜyeEkle_TextBoxSoyad_Text = "";
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ÜyeSil()
        {
            try
            {
                if (ÜyelikCVS.View.CurrentItem is Üyelik)
                    _veritabanıcontext.Üyelik.Remove((Üyelik)ÜyelikCVS.View.CurrentItem);

                _veritabanıcontext.SaveChanges();
                ÜyelikCVS.View.Refresh();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ÜyeDeğiştir()
        {
            try
            {
                _veritabanıcontext.SaveChanges();
                ÜyelikCVS.View.Refresh();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ÜyelikYenile()
        {
            try
            {
                ((Üyelik)(ÜyelikCVS.View.CurrentItem)).ÜyelikYenileme_Tarih = DateTime.Now;
                _veritabanıcontext.SaveChanges();
                ÜyelikCVS.View.Refresh();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
