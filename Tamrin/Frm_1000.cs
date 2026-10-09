using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin
{
    public partial class Frm_1000 : Form
    {
        public Frm_1000()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1001; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void BtnCreatFolder_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Directory.CreateDirectory(@"C:\Users\NIMA\Documents\New folder\" + i);

                }
                MessageBox.Show("پوشه ها ایجاد شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ایرادی در برنامه پیدا شده است.");
                // کاری کنیم تا اگر برنامه نویس وارد شد متن خطا هم نمایش داده شود 
                // اگر غیر برنامه نویس وارد شد متن خطا نمایش داده نشود 
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteFolder_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Directory.Delete(@"C:\Users\NIMA\Documents\New folder\" + i);

            }
            MessageBox.Show("پوشه ها حذف شد");
        }
    }
}
