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
    public partial class Frm_WorkString : Form
    {
        public Frm_WorkString()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (txtPhrase.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPhrase, "فیلد را پر کنید");
            }
            len = txtPhrase.Text.Length;
            timer1.Enabled = true;
            
        }

        int a = 0;
        int len = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (a <= len)
            {
                txtPrint.Text = txtPhrase.Text.Substring(0, a);
                a++;
                
            }
            
        }

        private void TxtPhrase_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPhrase, "");
            
        }

    }
}
