using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikeCart
{
    public partial class NikeCart : Form
    {
        public NikeCart()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(txtBoxProductID.Text) && !String.IsNullOrWhiteSpace(txtBoxPrice.Text) && !String.IsNullOrWhiteSpace(txtBoxSku.Text) && !String.IsNullOrWhiteSpace(txtBoxSize.Text))
            {
                stringBuilder.AppendFormat("https://secure-store.nike.com/ap/services/jcartService?callback=nike_Cart_handleJCartResponse&action=addItem&lang_locale=en_GB&country=SG&catalogId=7&productId={0}&price={1}&siteId=null&passcode=null&sizeType=US&qty=1&skuAndSize={2}%3AM+{3}+%2F+W+12&rt=json&view=3&skuId={2}&displaySize=M+{3}+%2F+W+12&_=1524460950783", txtBoxProductID.Text, txtBoxPrice.Text, txtBoxSku.Text, txtBoxSize.Text);
                txtBoxURL.Text = stringBuilder.ToString();
            }
            else
                MessageBox.Show("Please do not leave any fields empty!", "NikeCart", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
