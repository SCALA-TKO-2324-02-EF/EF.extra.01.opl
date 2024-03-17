using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF.extra._01.opl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public KopOfMunt kopOfMunt = new KopOfMunt();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnWerp_Click(object sender, RoutedEventArgs e)
        {
            string worp = kopOfMunt.Werp();
            LstResultaat.Items.Add(worp);

            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri($"/Assets/{worp}.png", UriKind.Relative);
            bmp.DecodePixelWidth = 200;
            bmp.EndInit();

            ImgMuntstuk.Source = bmp;
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}