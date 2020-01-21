using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using SirketlerArasiAktarim.Helpers;
using NetOpenX50;
using System.Runtime.InteropServices;
using System.Net.Http;
using Newtonsoft.Json;

namespace SirketlerArasiAktarim
{
    public partial class frmCekSenetAktarim : DevExpress.XtraEditors.XtraForm
    {
        public frmCekSenetAktarim()
        {
            InitializeComponent();
        }

        DataTable dtAktarim = new DataTable();
        

        private void frmCekSenetAktarim_Load(object sender, EventArgs e)
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

        string kaynakSirket;
        string hedefSirket;
        string kBelgeTuru;
        string hBelgeTuru;

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (grdAktarimTanim.EditValue == null)
                return;

            try
            {
                dtAktarim.Clear();

                dtAktarim = AktarimGetirId((int)grdAktarimTanim.EditValue);


                kaynakSirket = dtAktarim.Rows[0]["KaynakSirket"].ToString();
                hedefSirket = dtAktarim.Rows[0]["HedefSirket"].ToString();
                kBelgeTuru = dtAktarim.Rows[0]["KBelgeTuru"].ToString();
                hBelgeTuru = dtAktarim.Rows[0]["HBelgeTuru"].ToString();
                

                string sorgu = "";

                switch (kBelgeTuru)
                {

                     //sorgu = "Select f.SUBE_KODU, f.FTIRSIP, f.FATIRS_NO, ERPEN.dbo.TRK(f.CARI_KODU) CARI_KODU, ERPEN.dbo.TRK(c.CARI_ISIM) CARI_ISIM, f.TARIH " +
                     //   "From " + kaynakSirket + ".dbo.TBLFATUIRS f " +
                     //   "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=f.FATIRS_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                     //   "Left JOIN " + kaynakSirket + ".dbo.TBLCASABIT c on c.CARI_KOD=f.CARI_KODU " +
                     //   "Where FTIRSIP='3' and a.Id IS NULL";

                    case "MusteriCeki":

                        sorgu = "select m.SC_ALB_NO, m.SC_GIRTRH, m.SC_VERENK AS CARI_KODU, " + kaynakSirket + ".dbo.TRK(CARI_ISIM) CARI_ISIM, SUM(CONVERT(FLOAT,m.TUTAR)) TUTAR, " +
                            "m.DOVTIP, SUM(CONVERT(FLOAT,m.DOVTUT)) DOVTUT, m.PROJE_KODU, COUNT(m.SC_NO) Adet " +
                            "From " + kaynakSirket + ".dbo.TBLMCEK m " +
                            "Left Join " + kaynakSirket + ".dbo.TBLCASABIT C ON C.CARI_KOD=SC_VERENK " +
                            "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=m.SC_ALB_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                            "Where a.Id IS NULL and m.SUBE_KODU=0 AND m.SC_NO IN (SELECT EvrakNo From ERPEN.dbo._evrakKAyit Where A3R='R' And EvrakTuru='Çek')" +
                            "group by m.SC_ALB_NO, m.SC_GIRTRH, m.SC_VERENK, m.DOVTIP, m.PROJE_KODU, " + kaynakSirket + ".dbo.TRK(CARI_ISIM) order by m.SC_GIRTRH";

                        grdAktarilacakFisler.MainView = VwIrsaliyeFatura;

                        break;
                    case "MusteriSeneti":
                        sorgu = "select m.SC_ALB_NO, m.SC_GIRTRH, m.SC_VERENK AS CARI_KODU, " + kaynakSirket + ".dbo.TRK(CARI_ISIM) CARI_ISIM, SUM(CONVERT(FLOAT,m.TUTAR)) TUTAR, " +
                            "m.DOVTIP, SUM(CONVERT(FLOAT,m.DOVTUT)) DOVTUT, m.PROJE_KODU, COUNT(m.SC_NO) Adet " +
                            "From " + kaynakSirket + ".dbo.TBLMSEN m " +
                            "Left Join " + kaynakSirket + ".dbo.TBLCASABIT C ON C.CARI_KOD=SC_VERENK " +
                            "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KaynakFisNo=m.SC_ALB_NO and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "'" +
                            "WHERE a.Id IS NULL and m.SUBE_KODU=0 AND m.SC_NO IN (SELECT EvrakNo From ERPEN.dbo._evrakKAyit Where A3R='R' And EvrakTuru='Senet')" +
                            "group by m.SC_ALB_NO, m.SC_GIRTRH, m.SC_VERENK, m.DOVTIP, m.PROJE_KODU, " + kaynakSirket + ".dbo.TRK(CARI_ISIM) order by m.SC_GIRTRH";

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
                        CekSenetAktar(VwIrsaliyeFatura.GetRowCellValue(rowHandle, "SC_ALB_NO").ToString(), VwIrsaliyeFatura.GetRowCellValue(rowHandle, "CARI_KODU").ToString(), out string hedefBelgeNo, out string hedefCariKodu);

                        string sorgu = "Insert Into TblAktarim (AktarimTanimId, KaynakSirket, HedefSirket, KBelgeTuru, HBelgeTuru, KaynakFisNo, HedefFisNo, HedefCariKodu,  Tarih) " +
                            "Values (" + dtAktarim.Rows[0]["Id"] + ", '" + dtAktarim.Rows[0]["KaynakSirket"] + "', " +
                            "'" + dtAktarim.Rows[0]["HedefSirket"] + "', '" + dtAktarim.Rows[0]["KBelgeTuru"] + "', " +
                            "'" + dtAktarim.Rows[0]["HBelgeTuru"] + "', '" + VwIrsaliyeFatura.GetRowCellValue(rowHandle, "SC_ALB_NO").ToString() + "', " +
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

        private void AktarimGetir()
        {
            try
            {
                string sorgu = "Select Id, Aciklama, KaynakSirket, HedefSirket, KBelgeTuru KaynakSirketBelgeTuru, HBelgeTuru HedefSirketBelgeTuru From TblAktarimTanim " +
                "Where Aktifmi='True' and BelgeTuru='CekSenet'";

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

        private void CekSenetAktar(string alindiBordroNo, string veren, out string hedefBelgeNo, out string hedefCariKodu)
        {
            hedefBelgeNo = "";
            hedefCariKodu = "";

            string tabloAdi = kBelgeTuru == "MusteriSeneti" ? "TBLMSEN" : "TBLMCEK";

            string sorgu = "Select * From " + kaynakSirket + ".dbo." + tabloAdi + " Where SUBE_KODU=0 AND SC_VERENK='" + veren + "' AND SC_ALB_NO='" + alindiBordroNo + "'"; // And SC_SONDUR = 'B' and SC_YERI = 'T'";

            DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

            string token = "";

            try
            {
                token = GenelDegiskenler.TokenAl(hedefSirket);

                if (dt.Rows.Count > 0)
                {
                    HttpResponseMessage response;

                    CekSenetB cekSenet = new CekSenetB();

                    cekSenet.Evraklar = new List<Evrak>();

                    foreach (DataRow item in dt.Rows)
                    {
                        Evrak evrak = new Evrak();
                        evrak.Sube_Kodu = "0"; //AppSettingsHelper.VTSubeKodu.ToString();
                        evrak.SC_NO = item["SC_NO"].ToString();
                        evrak.SC_ALB_NO = item["SC_ALB_NO"].ToString();
                        evrak.SC_GIRTRH = (DateTime)item["SC_GIRTRH"];
                        evrak.SC_VERENK = item["SC_VERENK"].ToString();
                        evrak.AS_C = item["AS_C"].ToString();
                        evrak.SC_ABORCLU = item["SC_ABORCLU"].ToString();
                        evrak.VADETRH = (DateTime)item["VADETRH"];
                        evrak.SC_ODETRH = (DateTime)item["SC_ODETRH"];
                        evrak.SC_YERI = "P";
                        evrak.YERI = item["YERI"].ToString();
                        evrak.CEK_SUBE = item["CEK_SUBE"].ToString();
                        evrak.CEK_IL = item["CEK_IL"].ToString();
                        evrak.CEK_ILCE = item["CEK_ILCE"].ToString();
                        //evrak.PROJE_KODU = item["HesapTuru"].ToString();
                        evrak.Plasiyer_Kodu = item["PLASIYER_KODU"].ToString();

                        if (item["ACIKLAMA1"] != null)
                            evrak.Aciklama1 = item["ACIKLAMA1"].ToString();

                        if (item["ACIKLAMA2"] != null)
                            evrak.Aciklama2 = item["ACIKLAMA2"].ToString();

                        if (item["C_NUMARA"] != null)
                            evrak.C_NUMARA = item["C_NUMARA"].ToString();

                        if (item["IBANNO"] != null)
                            evrak.IBANNO = item["IBANNO"].ToString();

                        if (item["CEKSERI"] != null)
                            evrak.CEKSERI = item["CEKSERI"].ToString();

                        evrak.DOVTIP = Convert.ToInt16(item["DOVTIP"]);
                        evrak.DOVTUT = Convert.ToDouble(item["DOVTUT"]);
                        evrak.Tutar = Convert.ToDouble(item["Tutar"]);


                        cekSenet.Evraklar.Add(evrak);
                    }

                    cekSenet.OtoNumaraGetir = false;
                    cekSenet.CekSenEvrakKaydetmeTip = 0;
                    cekSenet.Tip = kBelgeTuru == "MusteriSeneti" ? 1 : 0;
                    cekSenet.BordroNo = dt.Rows[0]["SC_ALB_NO"].ToString();
                    
                    hedefBelgeNo= dt.Rows[0]["SC_ALB_NO"].ToString();

                    var jsonval = JsonConvert.SerializeObject(cekSenet);

                    var content = new StringContent(jsonval, Encoding.UTF8, "application/json");

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(new Uri(AppSettingsHelper.ApiAdres), "api/v2/CheckAndPNotesMain");
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                        response = client.PostAsync(client.BaseAddress.AbsoluteUri, content).Result;

                    }


                    var result = response.Content.ReadAsStringAsync().Result;

                    Result cs = JsonConvert.DeserializeObject<Result>(result);

                    if (cs.IsSuccessful == false)
                    {
                        throw new Exception(cs.ErrorDesc);
                    }

                    response.Dispose();
                }

            }

            catch (Exception)
            {
                throw;
            }
            finally
            {

            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnSeciliOlaniSil_Click(object sender, EventArgs e)
        {

        }
    }
}