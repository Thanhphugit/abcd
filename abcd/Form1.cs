using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsoa.Text != String.Empty) ;
            int a, b, kq;
            a = int.Parse(txtsoa.Text);
            b = int.Parse(txtsob.Text);
            kq = a + b;
            txtkq.Text=kq.ToString();    
        }
    }
}
