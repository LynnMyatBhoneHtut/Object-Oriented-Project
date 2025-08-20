namespace FP
{
    partial class ProjectList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FLPanel
            // 
            this.FLPanel.AutoScroll = true;
            this.FLPanel.BackColor = System.Drawing.Color.White;
            this.FLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPanel.Location = new System.Drawing.Point(0, 0);
            this.FLPanel.Name = "FLPanel";
            this.FLPanel.Size = new System.Drawing.Size(899, 559);
            this.FLPanel.TabIndex = 0;
            this.FLPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPanel_Paint);
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLPanel);
            this.Name = "ProjectList";
            this.Size = new System.Drawing.Size(899, 559);
            this.Load += new System.EventHandler(this.ProjectList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPanel;
    }
}
