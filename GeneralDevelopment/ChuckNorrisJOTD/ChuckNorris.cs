using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisJOTD;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;

namespace ChuckNorrisJOTD
{
    [System.Runtime.InteropServices.Guid("590E7B72-66B6-4B08-B8A7-BA8A2BFBA8FC")]
    public partial class ChuckNorris : Form
    {
        public ChuckNorris()
        {
            InitializeComponent();
        }

        private void ChuckNorris_Load(object sender, EventArgs e)
        {
            Joke _joke = Program.GetRandomJoke();
            richTextBox1.Text = _joke.joke;
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            Joke _joke = Program.GetRandomJoke();
            richTextBox1.Text = _joke.joke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}






