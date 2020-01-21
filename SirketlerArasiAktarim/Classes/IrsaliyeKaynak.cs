using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpenErp_Netsis_IrsaliyeOlustur.Classes
{

    public class IrsaliyeKaynakRoot
    {
        public bool IsSuccessful { get; set; }
        public IrsaliyeKaynak[] irsaliyeKaynak { get; set; }
    }

    public class IrsaliyeKaynak
    {
        public string SUBE_KODU { get; set; }
        public string FTIRSIP { get; set; }
        //public string FATIRS_NO { get; set; }
        //public string CARI_KODU { get; set; }
        //public DateTime TARIH { get; set; }
        //public string TIPI { get; set; }
        //public string BRUTTUTAR { get; set; }
        //public string SAT_ISKT { get; set; }
        //public string MFAZ_ISKT { get; set; }
        //public string GEN_ISK1O { get; set; }
        //public string GEN_ISK2O { get; set; }
        //public string GEN_ISK3O { get; set; }
        //public string KDV { get; set; }
        //public string FAT_ALTM1 { get; set; }
        //public string FAT_ALTM2 { get; set; }
        //public string KOD1 { get; set; }
        //public string ODEMEGUNU { get; set; }
        //public DateTime ODEMETARIHI { get; set; }
        //public string KDV_DAHILMI { get; set; }
        //public string GENELTOPLAM { get; set; }
        //public string YUVARLAMA { get; set; }
        //public string DOVIZTIP { get; set; }
        //public string DOVIZTUT { get; set; }
        //public string KS_KODU { get; set; }
        //public string STOK_KODU { get; set; }
        //public string STHAR_GCMIK { get; set; }
        //public string STHAR_GCMIK2 { get; set; }
        //public string CEVRIM { get; set; }
        //public string STHAR_GCKOD { get; set; }
        //public DateTime STHAR_TARIH { get; set; }
        //public string STHAR_BF { get; set; }
        //public string STHAR_KDV { get; set; }
        //public string STHAR_ACIKLAMA { get; set; }
        //public string STHAR_FTIRSIP { get; set; }
        //public string STHAR_HTUR { get; set; }
        //public string STHAR_DOVTIP { get; set; }
        //public string STHAR_DOVFIAT { get; set; }
        //public string OLCUBR { get; set; }
    }

    
}
