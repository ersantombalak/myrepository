using DevExpress.XtraEditors;
using Microsoft.ApplicationBlocks.Data;
using SirketlerArasiAktarim.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace SirketlerArasiAktarim
{
    public partial class frmMusteri : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteri()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        public string CariKod = "";
        public string CariIsim = "";
        public string SirketAdi = "";

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT CARI_KOD, " + SirketAdi  + ".dbo.TRK(CARI_ISIM) CARI_ISIM, " + SirketAdi +" .dbo.TRK(CARI_IL) CARI_IL, " + SirketAdi + ".dbo.TRK(CARI_ILCE) CARI_ILCE FROM " + SirketAdi + "..TBLCASABIT WHERE SUBE_KODU='" + AppSettingsHelper.VTSubeKodu + "'";

                DataTable dt = SqlHelper.ExecuteDataset(AppSettingsHelper.ConnStrAktarim, CommandType.Text, sorgu).Tables[0];

                grdCari.DataSource = dt;
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void vwCari_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CariKod = vwCari.GetRowCellValue(vwCari.FocusedRowHandle, "CARI_KOD").ToString();
                CariIsim = vwCari.GetRowCellValue(vwCari.FocusedRowHandle, "CARI_ISIM").ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}