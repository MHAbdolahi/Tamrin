namespace Tamrin
{
    partial class Frm_ZojFard
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Location = new System.Drawing.Point(208, 217);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 31);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "نمایش";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(67, 95);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("B Homa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrint.Location = new System.Drawing.Point(67, 134);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrint.Size = new System.Drawing.Size(196, 51);
            this.txtPrint.TabIndex = 2;
            this.txtPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnclose.Location = new System.Drawing.Point(12, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(184, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "عدد را وارد کنید :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_ZojFard
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(346, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ZojFard";
            this.Text = "ZojFard";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}