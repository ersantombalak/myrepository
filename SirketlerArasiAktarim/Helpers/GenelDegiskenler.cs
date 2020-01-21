using SirketlerArasiAktarim.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim
{
    class GenelDegiskenler
    {
        
        public static string connKaynak { get; set; }

        public static string TokenAl(string dbName)
        {
            try
            {
                HttpResponseMessage response;

                var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("grant_type", "password"),
                        new KeyValuePair<string, string>("branchcode", AppSettingsHelper.VTSubeKodu.ToString()) ,
                        new KeyValuePair<string, string>("password", AppSettingsHelper.VTNetSifre) ,
                        new KeyValuePair<string, string>("username", AppSettingsHelper.VTNetKul) ,
                        new KeyValuePair<string, string>("dbname", dbName) ,
                        new KeyValuePair<string, string>("dbuser", AppSettingsHelper.VTKulAdi) ,
                        new KeyValuePair<string, string>("dbpassword", AppSettingsHelper.VTKulSifre) ,
                        new KeyValuePair<string, string>("dbtype", "0")

                    });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(new Uri(AppSettingsHelper.ApiAdres), "api/v2/token");

                    response = client.PostAsync(client.BaseAddress.AbsoluteUri, formContent).Result;
                }

                var result = response.Content.ReadAsStringAsync().Result;

                response.Dispose();

                string asd = result.Split(',')[0];
                asd.Split(':');

                return asd.Split(':')[1].Trim('"');
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
