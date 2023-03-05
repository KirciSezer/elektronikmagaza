using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezer_sınav_form
{
    class telefon:Elektronik
    {
       
        public double kameracözünürlügü;      
        public string parmakokutmadurumu;
        public void ozellik()
        {
         
           
        
        }
        public double Döndür(Double Fiyat)
        {
            if (kameracözünürlügü > 13 && parmakokutmadurumu == "evet")
            {
                Fiyat += 100;
                return Fiyat;
            }
            else
            {
                return Fiyat;
            }
        }

    }
}
