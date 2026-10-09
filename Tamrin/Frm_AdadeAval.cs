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
    public partial class Frm_AdadeAval : Form
    {
        public Frm_AdadeAval()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            int number;
            
            bool f = false;

            if (txtNumber.Text == "")
            {
                errorProvider1.SetError(txtNumber, "پر کردن فیلد الزامی است");
                return;
            }

            number = Convert.ToInt32(txtNumber.Text);
            
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    f = true;
                }
            }
            if (f == true)
            {
                MessageBox.Show("عدد اول نیست", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("عدد اول است", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            txtNumber.Text = "";
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
