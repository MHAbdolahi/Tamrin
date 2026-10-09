namespace Tamrin
{
    partial class Frm_AdadeGhablBaad
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
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("B Homa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrint.Location = new System.Drawing.Point(27, 201);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(266, 64);
            this.txtPrint.TabIndex = 5;
            this.txtPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(66, 118);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(111, 20);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Location = new System.Drawing.Point(205, 107);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 36);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "نمایش";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(12, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(55, 23);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 327);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(330, 35);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_AdadeGhablBaad
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(330, 362);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AdadeGhablBaad";
            this.Text = "AdadeGhablBaad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}