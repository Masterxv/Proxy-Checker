
using SocksSharp;
using SocksSharp.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyChecker
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        async void check()
        {
            int valid = 0;
            int invald = 0;
            foreach (string line in proxiesHere.Lines)
            {
                string[] proxylist = line.Split(new[] { ":" }, StringSplitOptions.None);

                string Host = proxylist[0];
                int Port = Convert.ToInt32(proxylist[1]);


                try
                {
                    IWebProxy proxy = new WebProxy(Host, Port);
                    HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://ip-api.com/xml/");
                    myWebRequest.Timeout = 10000;
                    myWebRequest.Proxy = proxy;
                    WebResponse response = myWebRequest.GetResponse();
                    valid += 1;
                    validInvalid.Text = @"VALID : " + valid + @"

INVALID : " + invald;
                    using StreamWriter file = new("VALID.txt", append: true);
                    await file.WriteLineAsync(line);
                }
                catch (Exception ex)
                {
                    invald += 1;
                    validInvalid.Text = @"VALID : " + valid + @"

INVALID : " + invald;
                    using StreamWriter File = new("INVALID.txt", append: true);
                    await File.WriteLineAsync(line);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proxiesType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proxiesType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < proxiesType.Items.Count; ++ix)
                if (ix != e.Index) proxiesType.SetItemChecked(ix, false);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Made by Nekyuu.

https://github.com/Nekyuuu");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            proxiesHere.Clear();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void scrapeProxies_Click(object sender, EventArgs e)
        {
            var url = "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=http&timeout=10000&country=all&ssl=all&anonymity=all";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                proxiesHere.Text = proxiesHere.Text + result.ToString();
            }

            Console.WriteLine(httpResponse.StatusCode);
        }

        private void validInvalid_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkButton_Click(object sender, EventArgs e)
        {
            check();
        }

        private void proxiesTimer_Tick(object sender, EventArgs e)
        {
        }

    }
}
