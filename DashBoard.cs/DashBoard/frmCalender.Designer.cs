
namespace DashBoard
{
    partial class frmCalender
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
            this.iconPictureBoxcalender = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxcalender)).BeginInit();
            this.SuspendLayout();
            // 
            // labelanalytics
            // 
            this.labelanalytics.AutoSize = true;
            this.labelanalytics.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanalytics.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelanalytics.Location = new System.Drawing.Point(189, 80);
            this.labelanalytics.Name = "labelanalytics";
            this.labelanalytics.Size = new System.Drawing.Size(462, 48);
            this.labelanalytics.TabIndex = 2;
            this.labelanalytics.Text = "Your Calender Here";
            // 
            // iconPictureBoxcalender
            // 
            this.iconPictureBoxcalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBoxcalender.ForeColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxcalender.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBoxcalender.IconColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxcalender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxcalender.IconSize = 217;
            this.iconPictureBoxcalender.Location = new System.Drawing.Point(296, 182);
            this.iconPictureBoxcalender.Name = "iconPictureBoxcalender";
            this.iconPictureBoxcalender.Size = new System.Drawing.Size(246, 217);
            this.iconPictureBoxcalender.TabIndex = 3;
            this.iconPictureBoxcalender.TabStop = false;
            // 
            // frmCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.iconPictureBoxcalender);
            this.Controls.Add(this.labelanalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalender";
            this.Text = "frmCalender";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxcalender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelanalytics;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxcalender;
    }
}