using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim
{
    public class Evrak
    {
        
        public string Sube_Kodu { get; set; }
        public string SC_NO { get; set; }
        public string SC_ALB_NO { get; set; }
        public DateTime SC_GIRTRH { get; set; }
        public string SC_VERENK { get; set; }
        public string AS_C { get; set; }
        public string SC_ABORCLU { get; set; }
        public DateTime VADETRH { get; set; }
        public DateTime SC_ODETRH { get; set; }
        public string SC_YERI { get; set; }
        public string YERI { get; set; }
        public string CEK_SUBE { get; set; }
        public string CEK_IL { get; set; }
        public string CEK_ILCE { get; set; }
        public string PROJE_KODU { get; set; }
        public string Plasiyer_Kodu { get; set; }
        public Double Tutar { get; set; }
        public string Aciklama1 { get; set; }
        public string Aciklama2 { get; set; }
        public string Aciklama3 { get; set; }
        public string C_NUMARA { get; set; }
        public string IBANNO { get; set; }
        public string CEKSERI { get; set; }
        public int DOVTIP { get; set; }
        public double DOVTUT { get; set; }
    }

    public class BankaEvrak
    {
        public string Sube_Kodu { get; set; }
        public string SC_NO { get; set; }
        public string SC_ALB_NO { get; set; }
        public DateTime SC_CIKTRH { get; set; }
        public string SC_VERENK { get; set; }
        public string SC_VERILENK { get; set; }
        public string SC_VERB_NO { get; set; }
    }
    
}
