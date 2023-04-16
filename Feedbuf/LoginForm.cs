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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.GebruikersnaamLbl = new System.Windows.Forms.Label();
            this.WachtwoordLbl = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordLbl = new System.Windows.Forms.Label();
            this.Docentbtn = new System.Windows.Forms.Button();
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
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(285, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(285, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 2;
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
            // Docentbtn
            // 
            this.Docentbtn.Location = new System.Drawing.Point(285, 340);
            this.Docentbtn.Name = "Docentbtn";
            this.Docentbtn.Size = new System.Drawing.Size(179, 23);
            this.Docentbtn.TabIndex = 7;
            this.Docentbtn.Text = "Docent inlog";
            this.Docentbtn.UseVisualStyleBackColor = true;
            this.Docentbtn.Click += new System.EventHandler(this.Docentbtn_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(771, 391);
            this.Controls.Add(this.Docentbtn);
            this.Controls.Add(this.ForgotPasswordLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.WachtwoordLbl);
            this.Controls.Add(this.GebruikersnaamLbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
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
        private void GebruikersnaamLbl_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DAL dal = new DAL();
            List<Student> students = dal.ReadStudents();
            Student student = students.FirstOrDefault(s => s.Studentnaam == username);

            if (student == null)
            {
                // If no student record is found with the given username
                MessageBox.Show("Invalid username or password.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                
                
            }
            else if (student.Wachtwoord != password)
            {
                // If the password doesn't match
                MessageBox.Show("Invalid username or password.");
            }
            else
            {
                // If the username and password match, log in the student

                new LogboekForm().Show();
                this.Hide();
                // TODO: add code to navigate to the student's dashboard or profile page
            }
        }

        private void Docentbtn_Click(object sender, EventArgs e)
        {
            new DocentForm().Show();
            this.Hide();
        }
        //if () 





    }
}
