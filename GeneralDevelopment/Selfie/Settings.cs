using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D365Selfie
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            IAppConfig ac = Program.GetAppConfig(); ;

            this.textBoxAuthType.Text = ac.AuthType;
            this.textBoxDomain.Text = ac.Domain;
            this.textBoxServerUrl.Text = ac.ServerUrl;
            this.textBoxUserName.Text = ac.UserName;
            this.textBoxPassword.Text = ac.Password;


        }
    }
}
