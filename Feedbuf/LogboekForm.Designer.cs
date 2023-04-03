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
            this.planninglogboek = new System.Windows.Forms.Button();
            this.Weekdoelenlogboek = new System.Windows.Forms.Button();
            this.PlanningPannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // planninglogboek
            // 
            this.planninglogboek.Location = new System.Drawing.Point(29, 22);
            this.planninglogboek.Name = "planninglogboek";
            this.planninglogboek.Size = new System.Drawing.Size(107, 55);
            this.planninglogboek.TabIndex = 0;
            this.planninglogboek.Text = "planning";
            this.planninglogboek.UseVisualStyleBackColor = true;
            this.planninglogboek.Click += new System.EventHandler(this.planninglogboek_Click);
            // 
            // Weekdoelenlogboek
            // 
            this.Weekdoelenlogboek.Location = new System.Drawing.Point(29, 102);
            this.Weekdoelenlogboek.Name = "Weekdoelenlogboek";
            this.Weekdoelenlogboek.Size = new System.Drawing.Size(108, 55);
            this.Weekdoelenlogboek.TabIndex = 1;
            this.Weekdoelenlogboek.Text = "Weekdoelen";
            this.Weekdoelenlogboek.UseVisualStyleBackColor = true;
            // 
            // PlanningPannel
            // 
            this.PlanningPannel.Location = new System.Drawing.Point(213, 22);
            this.PlanningPannel.Name = "PlanningPannel";
            this.PlanningPannel.Size = new System.Drawing.Size(538, 393);
            this.PlanningPannel.TabIndex = 2;
            this.PlanningPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlanningPannel_Paint);
            // 
            // Logboek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlanningPannel);
            this.Controls.Add(this.Weekdoelenlogboek);
            this.Controls.Add(this.planninglogboek);
            this.Name = "Logboek";
            this.Text = "Logboek";
            this.Load += new System.EventHandler(this.Logboek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button planninglogboek;
        private System.Windows.Forms.Button Weekdoelenlogboek;
        private System.Windows.Forms.Panel PlanningPannel;
    }
}