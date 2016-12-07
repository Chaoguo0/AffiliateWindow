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

using AffiliateWindowWPF.Awin;
using System.Collections.ObjectModel;

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

        public ObservableProduct(long id, string name)
        {
            _id = id.ToString();
            _name = name;
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

        public ObservableMerchant(int id, string name)
        {
            _id = id.ToString();
            _name = name;
        }
    }

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ObservableMerchant> _merchants;
        private ObservableCollection<ObservableProduct> _products;

        Awin.ApiPortTypeClient client;
        UserAuthentication userAuthentication;

        public MainWindow()
        {
            InitializeComponent();

            _merchants = new ObservableCollection<ObservableMerchant>();
            _products = new ObservableCollection<ObservableProduct>();

            ProductsDataGrid.ItemsSource = _products;
            MerchantsDataGrid.ItemsSource = _merchants;

            client = new Awin.ApiPortTypeClient();
            userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";
        }

        private void ShowMerchantsClick(object sender, RoutedEventArgs e)
        {
            getMerchant merchant = new getMerchant();

            Merchant[] result = client.getMerchant(userAuthentication, merchant);

            _merchants.Clear();

            foreach (var item in result)
            {
                _merchants.Add(new ObservableMerchant(item.iId, item.sName));
            }

        }

        private void ShowProductsClick(object sender, RoutedEventArgs e)
        {
            getProduct product = new getProduct();

            product.iProductId = new long[1];
            product.iProductId[0] = 1122223;

            Product[] result = client.getProduct(userAuthentication, product);

            _products.Clear();

            foreach (var item in result)
            {
                _products.Add(new ObservableProduct(item.iId, item.sName));
            }

        }
    }
}
