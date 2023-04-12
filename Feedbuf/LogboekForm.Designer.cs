namespace Feedbuf
{
    partial class LogboekForm
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
            this.NieuweNotitieBtn = new System.Windows.Forms.Button();
            this.UitlogBtn = new System.Windows.Forms.Button();
            this.DatagridLogboek = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.Notitietoevoegenbox = new System.Windows.Forms.GroupBox();
            this.FeedbackLbl = new System.Windows.Forms.Label();
            this.UrenLbl = new System.Windows.Forms.Label();
            this.ActiviteitLbl = new System.Windows.Forms.Label();
            this.LeerdoelLbl = new System.Windows.Forms.Label();
            this.OnderwijseenheidLbl = new System.Windows.Forms.Label();
            this.TxtOE = new System.Windows.Forms.TextBox();
            this.TxtLD = new System.Windows.Forms.TextBox();
            this.TxtACT = new System.Windows.Forms.TextBox();
            this.TxtUREN = new System.Windows.Forms.TextBox();
            this.TxtFB = new System.Windows.Forms.TextBox();
            this.ToevoegBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridLogboek)).BeginInit();
            this.Notitietoevoegenbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NieuweNotitieBtn
            // 
            this.NieuweNotitieBtn.Location = new System.Drawing.Point(511, 347);
            this.NieuweNotitieBtn.Name = "NieuweNotitieBtn";
            this.NieuweNotitieBtn.Size = new System.Drawing.Size(127, 56);
            this.NieuweNotitieBtn.TabIndex = 0;
            this.NieuweNotitieBtn.Text = "Nieuwe Notitie +";
            this.NieuweNotitieBtn.UseVisualStyleBackColor = true;
            this.NieuweNotitieBtn.Click += new System.EventHandler(this.NieuweNotitieBtn_Click);
            // 
            // UitlogBtn
            // 
            this.UitlogBtn.Location = new System.Drawing.Point(12, 347);
            this.UitlogBtn.Name = "UitlogBtn";
            this.UitlogBtn.Size = new System.Drawing.Size(127, 56);
            this.UitlogBtn.TabIndex = 1;
            this.UitlogBtn.Text = "Uitloggen";
            this.UitlogBtn.UseVisualStyleBackColor = true;
            // 
            // DatagridLogboek
            // 
            this.DatagridLogboek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridLogboek.Location = new System.Drawing.Point(255, 12);
            this.DatagridLogboek.Name = "DatagridLogboek";
            this.DatagridLogboek.Size = new System.Drawing.Size(464, 318);
            this.DatagridLogboek.TabIndex = 2;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(644, 347);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Notitietoevoegenbox
            // 
            this.Notitietoevoegenbox.Controls.Add(this.ToevoegBtn);
            this.Notitietoevoegenbox.Controls.Add(this.TxtFB);
            this.Notitietoevoegenbox.Controls.Add(this.TxtUREN);
            this.Notitietoevoegenbox.Controls.Add(this.TxtACT);
            this.Notitietoevoegenbox.Controls.Add(this.TxtLD);
            this.Notitietoevoegenbox.Controls.Add(this.TxtOE);
            this.Notitietoevoegenbox.Controls.Add(this.FeedbackLbl);
            this.Notitietoevoegenbox.Controls.Add(this.UrenLbl);
            this.Notitietoevoegenbox.Controls.Add(this.ActiviteitLbl);
            this.Notitietoevoegenbox.Controls.Add(this.LeerdoelLbl);
            this.Notitietoevoegenbox.Controls.Add(this.OnderwijseenheidLbl);
            this.Notitietoevoegenbox.Location = new System.Drawing.Point(12, 12);
            this.Notitietoevoegenbox.Name = "Notitietoevoegenbox";
            this.Notitietoevoegenbox.Size = new System.Drawing.Size(237, 318);
            this.Notitietoevoegenbox.TabIndex = 4;
            this.Notitietoevoegenbox.TabStop = false;
            this.Notitietoevoegenbox.Text = "Notities toevoegen";
            // 
            // FeedbackLbl
            // 
            this.FeedbackLbl.AutoSize = true;
            this.FeedbackLbl.Location = new System.Drawing.Point(7, 226);
            this.FeedbackLbl.Name = "FeedbackLbl";
            this.FeedbackLbl.Size = new System.Drawing.Size(55, 13);
            this.FeedbackLbl.TabIndex = 4;
            this.FeedbackLbl.Text = "Feedback";
            // 
            // UrenLbl
            // 
            this.UrenLbl.AutoSize = true;
            this.UrenLbl.Location = new System.Drawing.Point(6, 176);
            this.UrenLbl.Name = "UrenLbl";
            this.UrenLbl.Size = new System.Drawing.Size(30, 13);
            this.UrenLbl.TabIndex = 3;
            this.UrenLbl.Text = "Uren";
            this.UrenLbl.Click += new System.EventHandler(this.UrenLbl_Click);
            // 
            // ActiviteitLbl
            // 
            this.ActiviteitLbl.AutoSize = true;
            this.ActiviteitLbl.Location = new System.Drawing.Point(6, 124);
            this.ActiviteitLbl.Name = "ActiviteitLbl";
            this.ActiviteitLbl.Size = new System.Drawing.Size(47, 13);
            this.ActiviteitLbl.TabIndex = 2;
            this.ActiviteitLbl.Text = "Activiteit";
            // 
            // LeerdoelLbl
            // 
            this.LeerdoelLbl.AutoSize = true;
            this.LeerdoelLbl.Location = new System.Drawing.Point(6, 71);
            this.LeerdoelLbl.Name = "LeerdoelLbl";
            this.LeerdoelLbl.Size = new System.Drawing.Size(48, 13);
            this.LeerdoelLbl.TabIndex = 1;
            this.LeerdoelLbl.Text = "Leerdoel";
            // 
            // OnderwijseenheidLbl
            // 
            this.OnderwijseenheidLbl.AutoSize = true;
            this.OnderwijseenheidLbl.Location = new System.Drawing.Point(7, 20);
            this.OnderwijseenheidLbl.Name = "OnderwijseenheidLbl";
            this.OnderwijseenheidLbl.Size = new System.Drawing.Size(91, 13);
            this.OnderwijseenheidLbl.TabIndex = 0;
            this.OnderwijseenheidLbl.Text = "Onderwijseenheid";
            // 
            // TxtOE
            // 
            this.TxtOE.Location = new System.Drawing.Point(9, 36);
            this.TxtOE.Name = "TxtOE";
            this.TxtOE.Size = new System.Drawing.Size(118, 20);
            this.TxtOE.TabIndex = 5;
            // 
            // TxtLD
            // 
            this.TxtLD.Location = new System.Drawing.Point(7, 88);
            this.TxtLD.Name = "TxtLD";
            this.TxtLD.Size = new System.Drawing.Size(120, 20);
            this.TxtLD.TabIndex = 6;
            // 
            // TxtACT
            // 
            this.TxtACT.Location = new System.Drawing.Point(10, 141);
            this.TxtACT.Name = "TxtACT";
            this.TxtACT.Size = new System.Drawing.Size(117, 20);
            this.TxtACT.TabIndex = 7;
            // 
            // TxtUREN
            // 
            this.TxtUREN.Location = new System.Drawing.Point(10, 193);
            this.TxtUREN.Name = "TxtUREN";
            this.TxtUREN.Size = new System.Drawing.Size(117, 20);
            this.TxtUREN.TabIndex = 8;
            // 
            // TxtFB
            // 
            this.TxtFB.Location = new System.Drawing.Point(9, 243);
            this.TxtFB.Name = "TxtFB";
            this.TxtFB.Size = new System.Drawing.Size(118, 20);
            this.TxtFB.TabIndex = 9;
            // 
            // ToevoegBtn
            // 
            this.ToevoegBtn.Location = new System.Drawing.Point(9, 289);
            this.ToevoegBtn.Name = "ToevoegBtn";
            this.ToevoegBtn.Size = new System.Drawing.Size(118, 23);
            this.ToevoegBtn.TabIndex = 10;
            this.ToevoegBtn.Text = "Toevoegen";
            this.ToevoegBtn.UseVisualStyleBackColor = true;
            this.ToevoegBtn.Click += new System.EventHandler(this.ToevoegBtn_Click);
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 415);
            this.Controls.Add(this.Notitietoevoegenbox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.DatagridLogboek);
            this.Controls.Add(this.UitlogBtn);
            this.Controls.Add(this.NieuweNotitieBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogboekForm";
            this.Text = "Logboek";
            this.Load += new System.EventHandler(this.Logboek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridLogboek)).EndInit();
            this.Notitietoevoegenbox.ResumeLayout(false);
            this.Notitietoevoegenbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NieuweNotitieBtn;
        private System.Windows.Forms.Button UitlogBtn;
        private System.Windows.Forms.DataGridView DatagridLogboek;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox Notitietoevoegenbox;
        private System.Windows.Forms.Label ActiviteitLbl;
        private System.Windows.Forms.Label LeerdoelLbl;
        private System.Windows.Forms.Label OnderwijseenheidLbl;
        private System.Windows.Forms.Label UrenLbl;
        private System.Windows.Forms.Label FeedbackLbl;
        private System.Windows.Forms.Button ToevoegBtn;
        private System.Windows.Forms.TextBox TxtFB;
        private System.Windows.Forms.TextBox TxtUREN;
        private System.Windows.Forms.TextBox TxtACT;
        private System.Windows.Forms.TextBox TxtLD;
        private System.Windows.Forms.TextBox TxtOE;
    }
}