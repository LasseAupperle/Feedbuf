using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuf
{
    public partial class LogboekForm : Form
    {
        BindingSource feedbackbindingsource = new BindingSource();
        
        public LogboekForm()
        {
            InitializeComponent();
            /*Feedback fb = new Feedback();
            DatagridLogboek.DataSource = fb.ReadFeedbacks();*/

        }

        public void hidePanels() 
        {
                    
        }

        private void Logboek_Load(object sender, EventArgs e)
        {
            hidePanels();
            
        }
  
        private void NieuweNotitieBtn_Click(object sender, EventArgs e)
        {
            new NieuweNotitiefrom().Show();
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();

            feedbackbindingsource.DataSource = dal.ReadFeedbacks();
            DatagridLogboek.DataSource = feedbackbindingsource;
        }

        private void UrenLbl_Click(object sender, EventArgs e)
        {

        }

        private void ToevoegBtn_Click(object sender, EventArgs e)
        {

            Feedback feedback = new Feedback
            {
                FBinhoud = TxtFB.Text

            };
            DAL dal = new DAL();
            int result = DAL.addNewNotitie(feedback);
        }
    }
}
