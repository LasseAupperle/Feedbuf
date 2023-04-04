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
            this.Signin = new System.Windows.Forms.Button();
            this.UsernameTBox = new System.Windows.Forms.TextBox();
            this.PasswordTbox = new System.Windows.Forms.TextBox();
            this.UsernameBtn = new System.Windows.Forms.Label();
            this.PasswordBtn = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(285, 254);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(179, 79);
            this.Signin.TabIndex = 0;
            this.Signin.Text = "Sign in";
            this.Signin.UseVisualStyleBackColor = true;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.Location = new System.Drawing.Point(285, 103);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(179, 22);
            this.UsernameTBox.TabIndex = 1;
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Location = new System.Drawing.Point(285, 173);
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.Size = new System.Drawing.Size(179, 22);
            this.PasswordTbox.TabIndex = 2;
            // 
            // UsernameBtn
            // 
            this.UsernameBtn.AutoSize = true;
            this.UsernameBtn.Location = new System.Drawing.Point(282, 84);
            this.UsernameBtn.Name = "UsernameBtn";
            this.UsernameBtn.Size = new System.Drawing.Size(70, 16);
            this.UsernameBtn.TabIndex = 3;
            this.UsernameBtn.Text = "Username";
            // 
            // PasswordBtn
            // 
            this.PasswordBtn.AutoSize = true;
            this.PasswordBtn.Location = new System.Drawing.Point(285, 151);
            this.PasswordBtn.Name = "PasswordBtn";
            this.PasswordBtn.Size = new System.Drawing.Size(67, 16);
            this.PasswordBtn.TabIndex = 4;
            this.PasswordBtn.Text = "Password";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(152, 254);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(103, 50);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ForgotPasswordLbl
            // 
            this.ForgotPasswordLbl.AutoSize = true;
            this.ForgotPasswordLbl.BackColor = System.Drawing.SystemColors.Control;
            this.ForgotPasswordLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ForgotPasswordLbl.Location = new System.Drawing.Point(542, 240);
            this.ForgotPasswordLbl.Name = "ForgotPasswordLbl";
            this.ForgotPasswordLbl.Size = new System.Drawing.Size(115, 16);
            this.ForgotPasswordLbl.TabIndex = 6;
            this.ForgotPasswordLbl.Text = "Forgot password?";
            this.ForgotPasswordLbl.Click += new System.EventHandler(this.ForgotPasswordLbl_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(771, 391);
            this.Controls.Add(this.ForgotPasswordLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordBtn);
            this.Controls.Add(this.UsernameBtn);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.Signin);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            new HomecscreenForm().Show();
            this.Hide();

        }
    }
}
