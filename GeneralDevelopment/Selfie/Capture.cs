using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;

namespace D365Selfie
{
    public partial class Capture : Form
    {
        public Capture()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearForm()
        {
            this.toolStripStatusLabelNotConnect.Text = "Clear Form";
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxPhone.Text = "";
            this.richTextBoxRegarding.Text = "";
            this.pictureBoxSelfie.InitialImage = null;
            this.pictureBoxSelfie.Image = null;
            this.toolStripStatusLabelNotConnect.Text = "Cleared Form";
        }

        private void Buttonclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ButtonTakeSelfie_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabelNotConnect.Text = "Smile for Camera";
            VideoCapture capture = new VideoCapture(); 
            Bitmap image = capture.QueryFrame().Bitmap; 
            pictureBoxSelfie.Image = image;
            this.toolStripStatusLabelNotConnect.Text = "We got a great shot! You take another";
            this.labelBanner.Visible = true;
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            Settings newSettingsFrom = new Settings();
            
            newSettingsFrom.Show();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.labelBanner.Visible = false;
            this.toolStripStatusLabelNotConnect.Text = "Build the Selfie";
            ISelfie selfie = new ISelfie();
            selfie.Firstname = this.textBoxFirstName.Text;
            selfie.Lastname = this.textBoxLastName.Text;
            selfie.Email = this.textBoxEmail.Text;
            selfie.Phone = this.textBoxPhone.Text;
            selfie.Regarding = this.richTextBoxRegarding.Text;
            selfie.Bitmap = new Bitmap(pictureBoxSelfie.Image);
            this.toolStripStatusLabelNotConnect.Text = "Connecting";
            selfie.Leadid = Program.SubmitSelfie(selfie);
            this.toolStripStatusLabelNotConnect.Text = selfie.Leadid.ToString();
            this.labelBanner.Text = "Submitted";
            this.labelBanner.Visible = false;
        }

        private void Capture_Load(object sender, EventArgs e)
        {
            this.textBoxFirstName.Text="Firstname";
            this.textBoxLastName.Text="Lastname";
            this.textBoxEmail.Text="username@domain.com";
            this.textBoxPhone.Text="5553341212";
            this.toolStripStatusLabelNotConnect.Text = "Getting Started";
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings newSettingsFrom = new Settings();
            newSettingsFrom.Show();
            this.toolStripStatusLabelNotConnect.Text = "Settings";
        }

        private void buttonClearSelfie_Click(object sender, EventArgs e)
        {
            this.pictureBoxSelfie.InitialImage = null;
            this.pictureBoxSelfie.Image = null;
            this.toolStripStatusLabelNotConnect.Text = "Form Cleared";
            this.labelBanner.Visible = false;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
