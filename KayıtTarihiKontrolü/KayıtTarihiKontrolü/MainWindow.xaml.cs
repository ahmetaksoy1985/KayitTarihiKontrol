using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KayıtTarihiKontrolü
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ÜyelikYenile_Click(object sender, RoutedEventArgs e)
        {
            if (((MainWindowViewModel)(this.DataContext)).ÜyelikYenile())
                MessageBox.Show("Üyelik Yenilendi.");
            else
                MessageBox.Show("Hata");
        }

        private void Button_Ekle_Click(object sender, RoutedEventArgs e)
        {
            if (((MainWindowViewModel)(this.DataContext)).ÜyeEkle())
                MessageBox.Show("Üye Eklendi.");
            else
                MessageBox.Show("Hata");
        }

        private void Button_Değiştir_Click(object sender, RoutedEventArgs e)
        {
            if (((MainWindowViewModel)(this.DataContext)).ÜyeDeğiştir())
                MessageBox.Show("Üye Bilgileri Değiştirildi.");
            else
                MessageBox.Show("Hata");
        }

        private void Button_Sil_Click(object sender, RoutedEventArgs e)
        {
            if (((MainWindowViewModel)(this.DataContext)).ÜyeSil())
                MessageBox.Show("Üye Silindi.");
            else
                MessageBox.Show("Hata");
        }

    }
}
