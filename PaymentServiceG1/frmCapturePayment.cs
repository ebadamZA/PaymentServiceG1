using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentServiceG1
{
    public partial class frmCapturePayment : Form
    {
        public frmCapturePayment()
        {
            InitializeComponent();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.Equals("Cash"))
            {
                pnlCash.Visible = true;
                pnlCard.Visible = false;
            } else
            {
                pnlCash.Visible = false;
                pnlCard.Visible = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(txbOrderID.Text);
            double amount = Convert.ToDouble(txbAmount.Text);
            DateTime date = dtpDate.Value;
            string reference = txbReference.Text;

            if (cmbType.SelectedItem.Equals("Cash"))
            {
                double tendered = Convert.ToDouble(txbTendered.Text);
                double change = Convert.ToDouble(txbChange.Text);
                string currency = txbCurrency.Text;

                CashPayment cp = new CashPayment(orderID, date, amount,
                    reference, tendered, change, currency);
            }
            else
            {
             
            }

        }
    }
}
