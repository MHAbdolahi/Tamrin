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
  


    public partial class Frm_Function : Form
    {
        public Frm_Function()
        {
            InitializeComponent();
        }

        private string Spaces()
        {
           string s = "\r\n";
            return s;
        }
        private string Func1(int status)
        {
            string temp = "";
            switch (status)
            {
                case 1:
                    temp = "سلام" + Spaces() + "خوبی";
                    break;

                case 2:
                    temp = "سلام" + Spaces() + "چه خبر";
                    break;
                default:
                    MessageBox.Show("عدد نا معتبر است");
                    temp = "";
                    break;
            }

            return temp;
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {

            if (txtNumber.Text == "")
            {
                errorProvider1.SetError(txtNumber, "فیلد را پر کنید");
                return;
            }
            int number = Convert.ToInt32(txtNumber.Text);

            txtPrint.Text = Func1(number);

            //switch (number)
            //{
            //    case 1:
            //        txtPrint.Text = "سلام" + Spaces() + "خوبی";
            //        break;

            //    case 2 :
            //        txtPrint.Text = "سلام" + Spaces() + "چه خبر";
            //        break;
            //    default:
            //        MessageBox.Show("عدد نا معتبر است");
            //        txtPrint.Text = "";
            //        break;
            //}
            //txtNumber.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
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
