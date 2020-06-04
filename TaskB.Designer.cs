namespace laba4
{
    partial class TaskB
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
            this.picture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture1.Location = new System.Drawing.Point(0, 0);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(564, 572);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TaskB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(564, 572);
            this.Controls.Add(this.picture1);
            this.Name = "TaskB";
            this.Text = "TaskB";
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
    }
}