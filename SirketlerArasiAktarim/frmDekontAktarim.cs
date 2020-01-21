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
using NetOpenX50;
using SirketlerArasiAktarim.Helpers;
using Microsoft.ApplicationBlocks.Data;
using System.Runtime.InteropServices;

namespace SirketlerArasiAktarim
{
    public partial class frmDekontAktarim : DevExpress.XtraEditors.XtraForm
    {
        public frmDekontAktarim()
        {
            InitializeComponent();
        }

        DataTable dtAktarim = new DataTable();

        Kernel kernel = NetsisHelper.Instance.Kernel;

        private void frmDekontAktarim_Load(object sender, EventArgs e)
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
                int kaynakSubeKodu= Convert.ToInt16(dtAktarim.Rows[0]["KSubeKodu"]);
                int hedefSubeKodu = Convert.ToInt16(dtAktarim.Rows[0]["HSubeKodu"]);
                string kBelgeTuru = dtAktarim.Rows[0]["KBelgeTuru"].ToString();
                string hBelgeTuru = dtAktarim.Rows[0]["HBelgeTuru"].ToString();
                
                string sorgu = "";

                
                sorgu = "Select d.SUBE_KODU, d.SERI_NO, d.DEKONT_NO, " +
                "(SELECT TOP 1 TARIH From " + kaynakSirket + ".dbo.TBLDEKOTRA Where SUBE_KODU=d.SUBE_KODU AND SERI_NO=d.SERI_NO AND DEKONT_NO=d.DEKONT_NO Order by SIRA_NO) TARIH, 'H' Aktarildi " +
                "From " + kaynakSirket + ".dbo.TBLDEKOMAS d " +
                "Left JOIN SirketlerArasiAktarim.dbo.TblAktarim a on a.KSubeKodu=" + kaynakSubeKodu + " And a.KaynakSeriNo=d.SERI_NO AND a.KaynakFisNo=d.DEKONT_NO " +
                "and a.hBelgeTuru='" + hBelgeTuru + "' and a.HedefSirket='" + hedefSirket + "' and a.HSubeKodu=" + hedefSubeKodu + 
                "Where a.Id IS NULL";

                 
                DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                grdAktarilacak.DataSource = dt;


                sorgu = "Select * from TblAktarim Where AktarimTanimId=" + dtAktarim.Rows[0]["Id"];

                DataTable dtAktarilan = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                grdAktarilan.DataSource = dtAktarilan;

                vwAktarilan.BestFitColumns();

                btnDegistir.Visible = true;
                grdAktarimTanim.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mnSecilenleriAktar_Click(object sender, EventArgs e)
        {
            int[] selectedRows = VwAktarilacak.GetSelectedRows();

            NetsisHelper.Instance.Dispose();

            for (int i = 0; i < selectedRows.Length; i++)
            {
                int rowHandle = selectedRows[i];

                if (!VwAktarilacak.IsGroupRow(rowHandle))
                {
                    DekontAktar(VwAktarilacak.GetRowCellValue(rowHandle, "SERI_NO").ToString(), Convert.ToInt32(VwAktarilacak.GetRowCellValue(rowHandle, "DEKONT_NO")));

                    string sorgu = "Insert Into TblAktarim (AktarimTanimId, KaynakSirket, HedefSirket, KSubeKodu, HSubeKodu, " +
                    "KBelgeTuru, HBelgeTuru, KaynakSeriNo, KaynakFisNo, HedefSeriNo, HedefFisNo, Tarih) " +
                    "Values (" + dtAktarim.Rows[0]["Id"] + ", '" + dtAktarim.Rows[0]["KaynakSirket"] + "', '" + dtAktarim.Rows[0]["HedefSirket"] + "',  " +
                    "" + dtAktarim.Rows[0]["KSubeKodu"] + ",  " + dtAktarim.Rows[0]["HSubeKodu"] + ", " +
                    "'" + dtAktarim.Rows[0]["KBelgeTuru"] + "', '" + dtAktarim.Rows[0]["HBelgeTuru"] + "', " +
                    "'" + VwAktarilacak.GetRowCellValue(rowHandle, "SERI_NO") + "', '" + VwAktarilacak.GetRowCellValue(rowHandle, "DEKONT_NO") + "', " +
                    "'" + VwAktarilacak.GetRowCellValue(rowHandle, "SERI_NO") + "', '" + VwAktarilacak.GetRowCellValue(rowHandle, "DEKONT_NO") + "', GETDATE())";

                    SqlHelper.ExecuteNonQuery(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu);

                    VwAktarilacak.SetRowCellValue(rowHandle, "Aktarildi", "E");

                    grdAktarilacak.RefreshDataSource();
                }
            }
        }

