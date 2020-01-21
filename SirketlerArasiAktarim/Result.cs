using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim
{
    public class Result
    {
        public Boolean IsSuccessful { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDesc { get; set; }
        public string SC_VERB_NO { get; set; }
    }
}
