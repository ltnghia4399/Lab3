using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class BookSales : Form
    {
        public BookSales()
        {
            InitializeComponent();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtQuality.Text = txtPrice.Text = txtExPrice.Text = txtDis.Text = txtNet.Text = "";

            chkDis.Checked = false;
        }

        private void mnuCal_Click(object sender, EventArgs e)
        {
            try
            {
                clsBookSale bookSales = new clsStudentBookSale(txtTitle.Text,Convert.ToInt32(txtQuality.Text),Convert.ToDecimal(txtPrice.Text), chkDis.Checked, chkDisStudent.Checked);

                //bookSales.Title = txtTitle.Text;
                //bookSales.Quality = Convert.ToInt32(txtQuality.Text);
                //bookSales.Price = Convert.ToDecimal(txtPrice.Text);

                //bookSales.IsDiscount = chkDis.Checked;


                txtPrice.Text = bookSales.Price.ToString("C");
                txtExPrice.Text = bookSales.ExtendedPrice().ToString("C");
                txtDis.Text = bookSales.DiscountAmount().ToString("C");
                txtNet.Text = bookSales.NetDue().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price. " + ex.Message, "Data Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSum_Click(object sender, EventArgs e)
        {
            string result = String.Format("Sale Total: {0}" +
                                        "\nSale Count: {1}",
                                        clsBookSale.SaleTotal.ToString("C"),
                                        clsBookSale.SaleCount.ToString());

            MessageBox.Show(result,"Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
