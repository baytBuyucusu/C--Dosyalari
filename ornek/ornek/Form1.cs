using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<int> queue = new Queue<int>();
        int sayac = 1;

      

        private void button4_Click(object sender, EventArgs e)
        {
            queue.Enqueue(sayac);
            label1.Text = sayac.ToString();
            sayac++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = SiraCagir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = SiraCagir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = SiraCagir();
        }


        private string SiraCagir()
        {
            if (queue.Count > 0)
            {
                string sira = queue.Dequeue().ToString(); //Kuyruktan önce girilen değeri kaldırdık.
                return sira;
            }
            else
            {
                return "--";
            }

        }
    }
}
