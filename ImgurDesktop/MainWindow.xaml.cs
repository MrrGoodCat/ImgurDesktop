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

namespace ImgurDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Poster> Films;
        public MainWindow()
        {
            InitializeComponent();
            Films = new List<Poster>();
            addFilms();
            Loaded += MainWindow_Loaded;
        }

        void addFilms()
        {
            Poster batman = new Poster("Batman", @"D:\Git Projects\ImgurDesktop\ImgurDesktop\ImgurDesktop\Files\mpeoHIiTODJXiCWtDuSHTnw.jpg");
            Films.Add(batman);

            Poster batman1 = new Poster("Batman1", @"D:\Git Projects\ImgurDesktop\ImgurDesktop\ImgurDesktop\Files\mpeoHIiTODJXiCWtDuSHTnw.jpg");
            Films.Add(batman1);

            Poster batman2 = new Poster("Batman2", @"D:\Git Projects\ImgurDesktop\ImgurDesktop\ImgurDesktop\Files\mpeoHIiTODJXiCWtDuSHTnw.jpg");
            Films.Add(batman2);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ContentListBox.ItemsSource = Films;
        }
    }
}
