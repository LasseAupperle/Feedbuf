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
            this.planningBtn = new System.Windows.Forms.Button();
            this.WeekdoelenBtn = new System.Windows.Forms.Button();
            this.PlanningPannel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // planningBtn
            // 
            this.planningBtn.Location = new System.Drawing.Point(29, 22);
            this.planningBtn.Name = "planningBtn";
            this.planningBtn.Size = new System.Drawing.Size(107, 55);
            this.planningBtn.TabIndex = 0;
            this.planningBtn.Text = "planning";
            this.planningBtn.UseVisualStyleBackColor = true;
            this.planningBtn.Click += new System.EventHandler(this.planninglogboek_Click);
            // 
            // WeekdoelenBtn
            // 
            this.WeekdoelenBtn.Location = new System.Drawing.Point(29, 102);
            this.WeekdoelenBtn.Name = "WeekdoelenBtn";
            this.WeekdoelenBtn.Size = new System.Drawing.Size(108, 55);
            this.WeekdoelenBtn.TabIndex = 1;
            this.WeekdoelenBtn.Text = "Weekdoelen";
            this.WeekdoelenBtn.UseVisualStyleBackColor = true;
            // 
            // PlanningPannel
            // 
            this.PlanningPannel.Location = new System.Drawing.Point(213, 22);
            this.PlanningPannel.Name = "PlanningPannel";
            this.PlanningPannel.Size = new System.Drawing.Size(538, 393);
            this.PlanningPannel.TabIndex = 2;
            this.PlanningPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlanningPannel_Paint);
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlanningPannel);
            this.Controls.Add(this.WeekdoelenBtn);
            this.Controls.Add(this.planningBtn);
            this.Name = "LogboekForm";
            this.Text = "Logboek";
            this.Load += new System.EventHandler(this.Logboek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button planningBtn;
        private System.Windows.Forms.Button WeekdoelenBtn;
        private System.Windows.Forms.Panel PlanningPannel;
    }
}