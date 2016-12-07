using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using AffiliateWindow.Awin;


namespace AffiliateWindowWPF
{
    public class ObservableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class ObservableProduct : ObservableItem
    {
        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged("ID");
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
    }

    public class ObservableMerchant : ObservableItem
    {
        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged("ID");
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
    }

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ObservableMerchant> _merchants;
        private List<ObservableProduct> _products;

        public MainWindow()
        {
            InitializeComponent();

            _merchants = new List<ObservableMerchant>();
            _products = new List<ObservableProduct>();

            ProductsDataGrid.ItemsSource = _merchants;
            MerchantsDataGrid.ItemsSource = _products;
        }

        private void ShowMerchantsClick(object sender, RoutedEventArgs e)
        {

        }

        private void ShowProductsClick(object sender, RoutedEventArgs e)
        {
            getProduct product = new getProduct();

            product.iProductId = new long[1];
            product.iProductId[0] = 1122223;

            Product[] result = client.getProduct(userAuthentication, product);
            lblProducts.Text = "Products (id, name):\n";

            foreach (var item in result)
            {
                lblProducts.Text += item.iId.ToString() + ", " + item.sName + "\n";
            }

        }
    }
}
