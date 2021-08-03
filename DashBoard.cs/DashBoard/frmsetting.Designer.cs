
namespace DashBoard
{
    partial class frmsetting
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelanalytics
            // 
            this.labelanalytics.AutoSize = true;
            this.labelanalytics.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanalytics.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelanalytics.Location = new System.Drawing.Point(186, 84);
            this.labelanalytics.Name = "labelanalytics";
            this.labelanalytics.Size = new System.Drawing.Size(483, 48);
            this.labelanalytics.TabIndex = 3;
            this.labelanalytics.Text = "Your Setting Is Here";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconPictureBox1.IconColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 248;
            this.iconPictureBox1.Location = new System.Drawing.Point(283, 203);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(277, 248);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelanalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsetting";
            this.Text = "frmsetting";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelanalytics;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}