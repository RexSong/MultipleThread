using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultipleTread
{
    public partial class SingleThreadForm : Form
    {
        public SingleThreadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SingleThread();

        }

        //Single Thread
        private void SingleThread()
        {
            for (int i = 0; i < 10; i++)
            {
                textBox1.Text += string.Format("Launch task {0}", i.ToString());
                textBox1.Text += "\r\n";
                Thread.Sleep(1000);
            }
        }
    }
}
