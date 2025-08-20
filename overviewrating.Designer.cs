namespace FP
{
    partial class overviewrating
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
            this.over_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // over_panel
            // 
            this.over_panel.Location = new System.Drawing.Point(3, 3);
            this.over_panel.Name = "over_panel";
            this.over_panel.Size = new System.Drawing.Size(829, 589);
            this.over_panel.TabIndex = 0;
            this.over_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.over_panel_Paint);
            // 
            // overviewrating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.over_panel);
            this.Name = "overviewrating";
            this.Size = new System.Drawing.Size(835, 592);
            this.Load += new System.EventHandler(this.overviewrating_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel over_panel;
    }
}
