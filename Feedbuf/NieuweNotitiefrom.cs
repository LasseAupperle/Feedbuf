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
    public partial class NieuweNotitiefrom: Form
    {
        public void panelHide()
        {
            PanelOE.Visible = false;
            LDPanel.Visible = false;

        }

        private void Feedbuf_load(object sender, EventArgs e)
        {
            panelHide();
        }
        public NieuweNotitiefrom()
        {
            InitializeComponent();
        }

        private void PanelOE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnderwijseenheidBtn_Click(object sender, EventArgs e)
        {

            if(PanelOE.Visible)
            {
                PanelOE.Visible = false;
            }
            else
            {
                PanelOE.Visible = true;
            }

        }

        private void LeerdoelBtn_Click(object sender, EventArgs e)
        {

            if (LDPanel.Visible)
            {
                LDPanel.Visible = false;
            }
            else
            { 
                LDPanel.Visible = true;
            }
        }

        private void LDPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
