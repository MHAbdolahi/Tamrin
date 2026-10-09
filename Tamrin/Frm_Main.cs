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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
            // Close();
          
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Frm_1000 frm = new Frm_1000();
            frm.ShowDialog();
        }

        private void BtnAdadeAval_Click(object sender, EventArgs e)
        {
            Frm_AdadeAval frm = new Frm_AdadeAval();
            frm.ShowDialog();

        }

        private void BtnGhablBaad_Click(object sender, EventArgs e)
        {
            Frm_AdadeGhablBaad frm = new Frm_AdadeGhablBaad();
            frm.ShowDialog();
        }

        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            Frm_Name frm = new Frm_Name();
            frm.ShowDialog();
        }

        private void Btnweek_Click(object sender, EventArgs e)
        {
            Frm_Week frm = new Frm_Week();
            frm.ShowDialog();
        }

        private void BtnFunction_Click(object sender, EventArgs e)
        {
            Frm_Function frm = new Frm_Function();
            frm.ShowDialog();
        }

        private void BtnZojFard_Click(object sender, EventArgs e)
        {
            Frm_ZojFard frm = new Frm_ZojFard();
            frm.ShowDialog();
        }

        private void BtnSubString_Click(object sender, EventArgs e)
        {
            Frm_SubString frm = new Frm_SubString();
            frm.ShowDialog();
        }

        private void BtnWorkString_Click(object sender, EventArgs e)
        {
            Frm_WorkString frm = new Frm_WorkString();
            frm.ShowDialog();
        }

        private void BtnTaghsim_Click(object sender, EventArgs e)
        {
            Frm_Taghsim frm = new Frm_Taghsim();
            frm.ShowDialog();
        }
    }
}
