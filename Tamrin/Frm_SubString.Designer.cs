namespace Tamrin
{
    partial class Frm_SubString
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
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameFolder = new System.Windows.Forms.TextBox();
            this.txtTwoBackslash = new System.Windows.Forms.TextBox();
            this.txtOneBackslash = new System.Windows.Forms.TextBox();
            this.txtOneFolder = new System.Windows.Forms.TextBox();
            this.txtDrive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(14, 58);
            this.txtDirectory.Multiline = true;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(207, 35);
            this.txtDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(227, 58);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "مسیر را مشخص کنید :";
            // 
            // txtNameFolder
            // 
            this.txtNameFolder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFolder.Location = new System.Drawing.Point(14, 161);
            this.txtNameFolder.Multiline = true;
            this.txtNameFolder.Name = "txtNameFolder";
            this.txtNameFolder.ReadOnly = true;
            this.txtNameFolder.Size = new System.Drawing.Size(207, 35);
            this.txtNameFolder.TabIndex = 2;
            // 
            // txtTwoBackslash
            // 
            this.txtTwoBackslash.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwoBackslash.Location = new System.Drawing.Point(14, 284);
            this.txtTwoBackslash.Multiline = true;
            this.txtTwoBackslash.Name = "txtTwoBackslash";
            this.txtTwoBackslash.ReadOnly = true;
            this.txtTwoBackslash.Size = new System.Drawing.Size(207, 35);
            this.txtTwoBackslash.TabIndex = 3;
            // 
            // txtOneBackslash
            // 
            this.txtOneBackslash.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOneBackslash.Location = new System.Drawing.Point(14, 243);
            this.txtOneBackslash.Multiline = true;
            this.txtOneBackslash.Name = "txtOneBackslash";
            this.txtOneBackslash.ReadOnly = true;
            this.txtOneBackslash.Size = new System.Drawing.Size(207, 35);
            this.txtOneBackslash.TabIndex = 4;
            // 
            // txtOneFolder
            // 
            this.txtOneFolder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOneFolder.Location = new System.Drawing.Point(14, 202);
            this.txtOneFolder.Multiline = true;
            this.txtOneFolder.Name = "txtOneFolder";
            this.txtOneFolder.ReadOnly = true;
            this.txtOneFolder.Size = new System.Drawing.Size(207, 35);
            this.txtOneFolder.TabIndex = 6;
            // 
            // txtDrive
            // 
            this.txtDrive.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrive.Location = new System.Drawing.Point(14, 118);
            this.txtDrive.Multiline = true;
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.ReadOnly = true;
            this.txtDrive.Size = new System.Drawing.Size(207, 35);
            this.txtDrive.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(234, 118);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام درایو :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(234, 202);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام آخرین پوشه :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(227, 243);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "شماره خانه اولین بک اسلش :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(225, 284);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "شماره خانه دومین بک اسلش :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(234, 161);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "نام اولین پوشه :";
            // 
            // btnRun
            // 
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(316, 369);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(118, 44);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "اجرا";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(14, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 25);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_SubString
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDrive);
            this.Controls.Add(this.txtOneFolder);
            this.Controls.Add(this.txtOneBackslash);
            this.Controls.Add(this.txtTwoBackslash);
            this.Controls.Add(this.txtNameFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SubString";
            this.Text = "Frm_SubString";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameFolder;
        private System.Windows.Forms.TextBox txtTwoBackslash;
        private System.Windows.Forms.TextBox txtOneBackslash;
        private System.Windows.Forms.TextBox txtOneFolder;
        private System.Windows.Forms.TextBox txtDrive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}