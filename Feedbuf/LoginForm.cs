using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuf
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.PasswordTbox = new System.Windows.Forms.TextBox();
            this.GebruikersnaamLbl = new System.Windows.Forms.Label();
            this.WachtwoordLbl = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(285, 233);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(179, 26);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Signin_Click);
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Location = new System.Drawing.Point(285, 103);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(179, 20);
            this.UsernameTBox.TabIndex = 1;
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Location = new System.Drawing.Point(285, 173);
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.Size = new System.Drawing.Size(179, 20);
            this.PasswordTbox.TabIndex = 2;
            // 
            // GebruikersnaamLbl
            // 
            this.GebruikersnaamLbl.AutoSize = true;
            this.GebruikersnaamLbl.Location = new System.Drawing.Point(282, 84);
            this.GebruikersnaamLbl.Name = "GebruikersnaamLbl";
            this.GebruikersnaamLbl.Size = new System.Drawing.Size(84, 13);
            this.GebruikersnaamLbl.TabIndex = 3;
            this.GebruikersnaamLbl.Text = "Gebruikersnaam";
            this.GebruikersnaamLbl.Click += new System.EventHandler(this.GebruikersnaamLbl_Click);
            // 
            // WachtwoordLbl
            // 
            this.WachtwoordLbl.AutoSize = true;
            this.WachtwoordLbl.Location = new System.Drawing.Point(285, 151);
            this.WachtwoordLbl.Name = "WachtwoordLbl";
            this.WachtwoordLbl.Size = new System.Drawing.Size(68, 13);
            this.WachtwoordLbl.TabIndex = 4;
            this.WachtwoordLbl.Text = "Wachtwoord";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(285, 277);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(179, 25);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Registreren";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ForgotPasswordLbl
            // 
            this.ForgotPasswordLbl.AutoSize = true;
            this.ForgotPasswordLbl.BackColor = System.Drawing.SystemColors.Control;
            this.ForgotPasswordLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ForgotPasswordLbl.Location = new System.Drawing.Point(285, 217);
            this.ForgotPasswordLbl.Name = "ForgotPasswordLbl";
            this.ForgotPasswordLbl.Size = new System.Drawing.Size(119, 13);
            this.ForgotPasswordLbl.TabIndex = 6;
            this.ForgotPasswordLbl.Text = "Wachtwoord vergeten?";
            this.ForgotPasswordLbl.Click += new System.EventHandler(this.ForgotPasswordLbl_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(771, 391);
            this.Controls.Add(this.ForgotPasswordLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.WachtwoordLbl);
            this.Controls.Add(this.GebruikersnaamLbl);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.Login);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void ForgotPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            new LogboekForm().Show();
            this.Hide();

        }

        private void GebruikersnaamLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
