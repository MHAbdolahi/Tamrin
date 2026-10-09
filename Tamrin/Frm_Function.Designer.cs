namespace Tamrin
{
    partial class Frm_Function
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
            this.btnNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNumber
            // 
            this.btnNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNumber.Location = new System.Drawing.Point(116, 166);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(91, 35);
            this.btnNumber.TabIndex = 0;
            this.btnNumber.Text = "نمایش";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(73, 140);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(176, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrint.Location = new System.Drawing.Point(73, 221);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(176, 56);
            this.txtPrint.TabIndex = 3;
            this.txtPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(73, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "عدد 1 یا 2 را وارد کنید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Function
            // 
            this.AcceptButton = this.btnNumber;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(315, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Function";
            this.Text = "Function";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}