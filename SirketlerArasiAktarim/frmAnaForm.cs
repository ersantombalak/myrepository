using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SirketlerArasiAktarim
{
    public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void btnIrsaliyeFatura_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmIrsaliyeFaturaAktarim frm = new frmIrsaliyeFaturaAktarim();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
         
        }

        private void btnCekSenet_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCekSenetAktarim frm = new frmCekSenetAktarim();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnAktarimTanimlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAktarimProfilleri frm = new frmAktarimProfilleri();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDekont_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDekontAktarim frm = new frmDekontAktarim();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

            private void frmAnaForm_Load(object sender, EventArgs e)
        {
            ribbon.SelectedPage = ribbon.Pages[1];
        }

       
    }
}