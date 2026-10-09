using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin
{
    public partial class Frm_AdadeGhablBaad : Form
    {
        public Frm_AdadeGhablBaad()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                errorProvider1.SetError(txtNumber, "لطفا فیلد را پر کنید");
                return;
            }
            int number = Convert.ToInt32(txtNumber.Text);
            txtPrint.Text = number - 1 + "," + number + "," + ++number;

            txtNumber.Text = "";
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar persian = new PersianCalendar();

            lblDate.Text = persian.GetYear(DateTime.Now) + "/" +
                           persian.GetMonth(DateTime.Now).ToString().PadLeft(2, '0') + "/" +
                           persian.GetDayOfMonth(DateTime.Now).ToString().PadLeft(2, '0') +
                           " " +
                           DateTime.Now.Hour.ToString() + ":" +
                           DateTime.Now.Minute.ToString().PadLeft(2,'0') + ":" +
                           DateTime.Now.Second.ToString().PadLeft(2,'0');
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
