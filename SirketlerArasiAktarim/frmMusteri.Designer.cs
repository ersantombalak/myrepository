namespace SirketlerArasiAktarim
{
    partial class frmMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdCari = new DevExpress.XtraGrid.GridControl();
            this.vwCari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCari)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grdCari);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(913, 440);
            this.panelControl1.TabIndex = 0;
            // 
            // grdCari
            // 
            this.grdCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCari.Location = new System.Drawing.Point(2, 2);
            this.grdCari.MainView = this.vwCari;
            this.grdCari.Name = "grdCari";
            this.grdCari.Size = new System.Drawing.Size(909, 436);
            this.grdCari.TabIndex = 0;
            this.grdCari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwCari});
            // 
            // vwCari
            // 
            this.vwCari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.vwCari.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.vwCari.GridControl = this.grdCari;
            this.vwCari.Name = "vwCari";
            this.vwCari.OptionsBehavior.AllowIncrementalSearch = true;
            this.vwCari.OptionsBehavior.Editable = false;
            this.vwCari.OptionsView.ColumnAutoWidth = false;
            this.vwCari.OptionsView.ShowAutoFilterRow = true;
            this.vwCari.OptionsView.ShowGroupPanel = false;
            this.vwCari.DoubleClick += new System.EventHandler(this.vwCari_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cari Kodu";
            this.gridColumn1.FieldName = "CARI_KOD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 169;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cari İsim";
            this.gridColumn2.FieldName = "CARI_ISIM";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 383;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cari İl";
            this.gridColumn3.FieldName = "CARI_IL";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 152;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cari İlçe";
            this.gridColumn4.FieldName = "CARI_ILCE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 158;
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 440);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMusteri";
            this.Text = "Cari Kodları Listesi";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdCari;
        private DevExpress.XtraGrid.Views.Grid.GridView vwCari;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}