namespace Tamrin
{
    partial class Frm_Main
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdadeAval = new System.Windows.Forms.Button();
            this.BtnGhablBaad = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnweek = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnZojFard = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSubString = new System.Windows.Forms.Button();
            this.btnWorkString = new System.Windows.Forms.Button();
            this.btnTaghsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Location = new System.Drawing.Point(22, 101);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(210, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "چاپ اعداد 1000";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnAdadeAval
            // 
            this.btnAdadeAval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdadeAval.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdadeAval.Location = new System.Drawing.Point(22, 147);
            this.btnAdadeAval.Name = "btnAdadeAval";
            this.btnAdadeAval.Size = new System.Drawing.Size(210, 43);
            this.btnAdadeAval.TabIndex = 1;
            this.btnAdadeAval.Text = "تشخیص عدد اول";
            this.btnAdadeAval.UseVisualStyleBackColor = true;
            this.btnAdadeAval.Click += new System.EventHandler(this.BtnAdadeAval_Click);
            // 
            // BtnGhablBaad
            // 
            this.BtnGhablBaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGhablBaad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnGhablBaad.Location = new System.Drawing.Point(22, 196);
            this.BtnGhablBaad.Name = "BtnGhablBaad";
            this.BtnGhablBaad.Size = new System.Drawing.Size(210, 40);
            this.BtnGhablBaad.TabIndex = 2;
            this.BtnGhablBaad.Text = "تشخیص قبل و بعد";
            this.BtnGhablBaad.UseVisualStyleBackColor = true;
            this.BtnGhablBaad.Click += new System.EventHandler(this.BtnGhablBaad_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnWelcome.Location = new System.Drawing.Point(22, 242);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(210, 43);
            this.btnWelcome.TabIndex = 3;
            this.btnWelcome.Text = "صفحه خوش آمد گویی";
            this.btnWelcome.UseVisualStyleBackColor = true;
            this.btnWelcome.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // btnweek
            // 
            this.btnweek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnweek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnweek.Location = new System.Drawing.Point(22, 291);
            this.btnweek.Name = "btnweek";
            this.btnweek.Size = new System.Drawing.Size(210, 43);
            this.btnweek.TabIndex = 4;
            this.btnweek.Text = "تشخیص روز های هفته";
            this.btnweek.UseVisualStyleBackColor = true;
            this.btnweek.Click += new System.EventHandler(this.Btnweek_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFunction.Location = new System.Drawing.Point(244, 197);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(210, 39);
            this.btnFunction.TabIndex = 7;
            this.btnFunction.Text = "آموزش تابع";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.BtnFunction_Click);
            // 
            // btnZojFard
            // 
            this.btnZojFard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZojFard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnZojFard.Location = new System.Drawing.Point(244, 242);
            this.btnZojFard.Name = "btnZojFard";
            this.btnZojFard.Size = new System.Drawing.Size(210, 46);
            this.btnZojFard.TabIndex = 8;
            this.btnZojFard.Text = "تشخیص زوج و فرد";
            this.btnZojFard.UseVisualStyleBackColor = true;
            this.btnZojFard.Click += new System.EventHandler(this.BtnZojFard_Click);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(12, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(65, 22);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "خروج";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Button7_Click);
            // 
            // btnSubString
            // 
            this.btnSubString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubString.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubString.Location = new System.Drawing.Point(244, 294);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(210, 40);
            this.btnSubString.TabIndex = 9;
            this.btnSubString.Text = "جست و جوی رشته";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.BtnSubString_Click);
            // 
            // btnWorkString
            // 
            this.btnWorkString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkString.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnWorkString.Location = new System.Drawing.Point(244, 101);
            this.btnWorkString.Name = "btnWorkString";
            this.btnWorkString.Size = new System.Drawing.Size(210, 40);
            this.btnWorkString.TabIndex = 5;
            this.btnWorkString.Text = "کار با رشته";
            this.btnWorkString.UseVisualStyleBackColor = true;
            this.btnWorkString.Click += new System.EventHandler(this.BtnWorkString_Click);
            // 
            // btnTaghsim
            // 
            this.btnTaghsim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaghsim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTaghsim.Location = new System.Drawing.Point(244, 150);
            this.btnTaghsim.Name = "btnTaghsim";
            this.btnTaghsim.Size = new System.Drawing.Size(210, 40);
            this.btnTaghsim.TabIndex = 6;
            this.btnTaghsim.Text = "تقسیم اعداد";
            this.btnTaghsim.UseVisualStyleBackColor = true;
            this.btnTaghsim.Click += new System.EventHandler(this.BtnTaghsim_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(478, 436);
            this.Controls.Add(this.btnTaghsim);
            this.Controls.Add(this.btnWorkString);
            this.Controls.Add(this.btnSubString);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnZojFard);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnweek);
            this.Controls.Add(this.btnWelcome);
            this.Controls.Add(this.BtnGhablBaad);
            this.Controls.Add(this.btnAdadeAval);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdadeAval;
        private System.Windows.Forms.Button BtnGhablBaad;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Button btnweek;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnZojFard;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.Button btnWorkString;
        private System.Windows.Forms.Button btnTaghsim;
    }
}