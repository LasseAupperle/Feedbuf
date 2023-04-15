namespace Feedbuf
{
    partial class DocentForm
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
            this.Studentendatagrid = new System.Windows.Forms.DataGridView();
            this.studentenlijstBtn = new System.Windows.Forms.Button();
            this.Studentenfeedbackdatagrid = new System.Windows.Forms.DataGridView();
            this.StudentenlijstLbl = new System.Windows.Forms.Label();
            this.StudentfeedbackLBl = new System.Windows.Forms.Label();
            this.DocentuitlogBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Studentendatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Studentenfeedbackdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Studentendatagrid
            // 
            this.Studentendatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentendatagrid.Location = new System.Drawing.Point(122, 36);
            this.Studentendatagrid.Name = "Studentendatagrid";
            this.Studentendatagrid.Size = new System.Drawing.Size(329, 402);
            this.Studentendatagrid.TabIndex = 0;
            this.Studentendatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentendatagrid_CellContentClick);
            // 
            // studentenlijstBtn
            // 
            this.studentenlijstBtn.Location = new System.Drawing.Point(12, 36);
            this.studentenlijstBtn.Name = "studentenlijstBtn";
            this.studentenlijstBtn.Size = new System.Drawing.Size(104, 67);
            this.studentenlijstBtn.TabIndex = 1;
            this.studentenlijstBtn.Text = "Ververs studenten lijst";
            this.studentenlijstBtn.UseVisualStyleBackColor = true;
            this.studentenlijstBtn.Click += new System.EventHandler(this.studentenlijstBtn_Click);
            // 
            // Studentenfeedbackdatagrid
            // 
            this.Studentenfeedbackdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentenfeedbackdatagrid.Location = new System.Drawing.Point(458, 36);
            this.Studentenfeedbackdatagrid.Name = "Studentenfeedbackdatagrid";
            this.Studentenfeedbackdatagrid.Size = new System.Drawing.Size(330, 402);
            this.Studentenfeedbackdatagrid.TabIndex = 2;
            this.Studentenfeedbackdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentenfeedbackdatagrid_CellContentClick);
            // 
            // StudentenlijstLbl
            // 
            this.StudentenlijstLbl.AutoSize = true;
            this.StudentenlijstLbl.Location = new System.Drawing.Point(122, 17);
            this.StudentenlijstLbl.Name = "StudentenlijstLbl";
            this.StudentenlijstLbl.Size = new System.Drawing.Size(56, 13);
            this.StudentenlijstLbl.TabIndex = 3;
            this.StudentenlijstLbl.Text = "Studenten";
            // 
            // StudentfeedbackLBl
            // 
            this.StudentfeedbackLBl.AutoSize = true;
            this.StudentfeedbackLBl.Location = new System.Drawing.Point(458, 17);
            this.StudentfeedbackLBl.Name = "StudentfeedbackLBl";
            this.StudentfeedbackLBl.Size = new System.Drawing.Size(42, 13);
            this.StudentfeedbackLBl.TabIndex = 4;
            this.StudentfeedbackLBl.Text = "Notities";
            // 
            // DocentuitlogBtn
            // 
            this.DocentuitlogBtn.Location = new System.Drawing.Point(12, 371);
            this.DocentuitlogBtn.Name = "DocentuitlogBtn";
            this.DocentuitlogBtn.Size = new System.Drawing.Size(103, 67);
            this.DocentuitlogBtn.TabIndex = 5;
            this.DocentuitlogBtn.Text = "Uitloggen";
            this.DocentuitlogBtn.UseVisualStyleBackColor = true;
            this.DocentuitlogBtn.Click += new System.EventHandler(this.DocentuitlogBtn_Click);
            // 
            // DocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DocentuitlogBtn);
            this.Controls.Add(this.StudentfeedbackLBl);
            this.Controls.Add(this.StudentenlijstLbl);
            this.Controls.Add(this.Studentenfeedbackdatagrid);
            this.Controls.Add(this.studentenlijstBtn);
            this.Controls.Add(this.Studentendatagrid);
            this.Name = "DocentForm";
            this.Text = "DocentForm";
            ((System.ComponentModel.ISupportInitialize)(this.Studentendatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Studentenfeedbackdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Studentendatagrid;
        private System.Windows.Forms.Button studentenlijstBtn;
        private System.Windows.Forms.DataGridView Studentenfeedbackdatagrid;
        private System.Windows.Forms.Label StudentenlijstLbl;
        private System.Windows.Forms.Label StudentfeedbackLBl;
        private System.Windows.Forms.Button DocentuitlogBtn;
    }
}