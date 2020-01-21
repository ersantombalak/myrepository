using NetOpenX50;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SirketlerArasiAktarim.Helpers
{
    class NetsisHelper : IDisposable
    {

        private static object _lockObject = new Object();
        private static volatile NetsisHelper _instance;
        private static volatile Kernel _kernel;
        private static volatile Sirket _kaynakSirket;
        private static volatile Sirket _hedefSirket;

        public static string kSirket;
        public static string hsirket;

        public static int kSubeKodu;
        public static int hSubeKodu;


        private NetsisHelper() { }

        public static NetsisHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new NetsisHelper();
                        }
                    }
                }

                return _instance;
            }
        }

        public Kernel Kernel
        {
            get
            {
                if (_kernel == null)
                {
                    lock (_lockObject)
                    {
                        if (_kernel == null)
                        {
                            //LogHelper.Info("NetOpenX50.Kernel objesi yaratiliyor.");
                            var stopwatch = Stopwatch.StartNew();
                            _kernel = new Kernel();
                            //LogHelper.Info("NetOpenX50.Kernel objesi yaratildi.", stopwatch.ElapsedMilliseconds);
                        }
                    }
                }

                return _kernel;
            }
        }

        public Sirket KaynakSirket
        {
            get
            {
                if (_kaynakSirket == null)
                {
                    lock (_lockObject)
                    {
                        if (_kaynakSirket == null)
                        {
                            //LogHelper.Info("NetOpenX50.Sirket objesi yaratiliyor.");
                            var stopwatch = Stopwatch.StartNew();
                            _kaynakSirket = default(Sirket);
                            _kaynakSirket = Kernel.yeniSirket(TVTTipi.vtMSSQL,
                                kSirket, Helpers.AppSettingsHelper.VTKulAdi, Helpers.AppSettingsHelper.VTKulSifre,
                                Helpers.AppSettingsHelper.VTNetKul, Helpers.AppSettingsHelper.VTNetSifre,
                                kSubeKodu);
                            //LogHelper.Info("NetOpenX50.Sirket objesi yaratildi.", stopwatch.ElapsedMilliseconds);
                        }
                    }
                }

                return _kaynakSirket;
            }
        }

        public Sirket HedefSirket
        {
            get
            {
                if (_hedefSirket == null)
                {
                    lock (_lockObject)
                    {
                        if (_hedefSirket == null)
                        {
                            //LogHelper.Info("NetOpenX50.Sirket objesi yaratiliyor.");
                            var stopwatch = Stopwatch.StartNew();
                            _hedefSirket = default(Sirket);
                            _hedefSirket = Kernel.yeniSirket(TVTTipi.vtMSSQL, hsirket
                                , Helpers.AppSettingsHelper.VTKulAdi, Helpers.AppSettingsHelper.VTKulSifre,
                                Helpers.AppSettingsHelper.VTNetKul, Helpers.AppSettingsHelper.VTNetSifre,
                                hSubeKodu);
                            //LogHelper.Info("NetOpenX50.Sirket objesi yaratildi.", stopwatch.ElapsedMilliseconds);
                        }
                    }
                }

                return _hedefSirket;
            }
        }

        public void Dispose()
        {
            if (_kaynakSirket != null)
            {
                //LogHelper.Info("NetOpenX50.Sirket objesi siliniyor.");
                Marshal.ReleaseComObject(_kaynakSirket);
                _kaynakSirket = null;
                //LogHelper.Info("NetOpenX50.Sirket objesi silindi.");
            }

            if (_hedefSirket != null)
            {
                //LogHelper.Info("NetOpenX50.Sirket objesi siliniyor.");
                Marshal.ReleaseComObject(_hedefSirket);
                _hedefSirket = null;
                //LogHelper.Info("NetOpenX50.Sirket objesi silindi.");
            }
            if (_kernel != null)
            {
                //LogHelper.Info("NetOpenX50.Kernel objesi siliniyor.");
                _kernel.FreeNetsisLibrary();
                Marshal.ReleaseComObject(_kernel);
                _kernel = null;
                //LogHelper.Info("NetOpenX50.Kernel objesi silindi.");
            }
            GC.SuppressFinalize(this);
        }

        ~NetsisHelper()
        {
            Dispose();
        }

    }
}
