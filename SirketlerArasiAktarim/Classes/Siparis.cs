using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpenErp_Netsis_IrsaliyeOlustur.Classes
{
    public class Siparis
    {
        public string SUBE_KODU { get; set; }
        public string FATIRS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string CARI_KODU { get; set; }
        public string CARI_KOD2 { get; set; }
        public decimal BRUTTUTAR { get; set; }
        public decimal GEN_ISK1O { get; set; }
        public decimal GEN_ISK2O { get; set; }
        public decimal GEN_ISK3O { get; set; }
        public string KOSULKODU { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
