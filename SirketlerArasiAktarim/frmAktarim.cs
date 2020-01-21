using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using NetOpenX50;
using SirketlerArasiAktarim.Helpers;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SirketlerArasiAktarim
{
    public partial class frmAktarim : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtAktarim=new DataTable();

        Kernel kernel = NetsisHelper.Instance.Kernel;

        public frmAktarim()
        {
            InitializeComponent();

           
        }

        private void frmAktarim_Load(object sender, EventArgs e)
        {
            try
            {

                AktarimGetir();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            if (grdAktarimTanim.EditValue == null)
                return;

            try
            {
                dtAktarim.Clear();

                dtAktarim = AktarimGetirId((int)grdAktarimTanim.EditValue);


                string kaynakSirket = dtAktarim.Rows[0]["KaynakSirket"].ToString();
                string hedefSirket = dtAktarim.Rows[0]["HedefSirket"].ToString();
                string kBelgeTuru = dtAktarim.Rows[0]["KBelgeTuru"].ToString();
                string hBelgeTuru = dtAktarim.Rows[0]["HBelgeTuru"].ToString();
                Boolean kEArsivKontrol= Convert.ToBoolean(dtAktarim.Rows[0]["KEarsivKontrol"]);

                string sorgu = "";

                switch (kBelgeTuru)
                {
                    case "SatisIrsaliyesi":
                        sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, NETSIS.dbo.TRK(f.CARI_KODU) CARI_KODU, f.TARIH From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                        "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                        "Where FTIRSIP='3' and a.Id IS NULL";

                        grdAktarilacakFisler.MainView = VwIrsaliyeFatura;

                        break;
                    case "SatisFaturasi":

                        if (kEArsivKontrol==false)
                        {
                            sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, ERPEN.dbo.TRK(f.CARI_KODU) CARI_KODU, f.TARIH From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                          "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                          "Where FTIRSIP='1' and a.Id IS NULL";

                        }
                        else
                        {
                            sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, ERPEN.dbo.TRK(f.CARI_KODU) CARI_KODU, f.TARIH From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                          "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                          "Where FTIRSIP='1' and a.Id IS NULL and f.FATIRS_NO IN (SELECT FATIRS_NO FROM " + kaynakSirket + ".dbo.TBLEARSIV WHERE DURUM=2 AND FTIRSIP='1') ";
                        }
                       

                        grdAktarilacakFisler.MainView = VwIrsaliyeFatura;
                        break;

                    case "AlisIrsaliyesi":
                        sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, ERPEN.dbo.TRK(f.CARI_KODU) CARI_KODU, f.TARIH From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                        "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                        "Where FTIRSIP='4' and a.Id IS NULL";

                        grdAktarilacakFisler.MainView = VwIrsaliyeFatura;

                        break;
                    case "AlisFaturasi":
                        sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, ERPEN.dbo.TRK(f.CARI_KODU) CARI_KODU, f.TARIH From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                        "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                        "Where f.SUBE_KODU=0 AND FTIRSIP='2' and a.Id IS NULL";

                        grdAktarilacakFisler.MainView = VwIrsaliyeFatura;

                        break;
                }


                DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                grdAktarilacakFisler.DataSource = dt;


                sorgu = "Select * from TblAktarim Where AktarimTanimId=" + dtAktarim.Rows[0]["Id"];

                DataTable dtAktarilan = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                grdAktarilan.DataSource = dtAktarilan;

                vwAktarilan.BestFitColumns();

                btnDegistir.Visible = true;
                grdAktarimTanim.Enabled = false;
               

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);

            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            grdAktarimTanim.Enabled = true;
            btnDegistir.Visible = false;

            grdAktarilacakFisler.DataSource = null;
            grdAktarilan.DataSource = null;
        }

        private void mnSecilenleriAktar_Click(object sender, EventArgs e)
        {
            int[] selectedRows = VwIrsaliyeFatura.GetSelectedRows();


            NetsisHelper.Instance.Dispose();


            for (int i = 0; i < selectedRows.Length; i++)
            {
                int rowHandle = selectedRows[i];


                if (!VwIrsaliyeFatura.IsGroupRow(rowHandle))
                {
                    try
                    {


                        IrsaliyeFaturaAktar(VwIrsaliyeFatura.GetRowCellValue(rowHandle, "FATIRS_NO").ToString(), VwIrsaliyeFatura.GetRowCellValue(rowHandle, "CARI_KODU").ToString(), out string hedefBelgeNo, out string hedefCariKodu);

                        string sorgu = "Insert Into TblAktarim (AktarimTanimId, KaynakSirket, HedefSirket, KBelgeTuru, HBelgeTuru, KaynakFisNo, HedefFisNo, HedefCariKodu,  Tarih) " +
                            "Values (" + dtAktarim.Rows[0]["Id"] + ", '" + dtAktarim.Rows[0]["KaynakSirket"] + "', " +
                            "'" + dtAktarim.Rows[0]["HedefSirket"] + "', '" + dtAktarim.Rows[0]["KBelgeTuru"] + "', " +
                            "'" + dtAktarim.Rows[0]["HBelgeTuru"] + "', '" + VwIrsaliyeFatura.GetRowCellValue(rowHandle, "FATIRS_NO").ToString() + "', " +
                            "'" + hedefBelgeNo + "', '" + hedefCariKodu + "', GETDATE())";

                        SqlHelper.ExecuteNonQuery(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu);
                    }
                    catch (Exception ex)
                    {

                        XtraMessageBox.Show(ex.Message);
                    }

                }

            }
        }

        private void rdAktarim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                grdAktarimTanim.EditValue = null;
                AktarimGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void mnSeciliOlaniSil_Click(object sender, EventArgs e)
        {
            
            
            Fatura fatura = null;

            try
            {
                fatura = default(Fatura);

                //sirket = kernel.yeniSirket(TVTTipi.vtMSSQL,
                //                           vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "HedefSirket").ToString(),
                //                            AppSettingsHelper.VTKulAdi,
                //                            AppSettingsHelper.VTKulSifre,
                //                            AppSettingsHelper.VTNetKul,
                //                            AppSettingsHelper.VTNetSifre,
                //                            AppSettingsHelper.VTSubeKodu);

                TFaturaTip belge = TFaturaTip.ftSIrs;

                

                switch (vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "HBelgeTuru").ToString())
                {
                    case "SatisIrsaliyesi":
                        belge = TFaturaTip.ftSIrs;
                        break;
                    case "SatisFaturasi":
                        belge = TFaturaTip.ftSFat;
                        break;
                    case "AlisIrsaliyesi":
                        belge = TFaturaTip.ftAIrs;
                        break;
                    case "AlisFaturasi":
                        belge = TFaturaTip.ftAFat;
                        break;
                }

                NetsisHelper.hsirket = vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "HedefSirket").ToString();

                fatura = kernel.yeniFatura(NetsisHelper.Instance.HedefSirket, belge);
                fatura.OkuUst(vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "HedefFisNo").ToString(), vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "HedefCariKodu").ToString());
                fatura.OkuKalem();
                fatura.kayitSil();


                string sorgu = "Delete From TblAktarim Where Id=" + vwAktarilan.GetRowCellValue(vwAktarilan.FocusedRowHandle, "Id");

                SqlHelper.ExecuteNonQuery(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu);

                vwAktarilan.DeleteRow(vwAktarilan.FocusedRowHandle);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(fatura);           
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AktarimGetir()
        {
            try
            {
                string sorgu = "Select Id, Aciklama, KaynakSirket, HedefSirket, KBelgeTuru KaynakSirketBelgeTuru, HBelgeTuru HedefSirketBelgeTuru From TblAktarimTanim " +
                "Where Aktifmi='True'";

                DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];


                grdAktarimTanim.Properties.ValueMember = "Id";
                grdAktarimTanim.Properties.DisplayMember = "Aciklama";

                grdAktarimTanim.Properties.DataSource = dt;

            }
            catch (Exception)
            {

                throw;

            }
        }

        private DataTable AktarimGetirId(int id)
        {
            try
            {
                string sorgu = "Select * From VwAktarimTanim Where Id=" + id;

                DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                return dt;
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void IrsaliyeFaturaAktar(string fisNo, string cariKodu, out string hedefBelgeNo, out string hedefCariKodu)
        {

            hedefBelgeNo = "";
            hedefCariKodu = "";

            Fatura kaynakFatura = null;
            FatUst kaynakFatUst = null;
            FatKalem kaynakFatKalem = null;

            Fatura hedefFatura = null;
            FatUst hedefFatUst = null;
            FatKalem hedefFatKalem = null;

            try
            {
                kaynakFatura = default(Fatura);
                kaynakFatUst = default(FatUst);
                kaynakFatKalem = default(FatKalem);

                hedefFatura = default(Fatura);
                hedefFatUst = default(FatUst);
                hedefFatKalem = default(FatKalem);

                TFaturaTip kaynakBelge = TFaturaTip.ftSIrs;
                TFaturaTip hedefBelge = TFaturaTip.ftSIrs;

                switch (dtAktarim.Rows[0]["KBelgeTuru"].ToString())
                {
                    case "SatisIrsaliyesi":
                        kaynakBelge = TFaturaTip.ftSIrs;
                        break;
                    case "SatisFaturasi":
                        kaynakBelge = TFaturaTip.ftSFat;
                        break;
                    case "AlisIrsaliyesi":
                        kaynakBelge = TFaturaTip.ftAIrs;
                        break;
                    case "AlisFaturasi":
                        kaynakBelge = TFaturaTip.ftAFat;
                        break;
                }

                switch (dtAktarim.Rows[0]["HBelgeTuru"].ToString())
                {
                    case "SatisIrsaliyesi":
                        hedefBelge = TFaturaTip.ftSIrs;
                        break;
                    case "SatisFaturasi":
                        hedefBelge = TFaturaTip.ftSFat;
                        break;
                    case "AlisIrsaliyesi":
                        hedefBelge = TFaturaTip.ftAIrs;
                        break;
                    case "AlisFaturasi":
                        hedefBelge = TFaturaTip.ftAFat;
                        break;
                }

                NetsisHelper.kSirket = dtAktarim.Rows[0]["KaynakSirket"].ToString();
                NetsisHelper.hsirket = dtAktarim.Rows[0]["HedefSirket"].ToString();

                NetsisHelper.kSubeKodu = Convert.ToInt16(VwIrsaliyeFatura.GetRowCellValue(VwIrsaliyeFatura.FocusedRowHandle, "SUBE_KODU"));
                NetsisHelper.hSubeKodu = 0;

                kaynakFatura = NetsisHelper.Instance.Kernel.yeniFatura(NetsisHelper.Instance.KaynakSirket, kaynakBelge);
                kaynakFatura.OkuUst(fisNo, cariKodu);
                kaynakFatUst = kaynakFatura.Ust();

                hedefFatura = NetsisHelper.Instance.Kernel.yeniFatura(NetsisHelper.Instance.HedefSirket, hedefBelge);
                hedefFatUst = hedefFatura.Ust();


                if ((Boolean)dtAktarim.Rows[0]["AyniCariKoduKullan"] == true)
                {

                    hedefFatUst.CariKod = kaynakFatUst.CariKod;
                    hedefCariKodu = kaynakFatUst.CariKod;
                }
                else
                {
                    hedefCariKodu = CariKoduAl();
                    hedefFatUst.CariKod = hedefCariKodu;

                }


                if ((Boolean)dtAktarim.Rows[0]["AyniBelgeNoKullan"] == true)
                {
                    hedefFatUst.FATIRS_NO = kaynakFatUst.FATIRS_NO;
                    hedefBelgeNo = kaynakFatUst.FATIRS_NO;

                }
                else
                {
                    string yeniNo = hedefFatura.YeniNumara("");
                    hedefFatUst.FATIRS_NO = yeniNo;
                    hedefBelgeNo = yeniNo;
                }

                hedefFatUst.Tarih = kaynakFatUst.Tarih;
                //hedefFatUst.Proje_Kodu = kaynakFatUst.Proje_Kodu;
                hedefFatUst.TIPI = kaynakFatUst.TIPI;
                hedefFatUst.EXPORTTYPE = kaynakFatUst.EXPORTTYPE;
                hedefFatUst.SIPARIS_TEST = kaynakFatUst.SIPARIS_TEST;
                hedefFatUst.KOD1 = kaynakFatUst.KOD1;
                hedefFatUst.Proje_Kodu = dtAktarim.Rows[0]["HProjeKodu"].ToString();

                hedefFatUst.GEN_ISK1O = kaynakFatUst.GEN_ISK1O;
                hedefFatUst.GEN_ISK2O = kaynakFatUst.GEN_ISK2O;
                hedefFatUst.GEN_ISK3O = kaynakFatUst.GEN_ISK3O;


                kaynakFatura.OkuKalem();

                for (int i = 0; i < kaynakFatura.KalemAdedi; i++)
                {


                    kaynakFatKalem = kaynakFatura.get_Kalem(i);

                    hedefFatKalem = hedefFatura.kalemYeni(kaynakFatKalem.StokKodu);

                    hedefFatKalem.ProjeKodu = dtAktarim.Rows[0]["HProjeKodu"].ToString();

                    hedefFatKalem.STra_GCMIK = kaynakFatKalem.STra_GCMIK;
                    hedefFatKalem.STra_GCMIK2 = kaynakFatKalem.STra_GCMIK2;
                    hedefFatKalem.CEVRIM = kaynakFatKalem.CEVRIM;
                    hedefFatKalem.Olcubr = kaynakFatKalem.Olcubr;
                    hedefFatKalem.STra_TAR = kaynakFatKalem.STra_TAR;
                    hedefFatKalem.STra_NF = kaynakFatKalem.STra_NF;
                    hedefFatKalem.STra_BF = kaynakFatKalem.STra_BF;
                    hedefFatKalem.STra_IAF = kaynakFatKalem.STra_IAF;
                    hedefFatKalem.STra_KDV = kaynakFatKalem.STra_KDV;
                    //hedefFatKalem.DEPO_KODU = kaynakFatKalem.DEPO_KODU;
                    hedefFatKalem.Stra_Exportmik = kaynakFatKalem.Stra_Exportmik;
                    
                    if (Convert.ToInt16(dtAktarim.Rows[0]["HDepoKodu"]) != 0)
                    {
                        hedefFatKalem.DEPO_KODU = Convert.ToInt32(dtAktarim.Rows[0]["HDepoKodu"]);
                    }

                    hedefFatKalem.Listeno = kaynakFatKalem.Listeno;
                    hedefFatKalem.STra_DOVTIP = kaynakFatKalem.STra_DOVTIP;

                    if ((Boolean)dtAktarim.Rows[0]["HedefFiyatFarkli"] == true)
                    {
                        hedefFatKalem.STra_DOVFIAT = kaynakFatKalem.STra_DOVFIAT + Convert.ToDouble(dtAktarim.Rows[0]["HedefFiyatFark"]);
                    }
                    else
                    {
                        hedefFatKalem.STra_DOVFIAT = kaynakFatKalem.STra_DOVFIAT;
                    }


                    hedefFatKalem.DOVTIP = kaynakFatKalem.DOVTIP;
                    hedefFatKalem.STra_SatIsk = kaynakFatKalem.STra_SatIsk;
                    hedefFatKalem.STra_SatIsk2 = kaynakFatKalem.STra_SatIsk2;
                    hedefFatKalem.STra_SatIsk3 = kaynakFatKalem.STra_SatIsk3;
                }

                hedefFatura.kayitYeni();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                Marshal.ReleaseComObject(kaynakFatKalem);
                Marshal.ReleaseComObject(hedefFatKalem);

                Marshal.ReleaseComObject(kaynakFatUst);
                Marshal.ReleaseComObject(hedefFatUst);

                Marshal.ReleaseComObject(kaynakFatura);
                Marshal.ReleaseComObject(hedefFatura);

            }
        }

        private string CariKoduAl()
        {
            return "";
        }

        private string StokKoduAl()
        {
            return "";
        }

    }
}