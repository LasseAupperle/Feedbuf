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
    public partial class LogboekForm : Form
    {
        public LogboekForm()
        {
            InitializeComponent();
        }

        public void hidePanels() 
        {
            PlanningPannel.Visible = false;        
        }

        private void Logboek_Load(object sender, EventArgs e)
        {
            hidePanels();
            PlanningPannel.Visible= false;
        }

        private void PlanningPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void planninglogboek_Click(object sender, EventArgs e)
        {
            hidePanels();
            PlanningPannel.Visible = true;
        }
    }
}
