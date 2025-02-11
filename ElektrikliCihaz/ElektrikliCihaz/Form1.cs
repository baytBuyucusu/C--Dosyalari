using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektrikliCihaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Cihaz cihaz = new Cihaz();

            cihaz.cihazAd=txtCihazAdi.Text;
            cihaz.cihazGuc=Convert.ToInt32(txtCihazGucu.Text);
            cihaz.kullanilanSure=Convert.ToDouble(txtKullanilanSaat.Text);

            lblAylikTuketim.Text = cihaz.TuketimYazdir();


        }
    }
}
