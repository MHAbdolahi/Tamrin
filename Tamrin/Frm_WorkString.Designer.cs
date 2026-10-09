namespace Tamrin
{
    partial class Frm_WorkString
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
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(443, 209);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(84, 38);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "اجرا";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhrase.Location = new System.Drawing.Point(12, 59);
            this.txtPhrase.Multiline = true;
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhrase.Size = new System.Drawing.Size(315, 37);
            this.txtPhrase.TabIndex = 2;
            this.txtPhrase.TextChanged += new System.EventHandler(this.TxtPhrase_TextChanged);
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrint.Location = new System.Drawing.Point(12, 118);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ReadOnly = true;
            this.txtPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrint.Size = new System.Drawing.Size(315, 37);
            this.txtPrint.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(359, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "عبارت را وارد کنید :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_WorkString
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(548, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_WorkString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_WorkString";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}