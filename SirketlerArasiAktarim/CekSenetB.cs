using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim
{
    public class CekSenetB
    {
        public Boolean OtoNumaraGetir { get; set; }
        public int CekSenEvrakKaydetmeTip { get; set; }
        public int Tip { get; set; }
        public string BordroNo { get; set; }
        public List<Evrak> Evraklar { get; set; }

    }

    public class BankaCekSenetB
    {
        public Boolean OtoNumaraGetir { get; set; }
        public int CekSenEvrakKaydetmeTip { get; set; }
        public int Tip { get; set; }
        public string BordroNo { get; set; }
        public List<BankaEvrak> Evraklar { get; set; }

    }
}
