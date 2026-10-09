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
    public partial class Frm_Week : Form
    {
        public Frm_Week()
        {
            InitializeComponent();
        }

        private string Weeek()
        {
            string s = "شنبه";
            return s;
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                errorProvider1.SetError(txtNumber, "لطفا فیلد را پر کنید");
                return;
            }
            int number = Convert.ToInt32(txtNumber.Text);


           /* if (number == 0) txtPrint.Text = Weeek();

            else if (number == 1) txtPrint.Text = number + Weeek();
            else if (number == 2) txtPrint.Text = number + Weeek();
            else if (number == 3) txtPrint.Text = number + Weeek();
            else if (number == 4) txtPrint.Text = number + Weeek();
            else if (number == 5) txtPrint.Text = number + Weeek();
            else if (number == 6) txtPrint.Text = "جمعه";

            else
            {
                txtPrint.Text = "عدد صحیح نیست";
            }
            */
            switch (number)
            {
                case 0 :
                    txtPrint.Text = Weeek();
                    break;
                case 1:
                    txtPrint.Text = number + Weeek();
                    break;
                case 2:
                    txtPrint.Text = number + Weeek();
                    break;
                case 3:
                    txtPrint.Text = number + Weeek();
                    break;
                case 4:
                    txtPrint.Text = number + Weeek();
                    break;
                case 5:
                    txtPrint.Text = number + Weeek();
                    break;
                case 6:
                    txtPrint.Text = "جمعه";
                    break;
                default:

                    txtPrint.Text = "نامعتبر";
                    break;
            }

            txtNumber.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
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
