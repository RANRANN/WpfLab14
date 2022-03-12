using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfLab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name ="Манго",
                Price =30,
                Foto = "/Data/7.jpg",
                Category =ProductCategory.Eat
            });
            products.Add(new Product()
            {
                Name ="Папайя",
                Price =130,
                Foto = "/Data/8.jpg",
                Category =ProductCategory.Eat
            });
            products.Add(new Product()
            {
                Name ="Питахайя",
                Price =160,
                Foto = "/Data/9.jpg",
                Category =ProductCategory.Eat
            });
            products.Add(new Product()
            {
                Name ="Холодильник",
                Price =40000,
                Foto = "/Data/4.jpg",
                Category =ProductCategory.Appliances
            });
            products.Add(new Product()
            {
                Name ="Духовой шкаф",
                Price =30000,
                Foto = "/Data/5.jpg",
                Category =ProductCategory.Appliances
            });
            products.Add(new Product()
            {
                Name ="Очиститель воздуха",
                Price =60000,
                Foto = "/Data/6.jpg",
                Category =ProductCategory.Appliances
            });
            ListBox.ItemsSource=products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                Name ="Хлеб",
                Price =30,
                Foto = "/Data/1.jpg",
                Category =ProductCategory.Eat
            });

        }
    }
}
