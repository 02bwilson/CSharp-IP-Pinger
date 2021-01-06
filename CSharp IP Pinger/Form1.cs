using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace CSharp_IP_Pinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(textBox1.Text, 1000);
                MessageBox.Show(reply.Status.ToString(), "IP Valid, Pinging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("NOT VALID", "IP Not Valid, ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
      
    }
}