        private void DekontAktar(string seriNo, int dekontNo)
        {

            string sorgu = "Select * From " + dtAktarim.Rows[0]["KaynakSirket"] + ".dbo.TBLDEKOTRA Where SUBE_KODU=" + dtAktarim.Rows[0]["KSubeKodu"] + " And SERI_NO='" + seriNo + "' And DEKONT_No= " + dekontNo + " Order by SIRA_NO";

            DataTable dtKaynak = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

            if (dtKaynak.Rows.Count>0)
            {
                Dekomas dekoMas = null;
                Dekont dekont = null;

                try
                {
                    dekoMas = NetsisHelper.Instance.Kernel.yeniDekomas(NetsisHelper.Instance.HedefSirket);

                    dekoMas.Sube_Kodu = Convert.ToInt32(dtAktarim.Rows[0]["HSubeKodu"]);
                    dekoMas.Seri_No = dtKaynak.Rows[0]["SERI_NO"].ToString();
                    dekoMas.Dekont_No= Convert.ToInt32(dtKaynak.Rows[0]["DEKONT_NO"]);

                    TDekontTip dekontTipi=TDekontTip.dekCari;

                    foreach (DataRow item in dtKaynak.Rows)
                    {
                        switch (item["C_M"])
                        {
                            case "C":
                                dekontTipi = TDekontTip.dekCari;
                                break;
                            case "M":
                                dekontTipi = TDekontTip.dekMuhasebe;
                                break;
                            case "B":
                                dekontTipi = TDekontTip.dekBanka;
                                break;
                            case "S":
                                dekontTipi = TDekontTip.dekStok;
                                break;
                        }
                        dekont = dekoMas.KalemEkle(dekontTipi);
                        dekont.kayitYeni();
                        dekont.Sube_Kodu= Convert.ToInt32(dtAktarim.Rows[0]["HSubeKodu"]);
                        dekont.Seri_No= dtKaynak.Rows[0]["SERI_NO"].ToString();
                        dekont.Dekont_No = Convert.ToInt32(dtKaynak.Rows[0]["DEKONT_NO"]);
                        dekont.Sira_No= Convert.ToInt32(dtKaynak.Rows[0]["SIRA_NO"]);
                        dekont.Fisno= dtKaynak.Rows[0]["FISNO"].ToString();
                        dekont.Tarih = Convert.ToDateTime(dtKaynak.Rows[0]["TARIH"]);
                        dekont.ValorTrh= Convert.ToDateTime(dtKaynak.Rows[0]["VALORTRH"]);
                        dekont.ValorGun = Convert.ToInt32(dtKaynak.Rows[0]["VALORGUN"]);
                        dekont.C_M = dtKaynak.Rows[0]["C_M"].ToString();
                        dekont.Kod= dtKaynak.Rows[0]["KOD"].ToString();
                        dekont.Aciklama1= dtKaynak.Rows[0]["ACIKLAMA1"].ToString();
                        dekont.Aciklama2 = dtKaynak.Rows[0]["ACIKLAMA2"].ToString();
                        dekont.ACIKLAMA3 = dtKaynak.Rows[0]["ACIKLAMA3"].ToString();
                        dekont.Aciklama4 = dtKaynak.Rows[0]["ACIKLAMA4"].ToString();
                        dekont.B_A = dtKaynak.Rows[0]["B_A"].ToString();
                        dekont.Tutar = Convert.ToDouble(dtKaynak.Rows[0]["Tutar"]);
                        dekont.Kdv_Oran= Convert.ToDouble(dtKaynak.Rows[0]["KDV_ORAN"]);
                        dekont.Kdv_Dahil = dtKaynak.Rows[0]["KDV_DAHIL"].ToString();
                        dekont.DovTL = dtKaynak.Rows[0]["DOVTL"].ToString();
                        dekont.DOVTIP=Convert.ToInt16(dtKaynak.Rows[0]["DOVTIP"]);
                        dekont.DOVTUT= Convert.ToDouble(dtKaynak.Rows[0]["DOVTUT"]);

                    }

                    dekoMas.Tamamla();

                 
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    Marshal.ReleaseComObject(dekont);
                    Marshal.ReleaseComObject(dekoMas);
                }

            }

            
        }

        private void AktarimGetir()
        {
            try
            {
                string sorgu = "Select Id, Aciklama, KaynakSirket, HedefSirket, KBelgeTuru KaynakSirketBelgeTuru, HBelgeTuru HedefSirketBelgeTuru From TblAktarimTanim " +
                "Where Aktifmi='True' and BelgeTuru='Dekont'";

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
    }
}