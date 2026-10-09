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
    public partial class Frm_SubString : Form
    {
        public Frm_SubString()
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
                
                if (txtDirectory.Text == "")
                {
                    errorProvider1.SetError(txtDirectory, "فیلد را پر کنید");
                    return;
                }

                string s = txtDirectory.Text;


                if (s.Length <3)
                {
                    MessageBox.Show("مسیر وارد شده نادرست است");
                    return;
                }

                string[] Cut = s.Split('\\');

                txtDrive.Text = Cut[0];

                int lastBackslash = s.LastIndexOf("\\");
                txtOneFolder.Text = s.Substring(lastBackslash + 1);
               
                txtOneBackslash.Text = s.IndexOf("\\").ToString();

                txtTwoBackslash.Text = s.LastIndexOf("\\").ToString();

                txtNameFolder.Text = Cut[1];

            
            }
            catch (Exception)
            {

                txtDrive.Text = "";
                txtNameFolder.Text = "";
                txtOneBackslash.Text = "";
                txtOneFolder.Text = "";
                txtTwoBackslash.Text = "";

                MessageBox.Show("خطایی در برنامه رخ داده است");
            }
        }
    }
}
