namespace Feedbuf
{
    partial class HomecscreenForm
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
            this.Logboekhomescreen = new System.Windows.Forms.Button();
            this.Feedbackhome = new System.Windows.Forms.Button();
            this.Feedforwardhome = new System.Windows.Forms.Button();
            this.Feeduphome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logboekhomescreen
            // 
            this.Logboekhomescreen.Location = new System.Drawing.Point(35, 42);
            this.Logboekhomescreen.Name = "Logboekhomescreen";
            this.Logboekhomescreen.Size = new System.Drawing.Size(121, 56);
            this.Logboekhomescreen.TabIndex = 0;
            this.Logboekhomescreen.Text = "Logboek";
            this.Logboekhomescreen.UseVisualStyleBackColor = true;
            // 
            // Feedbackhome
            // 
            this.Feedbackhome.Location = new System.Drawing.Point(35, 132);
            this.Feedbackhome.Name = "Feedbackhome";
            this.Feedbackhome.Size = new System.Drawing.Size(121, 56);
            this.Feedbackhome.TabIndex = 1;
            this.Feedbackhome.Text = "Feedback";
            this.Feedbackhome.UseVisualStyleBackColor = true;
            // 
            // Feedforwardhome
            // 
            this.Feedforwardhome.Location = new System.Drawing.Point(35, 226);
            this.Feedforwardhome.Name = "Feedforwardhome";
            this.Feedforwardhome.Size = new System.Drawing.Size(121, 56);
            this.Feedforwardhome.TabIndex = 2;
            this.Feedforwardhome.Text = "Feedforward";
            this.Feedforwardhome.UseVisualStyleBackColor = true;
            // 
            // Feeduphome
            // 
            this.Feeduphome.Location = new System.Drawing.Point(35, 320);
            this.Feeduphome.Name = "Feeduphome";
            this.Feeduphome.Size = new System.Drawing.Size(121, 56);
            this.Feeduphome.TabIndex = 3;
            this.Feeduphome.Text = "Feedup";
            this.Feeduphome.UseVisualStyleBackColor = true;
            // 
            // homecscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Feeduphome);
            this.Controls.Add(this.Feedforwardhome);
            this.Controls.Add(this.Feedbackhome);
            this.Controls.Add(this.Logboekhomescreen);
            this.Name = "homecscreen";
            this.Text = "homecscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logboekhomescreen;
        private System.Windows.Forms.Button Feedbackhome;
        private System.Windows.Forms.Button Feedforwardhome;
        private System.Windows.Forms.Button Feeduphome;
    }
}