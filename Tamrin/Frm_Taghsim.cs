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
    public partial class Frm_Taghsim : Form
    {
        public Frm_Taghsim()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtSoorat.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSoorat, "عددی در صورت وارد نشده است");
                return;
            }
            if (txtMakhraj.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMakhraj, "عددی در مخرج وارد نشده است");
                return;
            }
            int Soorat, Makhraj , Print;
            Soorat = Convert.ToInt32(txtSoorat.Text);
            Makhraj = Convert.ToInt32(txtMakhraj.Text);
            Print = Soorat / Makhraj;
            txtPrint.Text = Print.ToString();

                txtSoorat.Text = txtMakhraj.Text = "";
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("عدد بر صفر تقسیم شده است");
            }
            catch (Exception)
            {

                MessageBox.Show("خطایی در برنامه رخ داده است");
            }
        }

        private void TxtSoorat_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoorat, "");
        }

        private void TxtMakhraj_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMakhraj, "");
        }

        private void TxtSoorat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtMakhraj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
