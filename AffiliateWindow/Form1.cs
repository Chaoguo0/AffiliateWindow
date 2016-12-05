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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {

            Awin.ApiPortTypeClient client = new Awin.ApiPortTypeClient();

            UserAuthentication userAuthentication = new UserAuthentication();
            userAuthentication.sApiKey = "111";

            getMerchant merchant = new getMerchant();

            merchant.iMerchantId[0] = 2518;
            merchant.iMerchantId[1] = 3030;
            merchant.iMerchantId[2] = 686;
            merchant.iMerchantId[3] = 2518;
            merchant.iMerchantId[4] = 2518;

            merchant.sColumnToReturn[0] = "Product";






            client.getMerchant(userAuthentication, merchant);


        }








    }
}

