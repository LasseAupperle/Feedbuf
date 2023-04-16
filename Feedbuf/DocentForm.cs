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
    public partial class DocentForm : Form
    {
        BindingSource studentbindingsource = new BindingSource();
        BindingSource studentenfeedbackbindingsource = new BindingSource();
        public DocentForm()
        {
            InitializeComponent();
        }

        private void Studentendatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            DAL dal = new DAL();
            DataGridView Studentendatagrid = (DataGridView)sender;
            int rowClicked = Studentendatagrid.CurrentRow.Index;
            studentenfeedbackbindingsource.DataSource = dal.ReadFeedbacksFromStudents((int)Studentendatagrid.Rows[rowClicked].Cells[0].Value);           
            Studentenfeedbackdatagrid.DataSource = studentenfeedbackbindingsource;
        }

        private void studentenlijstBtn_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            studentbindingsource.DataSource = dal.Readstudentsdocenten();
            Studentendatagrid.DataSource = studentbindingsource;
        }

        private void Studentenfeedbackdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DocentuitlogBtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
