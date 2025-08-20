namespace FP
{
    partial class ListofFreelancer
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
            this.FlPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlPanel1
            // 
            this.FlPanel1.AutoScroll = true;
            this.FlPanel1.BackColor = System.Drawing.Color.White;
            this.FlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlPanel1.Name = "FlPanel1";
            this.FlPanel1.Size = new System.Drawing.Size(1000, 647);
            this.FlPanel1.TabIndex = 0;
            this.FlPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlPanel1_Paint);
            // 
            // ListofFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlPanel1);
            this.Name = "ListofFreelancer";
            this.Size = new System.Drawing.Size(1000, 647);
            this.Load += new System.EventHandler(this.ListofFreelancer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlPanel1;
    }
}
