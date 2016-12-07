using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AffiliateWindow.Awin;

namespace AffiliateWindow
{
    public partial class Form1 : Form
    {

        Awin.ApiPortTypeClient client;
        UserAuthentication userAuthentication;

        public Form1()
        {
            InitializeComponent();

            Awin.ApiPortTypeClient client = new Awin.ApiPortTypeClient();
            UserAuthentication userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";

        }
        
        private void btnShowResult_Click(object sender, EventArgs e)
        {
                        getMerchant merchant = new getMerchant();

            // comment out following lines to get all merchants …
            merchant.iMerchantId = new int[5];
            merchant.iMerchantId[0] = 2518;
            merchant.iMerchantId[1] = 368;
            merchant.iMerchantId[2] = 6180;
            merchant.iMerchantId[3] = 732;
            merchant.iMerchantId[4] = 1148;
            // … until here

            Merchant[] result = client.getMerchant(userAuthentication, merchant);
            
            lblMerchants.Text = "Merchants (id, name):\n";

            foreach (var item in result)
            {
                lblMerchants.Text += item.iId.ToString() + ", " + item.sName + "\n";
            }


        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            Awin.ApiPortTypeClient client = new Awin.ApiPortTypeClient();
            UserAuthentication userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";

            getProductList product = new getProductList();

            product.sQuery = "Real Madrid Home";
            product.iLimit = 5;

            lblProductLists.Text = "Products (id, name):\n";

            getProductListResponse result = new getProductListResponse();

            result.oProduct = new Product[100];
                
            result =client.getProductList(userAuthentication, product);

            lblProductLists.Text += "Products in total:" + result.iTotalCount.ToString() + "\n";


            for (int i = 0; i < 10; i++)
            {
                lblProductLists.Text += result.oProduct[i].sName + "\n";

            }
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            Awin.ApiPortTypeClient client = new Awin.ApiPortTypeClient();
            UserAuthentication userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";

            getProduct product = new getProduct();

            product.iProductId = new long[1];

            product.iProductId [0] = 3389364729;

            lblProducts.Text = "Products (id, name):\n";

            Product[] result = client.getProduct(userAuthentication, product);
            
            lblProducts.Text +=   result[0].sName + "\n";

        }
    }
}

