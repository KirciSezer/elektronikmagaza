using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezer_sınav_form
{
      public abstract class Elektronik
    {
        private string marka;
        private string model;
        private double fiyat;
        private int garanti;
        public string Marka
        {
            set { marka = value; }
            get { return marka; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public double Fiyat
        {
            set { fiyat = value; }
            get { return fiyat; }
        }
        public int Garanti
        {
            set { garanti = value; }
            get { return garanti; }
        }      
        public virtual double zam(double Fiyat,int adet)
        {
            return Fiyat;
        }
        public virtual void indirim(double Fiyat,int adet)
        {

        }

    }

}
