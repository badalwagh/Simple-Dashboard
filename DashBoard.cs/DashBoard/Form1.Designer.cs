
namespace DashBoard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.Button5setting = new FontAwesome.Sharp.IconButton();
            this.Button4Contact = new FontAwesome.Sharp.IconButton();
            this.Button3Calender = new FontAwesome.Sharp.IconButton();
            this.Button2Analytics = new FontAwesome.Sharp.IconButton();
            this.Button1DashBoard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnldesktop = new System.Windows.Forms.Panel();
            this.Homepage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnldesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Homepage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.Button5setting);
            this.panel1.Controls.Add(this.Button4Contact);
            this.panel1.Controls.Add(this.Button3Calender);
            this.panel1.Controls.Add(this.Button2Analytics);
            this.panel1.Controls.Add(this.Button1DashBoard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 762);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 6;
            // 
            // Button5setting
            // 
            this.Button5setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button5setting.FlatAppearance.BorderSize = 0;
            this.Button5setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5setting.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button5setting.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.Button5setting.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.Button5setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button5setting.IconSize = 36;
            this.Button5setting.Location = new System.Drawing.Point(0, 710);
            this.Button5setting.Name = "Button5setting";
            this.Button5setting.Size = new System.Drawing.Size(220, 52);
            this.Button5setting.TabIndex = 5;
            this.Button5setting.Text = "Setting";
            this.Button5setting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button5setting.UseVisualStyleBackColor = true;
            this.Button5setting.Click += new System.EventHandler(this.Button5setting_Click);
            this.Button5setting.Leave += new System.EventHandler(this.Button5setting_Leave);
            // 
            // Button4Contact
            // 
            this.Button4Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button4Contact.FlatAppearance.BorderSize = 0;
            this.Button4Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4Contact.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button4Contact.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Button4Contact.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.Button4Contact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button4Contact.IconSize = 36;
            this.Button4Contact.Location = new System.Drawing.Point(0, 322);
            this.Button4Contact.Name = "Button4Contact";
            this.Button4Contact.Size = new System.Drawing.Size(220, 52);
            this.Button4Contact.TabIndex = 4;
            this.Button4Contact.Text = "Contact Us";
            this.Button4Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button4Contact.UseVisualStyleBackColor = true;
            this.Button4Contact.Click += new System.EventHandler(this.Button4Contact_Click);
            this.Button4Contact.Leave += new System.EventHandler(this.Button4Contact_Leave);
            // 
            // Button3Calender
            // 
            this.Button3Calender.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button3Calender.FlatAppearance.BorderSize = 0;
            this.Button3Calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3Calender.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3Calender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button3Calender.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.Button3Calender.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.Button3Calender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button3Calender.IconSize = 36;
            this.Button3Calender.Location = new System.Drawing.Point(0, 270);
            this.Button3Calender.Name = "Button3Calender";
            this.Button3Calender.Size = new System.Drawing.Size(220, 52);
            this.Button3Calender.TabIndex = 3;
            this.Button3Calender.Text = "Calender";
            this.Button3Calender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button3Calender.UseVisualStyleBackColor = true;
            this.Button3Calender.Click += new System.EventHandler(this.Button3Calender_Click);
            this.Button3Calender.Leave += new System.EventHandler(this.Button3Calender_Leave);
            // 
            // Button2Analytics
            // 
            this.Button2Analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button2Analytics.FlatAppearance.BorderSize = 0;
            this.Button2Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2Analytics.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2Analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button2Analytics.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.Button2Analytics.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.Button2Analytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button2Analytics.IconSize = 36;
            this.Button2Analytics.Location = new System.Drawing.Point(0, 218);
            this.Button2Analytics.Name = "Button2Analytics";
            this.Button2Analytics.Size = new System.Drawing.Size(220, 52);
            this.Button2Analytics.TabIndex = 2;
            this.Button2Analytics.Text = "Analytics\r\n";
            this.Button2Analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button2Analytics.UseVisualStyleBackColor = true;
            this.Button2Analytics.Click += new System.EventHandler(this.Button2Analytics_Click);
            this.Button2Analytics.Layout += new System.Windows.Forms.LayoutEventHandler(this.Button2Analytics_Layout);
            this.Button2Analytics.Leave += new System.EventHandler(this.Button2Analytics_Leave);
            // 
            // Button1DashBoard
            // 
            this.Button1DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button1DashBoard.FlatAppearance.BorderSize = 0;
            this.Button1DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1DashBoard.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1DashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button1DashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Button1DashBoard.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.Button1DashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button1DashBoard.IconSize = 36;
            this.Button1DashBoard.Location = new System.Drawing.Point(0, 166);
            this.Button1DashBoard.Name = "Button1DashBoard";
            this.Button1DashBoard.Size = new System.Drawing.Size(220, 52);
            this.Button1DashBoard.TabIndex = 1;
            this.Button1DashBoard.Text = "DashBoard";
            this.Button1DashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button1DashBoard.UseVisualStyleBackColor = true;
            this.Button1DashBoard.Click += new System.EventHandler(this.Button1DashBoard_Click);
            this.Button1DashBoard.Leave += new System.EventHandler(this.Button1DashBoard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 166);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(43, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnldesktop
            // 
            this.pnldesktop.Controls.Add(this.Homepage);
            this.pnldesktop.Controls.Add(this.label2);
            this.pnldesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnldesktop.Location = new System.Drawing.Point(220, 166);
            this.pnldesktop.Name = "pnldesktop";
            this.pnldesktop.Size = new System.Drawing.Size(884, 596);
            this.pnldesktop.TabIndex = 1;
            // 
            // Homepage
            // 
            this.Homepage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Homepage.Image = global::DashBoard.Properties.Resources.attachment_107277414_removebg_preview;
            this.Homepage.Location = new System.Drawing.Point(0, 0);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(884, 596);
            this.Homepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Homepage.TabIndex = 1;
            this.Homepage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(0, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(885, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.DarkViolet;
            this.Title.Location = new System.Drawing.Point(235, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(115, 36);
            this.Title.TabIndex = 2;
            this.Title.Text = "HOME";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.Search.ForeColor = System.Drawing.Color.Gray;
            this.Search.Location = new System.Drawing.Point(694, 41);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(301, 25);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search for something";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExit.ForeColor = System.Drawing.Color.Red;
            this.labelExit.Location = new System.Drawing.Point(1054, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(38, 36);
            this.labelExit.TabIndex = 4;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1104, 762);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pnldesktop);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnldesktop.ResumeLayout(false);
            this.pnldesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Homepage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Button5setting;
        private FontAwesome.Sharp.IconButton Button4Contact;
        private FontAwesome.Sharp.IconButton Button3Calender;
        private FontAwesome.Sharp.IconButton Button2Analytics;
        private FontAwesome.Sharp.IconButton Button1DashBoard;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnldesktop;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.PictureBox Homepage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelExit;
    }
}

