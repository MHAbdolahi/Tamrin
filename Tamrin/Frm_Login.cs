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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            bool d = false;
            if (count == 3)
            {
                MessageBox.Show("کاربر گرامی بعد از یک دقیقه دوباره تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = true;
                return;
            }
            if (txtusername.Text.Trim() == "")
            {
                errorProvider1.SetError(txtusername, "لطفا نام کاربری خود را وارد کنید");
                d = true;
            }
            if (txtpassword.Text.Trim() == "")
            {
                
                errorProvider1.SetError(txtpassword, "لطفا رمز عبور خود را وارد کنید");
                d = true;
            }

            if (d == true)
            {
                return;
            }

            if (radioModir.Checked == true)
            {
                if (txtusername.Text == "مدیر" && txtpassword.Text == "123")
                {
                    Frm_Main frm = new Frm_Main();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("مدیر گرامی نام کاربری یا رمز عبور اشتباه است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    

                }

            }
            
            if (radioUser.Checked == true)
            {
                if (txtusername.Text == "کاربر" && txtpassword.Text == "456")
                {
                    Frm_Main frm = new Frm_Main();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    count += 1;
                    MessageBox.Show("کاربر گرامی نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            // Close(); // فرم جاری بسته می شود 
            // دقت کنید اگر فرم جای فرم شروعو باشد پروژه بسته می شود 
            Application.Exit(); // در هر فرمی که باشد تمام پروژه بسته می شود و از حافظه خارج می شود 
        }

        int x = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            x += 1;
            if (x == 60)
            {
                count = 0;
                x = 0;
                timer1.Enabled = false;
            }
        }

        private void PictureBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
            pictureBoxPassword.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PictureBoxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '*';
            pictureBoxPassword.BorderStyle = BorderStyle.None;
        }
    }
}
