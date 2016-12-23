using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTread
{
    public partial class MultipleThreadWithThreadForm : Form
    {
        public MultipleThreadWithThreadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UseThread();
        }

        private void UseThread()
        {
            Thread t = new Thread(new ThreadStart(CostTimeOperation));
            t.Start();

        }

        /// <summary>
        /// sub thread operate UI thread
        /// </summary>
        private void CostTimeOperation()
        {
            for (int i = 0; i < 10; i++)
            {
                WriteTextBox(string.Format("Launch task {0}", i.ToString()));
                Thread.Sleep(1000);
            }
        }

        private delegate void SetTextDelegate(string text);
        private void WriteTextBox(string text)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new SetTextDelegate(WriteTextBox), new object[] { text });
                return;
            }
            textBox1.Text += text;
            textBox1.Text += "\r\n";
        }
    }
}
