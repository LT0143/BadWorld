using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BadWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "bad1.txt";
            FoundationHelper.FilterWord filter = new FoundationHelper.FilterWord(path);
            filter.SourctText = textBox1.Text.Replace(" ","");
            string msg = filter.Filter('*');
            MessageBox.Show(msg);
        }
    }
}
