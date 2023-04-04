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
            this.SuspendLayout();
            // 
            // NieuweNotitieBtn
            // 
            this.NieuweNotitieBtn.Location = new System.Drawing.Point(592, 347);
            this.NieuweNotitieBtn.Name = "NieuweNotitieBtn";
            this.NieuweNotitieBtn.Size = new System.Drawing.Size(127, 56);
            this.NieuweNotitieBtn.TabIndex = 0;
            this.NieuweNotitieBtn.Text = "Nieuwe Notitie +";
            this.NieuweNotitieBtn.UseVisualStyleBackColor = true;
            this.NieuweNotitieBtn.Click += new System.EventHandler(this.NieuweNotitieBtn_Click);
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 415);
            this.Controls.Add(this.NieuweNotitieBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogboekForm";
            this.Text = "Logboek";
            this.Load += new System.EventHandler(this.Logboek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NieuweNotitieBtn;
    }
}