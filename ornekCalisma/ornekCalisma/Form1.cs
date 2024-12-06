using System;
using System.Windows.Forms;

namespace ornekCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            metot(true); 
        }

        
        private void metot(bool value)
        {
            if (value)
            {
                label1.Text = "Sayı Asaldır."; 
            }
            else
            {
                label1.Text = "Sayı Asal Değildir."; 
            }
        }
    }
}

