using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezer_sınav_form
{
   
    class beyazesya : Elektronik
    {
     
        public string beyazesyaadi;
        public double enerjigücü;
        public double vergioranı;
        public double Zam;
        public int adet;

        public override double zam(double Fiyat,int adet)
        {   Form4 git = new Form4();            
            double sonuc = ((Fiyat * Zam) + Fiyat) * adet;
            return sonuc;
        }

    }
}
