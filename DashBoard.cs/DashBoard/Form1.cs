using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace DashBoard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthRect,
            int nHeightRect
         );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = Button1DashBoard.Height;
            pnlNav.Top = Button1DashBoard.Top;
            pnlNav.Left = Button1DashBoard.Left;
            Button1DashBoard.BackColor = Color.FromArgb(46, 51, 73);


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1DashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Button1DashBoard.Height;
            pnlNav.Top = Button1DashBoard.Top;
            pnlNav.Left = Button1DashBoard.Left;
            Button1DashBoard.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "DashBoard";
            this.pnldesktop.Controls.Clear();
            frmDashBoard FrmDashboard_vrb = new frmDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(FrmDashboard_vrb);
            FrmDashboard_vrb.Show();
        }

        private void Button2Analytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height =Button2Analytics.Height;
            pnlNav.Top = Button2Analytics.Top;
            Button2Analytics.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Analytics";
            this.pnldesktop.Controls.Clear();
            frmAnalytics Frmanalytics_vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmanalytics_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(Frmanalytics_vrb);
            Frmanalytics_vrb.Show();

        }

        private void Button3Calender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Button3Calender.Height;
            pnlNav.Top = Button3Calender.Top;
            Button3Calender.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Calender";
            this.pnldesktop.Controls.Clear();
            frmCalender Frmcalender_vrb = new frmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmcalender_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(Frmcalender_vrb);
            Frmcalender_vrb.Show();

        }

        private void Button4Contact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Button4Contact.Height;
            pnlNav.Top = Button4Contact.Top;
            Button4Contact.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Contact Us";
            this.pnldesktop.Controls.Clear();
            FrmContact Frmcontact_vrb = new FrmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmcontact_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(Frmcontact_vrb);
            Frmcontact_vrb.Show();
        }

        private void Button5setting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Button5setting.Height;
            pnlNav.Top = Button5setting.Top;
            Button5setting.BackColor = Color.FromArgb(46, 51, 73);

            Title.Text = "Setting";
            this.pnldesktop.Controls.Clear();
            frmsetting Frmsetting_vrb = new frmsetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmsetting_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(Frmsetting_vrb);
            Frmsetting_vrb.Show();
        }

        private void Button1DashBoard_Leave(object sender, EventArgs e)
        {
            Button1DashBoard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Button2Analytics_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Button2Analytics_Leave(object sender, EventArgs e)
        {
            Button2Analytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Button3Calender_Leave(object sender, EventArgs e)
        {
            Button3Calender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Button4Contact_Leave(object sender, EventArgs e)
        {
            Button4Contact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Button5setting_Leave(object sender, EventArgs e)
        {
            Button5setting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Title.Text = "Home";
            this.pnldesktop.Controls.Clear();
            frmHome Frmhome_vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmhome_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnldesktop.Controls.Add(Frmhome_vrb);
            Frmhome_vrb.Show();
        }
    }
}
