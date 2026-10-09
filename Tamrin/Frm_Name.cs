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
    public partial class Frm_Name : Form
    {
        public Frm_Name()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtName, "لطفا نام خود را وارد کنید");
            }
            else
            {

            MessageBox.Show(txtName.Text + " " +"خوش آمدی");

            }

            txtName.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString().ToString();

        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.White;
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Azure;

        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Azure;
        }

        private void TxtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;

        }

        private void TxtName_MouseLeave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Azure;

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }
    }
}
