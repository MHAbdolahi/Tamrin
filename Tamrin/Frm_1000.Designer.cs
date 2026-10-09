namespace Tamrin
{
    partial class Frm_1000
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreatFolder = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "چاپ اعداد 1-1000";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(172, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(198, 251);
            this.listBox1.TabIndex = 1;
            // 
            // btnCreatFolder
            // 
            this.btnCreatFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatFolder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatFolder.Location = new System.Drawing.Point(23, 97);
            this.btnCreatFolder.Name = "btnCreatFolder";
            this.btnCreatFolder.Size = new System.Drawing.Size(133, 55);
            this.btnCreatFolder.TabIndex = 2;
            this.btnCreatFolder.Text = "ساخت 1000 پوشه";
            this.btnCreatFolder.UseVisualStyleBackColor = true;
            this.btnCreatFolder.Click += new System.EventHandler(this.BtnCreatFolder_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFolder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFolder.Location = new System.Drawing.Point(23, 202);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(133, 55);
            this.btnDeleteFolder.TabIndex = 3;
            this.btnDeleteFolder.Text = "حذف 1000 پوشه";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.BtnDeleteFolder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Frm_1000
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(382, 385);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnCreatFolder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_1000";
            this.Text = "1000";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreatFolder;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnClose;
    }
}