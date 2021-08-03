
namespace DashBoard
{
    partial class FrmContact
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
            this.iconPictureBoxcontact = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxcontact)).BeginInit();
            this.SuspendLayout();
            // 
            // labelanalytics
            // 
            this.labelanalytics.AutoSize = true;
            this.labelanalytics.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelanalytics.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelanalytics.Location = new System.Drawing.Point(178, 102);
            this.labelanalytics.Name = "labelanalytics";
            this.labelanalytics.Size = new System.Drawing.Size(503, 48);
            this.labelanalytics.TabIndex = 1;
            this.labelanalytics.Text = "Your Contact Us Here";
            // 
            // iconPictureBoxcontact
            // 
            this.iconPictureBoxcontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconPictureBoxcontact.ForeColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxcontact.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBoxcontact.IconColor = System.Drawing.Color.LavenderBlush;
            this.iconPictureBoxcontact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxcontact.IconSize = 210;
            this.iconPictureBoxcontact.Location = new System.Drawing.Point(296, 204);
            this.iconPictureBoxcontact.Name = "iconPictureBoxcontact";
            this.iconPictureBoxcontact.Size = new System.Drawing.Size(263, 210);
            this.iconPictureBoxcontact.TabIndex = 2;
            this.iconPictureBoxcontact.TabStop = false;
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.iconPictureBoxcontact);
            this.Controls.Add(this.labelanalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContact";
            this.Text = "FrmContact";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxcontact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelanalytics;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxcontact;
    }
}