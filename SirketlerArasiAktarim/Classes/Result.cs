using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpenErp_Netsis_IrsaliyeOlustur.Classes
{
   
    public class Result
    {
        public Boolean IsSuccessful { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDesc { get; set; }
        public string FATIRS_NO { get; set; }
        public List<Siparis> Data { get; set; }
    }
}
