using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim.Helpers
{
    class AppSettingsHelper
    {
        public static string VTAdi { get { return ConfigurationManager.AppSettings.Get("vtAdi") ?? ""; } }

        public static string VTKulAdi { get { return ConfigurationManager.AppSettings.Get("vtKulAdi") ?? ""; } }

        public static string VTKulSifre { get { return ConfigurationManager.AppSettings.Get("vtKulSifre") ?? ""; } }

        public static string VTNetKul { get { return ConfigurationManager.AppSettings.Get("vtNetKul") ?? ""; } }

        public static string VTNetSifre { get { return ConfigurationManager.AppSettings.Get("vtNetSifre") ?? ""; } }

        public static int VTSubeKodu { get { return Convert.ToInt32(ConfigurationManager.AppSettings.Get("vtSubeKodu") ?? "0"); } }

        public static string Server { get { return ConfigurationManager.AppSettings.Get("server") ?? ""; } }

        public static string KullaniciAdi { get { return ConfigurationManager.AppSettings.Get("kullaniciAdi") ?? ""; } }

        public static string Sifre { get { return ConfigurationManager.AppSettings.Get("sifre") ?? ""; } }

        public static string ApiAdres { get { return ConfigurationManager.AppSettings.Get("apiAdres") ?? ""; } }

        public static string YaziciAdi { get { return ConfigurationManager.AppSettings.Get("yaziciAdi") ?? ""; } }

        public static string UpdateAdres { get { return ConfigurationManager.AppSettings.Get("updateAdres") ?? ""; } }

        public static string ConnStrAktarim { get { return "Data Source=192.168.0.20; Initial Catalog=SirketlerArasiAktarim; User Id=sa; Password=NET1neton"; } }
    }
}
