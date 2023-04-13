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
                
                OE = TxtOE.Text,
                LD = TxtOE.Text,
                ACT= TxtACT.Text,
                Uren = Int32.Parse(TxtUREN.Text),
                FBinhoud = TxtFB.Text,
                StudentID = Int32.Parse(TxtSTUDENTID.Text),
                Akkoord = AkkordCheckbox.Checked,


            };
            DAL dal = new DAL();
            int result = DAL.addNewNotitie(feedback);
            //check feedback en Feedback in vid

        }

        private void TxtOE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFB_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatagridLogboek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView datagridlogboek = (DataGridView)sender;
            
        }

        private void VerwijderBtn_Click(object sender, EventArgs e)
        {
            //DataGridView datagridlogboek = (DataGridView)sender;
            int rowClicked = DatagridLogboek.CurrentRow.Index;
            MessageBox.Show("De tij is " + rowClicked);
            int notitieID = (int)DatagridLogboek.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID van notitie " + notitieID);
            DAL dal = new DAL();

            int result = dal.verwijderNotitie(notitieID);
        }
    }
}
