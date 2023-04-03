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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Signin = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Usernamelogin = new System.Windows.Forms.Label();
            this.Passwordlogin = new System.Windows.Forms.Label();
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
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(285, 103);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(179, 22);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(285, 173);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(179, 22);
            this.Password.TabIndex = 2;
            // 
            // Usernamelogin
            // 
            this.Usernamelogin.AutoSize = true;
            this.Usernamelogin.Location = new System.Drawing.Point(282, 84);
            this.Usernamelogin.Name = "Usernamelogin";
            this.Usernamelogin.Size = new System.Drawing.Size(70, 16);
            this.Usernamelogin.TabIndex = 3;
            this.Usernamelogin.Text = "Username";
            // 
            // Passwordlogin
            // 
            this.Passwordlogin.AutoSize = true;
            this.Passwordlogin.Location = new System.Drawing.Point(285, 151);
            this.Passwordlogin.Name = "Passwordlogin";
            this.Passwordlogin.Size = new System.Drawing.Size(67, 16);
            this.Passwordlogin.TabIndex = 4;
            this.Passwordlogin.Text = "Password";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(771, 391);
            this.Controls.Add(this.Passwordlogin);
            this.Controls.Add(this.Usernamelogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Signin);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
