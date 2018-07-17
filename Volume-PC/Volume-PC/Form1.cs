using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_PC
{
    public partial class Form1 : Form
    {
        public static String url = "http://192.168.0.5/?status=";        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHarder_Click(object sender, EventArgs e)
        {
            sendStatus("harder");  
        }

        private void btnZachter_Click(object sender, EventArgs e)
        {
            sendStatus("zachter");
        }

        private void btnVeelharder_Click(object sender, EventArgs e)
        {
            sendStatus("nogharder");
        }        

        private void btnVeelzachter_Click(object sender, EventArgs e)
        {
            sendStatus("nogzachter");
        }

        public static void sendStatus(string status)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringAsync(new Uri(url + status));
        }

    }
}
