using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin
{
    public partial class Frm_ZojFard : Form
    {
        public Frm_ZojFard()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            if (txtNumber.Text == "")
            {
                errorProvider1.SetError(txtNumber, "فیلد را پر کنید");
                return;
            }

            int number = Convert.ToInt32(txtNumber.Text);

            if (number == 0)
            {
                txtPrint.Text = "عدد صفر است";
            }

            else if (number % 2 == 0)
            {
                txtPrint.Text = "زوج است";
            }
            
            else
            {
                txtPrint.Text = "فرد است";
            }

            txtNumber.Text = "";
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNumber, "");
        }
    }
}
