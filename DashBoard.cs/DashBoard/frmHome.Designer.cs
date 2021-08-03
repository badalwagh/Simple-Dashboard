
namespace DashBoard
{
    partial class frmHome
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
            this.Homepage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Homepage)).BeginInit();
            this.SuspendLayout();
            // 
            // Homepage
            // 
            this.Homepage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Homepage.Image = global::DashBoard.Properties.Resources.attachment_107277414_removebg_preview;
            this.Homepage.Location = new System.Drawing.Point(0, -47);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(866, 596);
            this.Homepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Homepage.TabIndex = 2;
            this.Homepage.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(866, 549);
            this.Controls.Add(this.Homepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.Homepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Homepage;
    }
}