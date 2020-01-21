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

namespace SirketlerArasiAktarim
{
    public partial class frmAktarimProfilleri : DevExpress.XtraEditors.XtraForm
    {
        public frmAktarimProfilleri()
        {
            InitializeComponent();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}