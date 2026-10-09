namespace Tamrin
{
    partial class Frm_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.radioModir = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(179, 48);
            this.txtusername.Name = "txtusername";
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(179, 78);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // radioModir
            // 
            this.radioModir.AutoSize = true;
            this.radioModir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioModir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioModir.Location = new System.Drawing.Point(266, 115);
            this.radioModir.Name = "radioModir";
            this.radioModir.Size = new System.Drawing.Size(45, 17);
            this.radioModir.TabIndex = 2;
            this.radioModir.TabStop = true;
            this.radioModir.Text = "مدیر";
            this.radioModir.UseVisualStyleBackColor = true;
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioUser.Location = new System.Drawing.Point(210, 115);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(45, 17);
            this.radioUser.TabIndex = 3;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "کاربر";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlogin.Location = new System.Drawing.Point(373, 184);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 31);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "ورود";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnclose.Location = new System.Drawing.Point(12, 184);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 31);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPassword.Image = global::Tamrin.Properties.Resources.images;
            this.pictureBoxPassword.Location = new System.Drawing.Point(147, 78);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(26, 24);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 6;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPassword_MouseDown);
            this.pictureBoxPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxPassword_MouseUp);
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(469, 227);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.radioModir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.RadioButton radioModir;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}