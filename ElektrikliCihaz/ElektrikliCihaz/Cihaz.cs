using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektrikliCihaz
{
    public class Cihaz
    {
        public string cihazAd;
        public double kullanilanSure;
        public int cihazGuc;

        public double AylikTuketimHesapla()
        {
            double tutar = kullanilanSure * cihazGuc / 1000 * 2.07 * 30;
            return tutar;
        }

        public double GunlukTuketimHesapla()
        {
            return kullanilanSure * cihazGuc * 2.07;
        }

        public string TuketimYazdir()
        {
            double tuketimMiktar = kullanilanSure * cihazGuc / 1000*30;
            double odenecekTutar = tuketimMiktar*2.07;

            string ozet = $"Bu ayki tüketim miktarınız:{tuketimMiktar} " +
                $"KWh\nÖdenek Tutar:{odenecekTutar} ₺";
            return ozet;
        }



    }
}
