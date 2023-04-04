namespace Feedbuf
{
    partial class RegisterForm
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
            this.VolledigeNaamLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.Wachtwoord = new System.Windows.Forms.Label();
            this.RegistratieBtn = new System.Windows.Forms.Button();
            this.VolledigenaamTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.WachtwoordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VolledigeNaamLbl
            // 
            this.VolledigeNaamLbl.AutoSize = true;
            this.VolledigeNaamLbl.Location = new System.Drawing.Point(325, 103);
            this.VolledigeNaamLbl.Name = "VolledigeNaamLbl";
            this.VolledigeNaamLbl.Size = new System.Drawing.Size(79, 13);
            this.VolledigeNaamLbl.TabIndex = 0;
            this.VolledigeNaamLbl.Text = "Volledige naam";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(325, 142);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(35, 13);
            this.EmailLbl.TabIndex = 1;
            this.EmailLbl.Text = "E-mail";
            // 
            // Wachtwoord
            // 
            this.Wachtwoord.AutoSize = true;
            this.Wachtwoord.Location = new System.Drawing.Point(325, 183);
            this.Wachtwoord.Name = "Wachtwoord";
            this.Wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.Wachtwoord.TabIndex = 2;
            this.Wachtwoord.Text = "Wachtwoord";
            // 
            // RegistratieBtn
            // 
            this.RegistratieBtn.Location = new System.Drawing.Point(328, 237);
            this.RegistratieBtn.Name = "RegistratieBtn";
            this.RegistratieBtn.Size = new System.Drawing.Size(100, 23);
            this.RegistratieBtn.TabIndex = 4;
            this.RegistratieBtn.Text = "Registreren";
            this.RegistratieBtn.UseVisualStyleBackColor = true;
            // 
            // VolledigenaamTxt
            // 
            this.VolledigenaamTxt.Location = new System.Drawing.Point(328, 119);
            this.VolledigenaamTxt.Name = "VolledigenaamTxt";
            this.VolledigenaamTxt.Size = new System.Drawing.Size(100, 20);
            this.VolledigenaamTxt.TabIndex = 5;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(328, 160);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(100, 20);
            this.EmailTxt.TabIndex = 6;
            // 
            // WachtwoordTxt
            // 
            this.WachtwoordTxt.Location = new System.Drawing.Point(328, 199);
            this.WachtwoordTxt.Name = "WachtwoordTxt";
            this.WachtwoordTxt.Size = new System.Drawing.Size(100, 20);
            this.WachtwoordTxt.TabIndex = 7;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WachtwoordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.VolledigenaamTxt);
            this.Controls.Add(this.RegistratieBtn);
            this.Controls.Add(this.Wachtwoord);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.VolledigeNaamLbl);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VolledigeNaamLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label Wachtwoord;
        private System.Windows.Forms.Button RegistratieBtn;
        private System.Windows.Forms.TextBox VolledigenaamTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox WachtwoordTxt;
    }
}