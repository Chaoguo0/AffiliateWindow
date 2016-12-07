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

            client = new Awin.ApiPortTypeClient();
            userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";
        }





        private void btnShowResult_Click(object sender, EventArgs e)
        {
            /*
            Awin.ApiPortTypeClient client = new Awin.ApiPortTypeClient();
            UserAuthentication userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "b9e01904105aac94b7ded008abcef422";
            */
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

