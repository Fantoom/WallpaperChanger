using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;
using System.Diagnostics;
namespace WallpaperChanger
{
    public partial class Form1 : Form
    {
        ContextMenu contextMenu1;
        MenuItem menuItem1;
        //private System.Windows.Forms.NotifyIcon notifyIcon;
        public Form1()
        {
            //notifyIcon = new System.Windows.Forms.NotifyIcon();
            InitializeComponent();
            type.SelectedIndex = 0;
            Program.selectedType = type.SelectedItem.ToString();
            Program.width = width.Text;
            Program.height = height.Text;
            Program.source = source.Text;
            Program.keywords = keywords.Text;
            timer1.Interval = int.Parse(TimerSec.Text) * 1000;
           
            if (saveImg.Checked)
            {
                Program.isSave = true;
            }
            else
            {
                Program.isSave = false;

            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                Program.isSave = true;
            }
            else {
                Program.isSave = false;

            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Program.changeWallpaper();

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.selectedType = type.SelectedItem.ToString();
            

        }

   



        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            Program.width = width.Text;
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            Program.height = height.Text;
        }

        private void source_TextChanged(object sender, EventArgs e)
        {
            Program.source = source.Text;
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void autoChange_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;

            }
        }

        private void keywords_TextChanged(object sender, EventArgs e)
        {
            Program.keywords = keywords.Text;
        }

        private void keywords_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.changeWallpaper();
        }

        private void TimerSec_TextChanged(object sender, EventArgs e)
        {
            if(TimerSec.Text.Length > 0) { 
                timer1.Interval = int.Parse(TimerSec.Text) * 1000;
            }
            else
            {
                TimerSec.Text = "5";
            }
            

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.Icon = new Icon("icon.ico");
                // notifyIcon.ShowBalloonTip(3000,"Title","Text");
                this.ShowInTaskbar = false;
                
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            

            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
          /*  contextMenu1 = new ContextMenu();
            menuItem1 = new MenuItem();

            this.contextMenu1.MenuItems.AddRange(
                    new System.Windows.Forms.MenuItem[] { this.menuItem1 });

            // Initialize menuItem1
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "E&xit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void menuItem1_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }
        public void UpdatePic(Image img) {
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void customImage_TextChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Program.GetImageByUrl(customImage.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void setCustomImg_Click(object sender, EventArgs e)
        {
            if (customImage.Text.Length > 5)
            {
                Program.SetCustomWallpaper(customImage.Text);
            }
            else
            {
                MetroMessageBox.Show(this,"Error","You didn't set a link",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Program.saveCurrent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Program.showNext();

        }

        private void setCurr_Click(object sender, EventArgs e)
        {
            Program.setCurrent();

        }

        private void folder_Click(object sender, EventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "saved");
        }
    }
}
