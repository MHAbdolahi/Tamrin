namespace Tamrin
{
    partial class Frm_Taghsim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSoorat = new System.Windows.Forms.TextBox();
            this.txtMakhraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRun.Location = new System.Drawing.Point(233, 176);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 31);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "نمایش";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtSoorat
            // 
            this.txtSoorat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoorat.Location = new System.Drawing.Point(233, 68);
            this.txtSoorat.Name = "txtSoorat";
            this.txtSoorat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoorat.Size = new System.Drawing.Size(100, 21);
            this.txtSoorat.TabIndex = 0;
            this.txtSoorat.TextChanged += new System.EventHandler(this.TxtSoorat_TextChanged);
            this.txtSoorat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoorat_KeyPress);
            // 
            // txtMakhraj
            // 
            this.txtMakhraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakhraj.Location = new System.Drawing.Point(233, 107);
            this.txtMakhraj.Name = "txtMakhraj";
            this.txtMakhraj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMakhraj.Size = new System.Drawing.Size(100, 21);
            this.txtMakhraj.TabIndex = 1;
            this.txtMakhraj.TextChanged += new System.EventHandler(this.TxtMakhraj_TextChanged);
            this.txtMakhraj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMakhraj_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrint.Location = new System.Drawing.Point(53, 78);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ReadOnly = true;
            this.txtPrint.Size = new System.Drawing.Size(123, 37);
            this.txtPrint.TabIndex = 6;
            this.txtPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(349, 86);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "عبارت را وارد کنید :";
            // 
            // Frm_Taghsim
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(505, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMakhraj);
            this.Controls.Add(this.txtSoorat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Taghsim";
            this.Text = "Frm_Taghsim";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSoorat;
        private System.Windows.Forms.TextBox txtMakhraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
    }
}