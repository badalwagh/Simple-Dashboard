
namespace DashBoard
{
    partial class frmAnalytics
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
            this.labelanalytics = new System.Windows.Forms.Label();
            this.iconPictureBoxanalytics = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxanalytics)).BeginInit();
            this.SuspendLayout();
            // 
            // labelanalytics
            // 
            this.labelanalytics.AutoSize = true;
            this.labelanalytics.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanalytics.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelanalytics.Location = new System.Drawing.Point(161, 111);
            this.labelanalytics.Name = "labelanalytics";
            this.labelanalytics.Size = new System.Drawing.Size(468, 48);
            this.labelanalytics.TabIndex = 0;
            this.labelanalytics.Text = "Your Analytics Here";
            // 
            // iconPictureBoxanalytics
            // 
            this.iconPictureBoxanalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBoxanalytics.ForeColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxanalytics.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconPictureBoxanalytics.IconColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxanalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxanalytics.IconSize = 200;
            this.iconPictureBoxanalytics.Location = new System.Drawing.Point(289, 208);
            this.iconPictureBoxanalytics.Name = "iconPictureBoxanalytics";
            this.iconPictureBoxanalytics.Size = new System.Drawing.Size(331, 198);
            this.iconPictureBoxanalytics.TabIndex = 1;
            this.iconPictureBoxanalytics.TabStop = false;
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.iconPictureBoxanalytics);
            this.Controls.Add(this.labelanalytics);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalytics";
            this.Text = "frmAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxanalytics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelanalytics;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxanalytics;
    }
}