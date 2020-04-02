using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Windows.Forms;
using WebSocketSharp;
using System.IO;
//using ModReguestWebsocket;


namespace ModReguestWebsocket
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void But_pick_pair_click(object sender, EventArgs e)
        {
            
        }

        private void But_start_request_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream strm = client.OpenRead("https://www.binance.com/api/v1/aggTrades?limit=80&symbol=BTCUSDT");
            StreamReader sr = new StreamReader(strm);
            string line = string.Empty;
            string message = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                message += line;
            }
                       

            textBox_data_websocket.Text += Environment.NewLine + message.ToString();

            // textBox_data_websocket.Text = + Environment.NewLine}


        }

        private void textBox_data_websocket_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
