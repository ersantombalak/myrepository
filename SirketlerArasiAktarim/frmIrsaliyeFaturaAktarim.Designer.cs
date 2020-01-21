namespace SirketlerArasiAktarim
{
    partial class frmIrsaliyeFaturaAktarim
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colAktarildi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mnAktar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnSecilenleriAktar = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.grdAktarilacakFisler = new DevExpress.XtraGrid.GridControl();
            this.VwIrsaliyeFatura = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grdAktarilan = new DevExpress.XtraGrid.GridControl();
            this.mnAktarilan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnSeciliOlaniSil = new System.Windows.Forms.ToolStripMenuItem();
            this.vwAktarilan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdAktarimTanim = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.mnAktar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarilacakFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwIrsaliyeFatura)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarilan)).BeginInit();
            this.mnAktarilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwAktarilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarimTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colAktarildi
            // 
            this.colAktarildi.Caption = "Aktarildi";
            this.colAktarildi.FieldName = "Aktarildi";
            this.colAktarildi.Name = "colAktarildi";
            // 
            // mnAktar
            // 
            this.mnAktar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSecilenleriAktar});
            this.mnAktar.Name = "mnAktar";
            this.mnAktar.Size = new System.Drawing.Size(159, 26);
            // 
            // mnSecilenleriAktar
            // 
            this.mnSecilenleriAktar.Name = "mnSecilenleriAktar";
            this.mnSecilenleriAktar.Size = new System.Drawing.Size(158, 22);
            this.mnSecilenleriAktar.Text = "Seçilenleri Aktar";
            this.mnSecilenleriAktar.Click += new System.EventHandler(this.mnSecilenleriAktar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(809, 644);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 37);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(805, 605);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(799, 577);
            this.xtraTabPage1.Text = "Aktarılmayanlar";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.grdAktarilacakFisler);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(799, 577);
            this.panelControl4.TabIndex = 1;
            // 
            // grdAktarilacakFisler
            // 
            this.grdAktarilacakFisler.ContextMenuStrip = this.mnAktar;
            this.grdAktarilacakFisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAktarilacakFisler.Location = new System.Drawing.Point(2, 2);
            this.grdAktarilacakFisler.MainView = this.VwIrsaliyeFatura;
            this.grdAktarilacakFisler.Name = "grdAktarilacakFisler";
            this.grdAktarilacakFisler.Size = new System.Drawing.Size(795, 573);
            this.grdAktarilacakFisler.TabIndex = 0;
            this.grdAktarilacakFisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VwIrsaliyeFatura});
            // 
            // VwIrsaliyeFatura
            // 
            this.VwIrsaliyeFatura.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn16,
            this.gridColumn10,
            this.colAktarildi});
            this.VwIrsaliyeFatura.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colAktarildi;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout);
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[Aktarildi] = \'E\'";
            formatConditionRuleValue1.Value1 = "E";
            formatConditionRuleValue1.Value2 = "E";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.VwIrsaliyeFatura.FormatRules.Add(gridFormatRule1);
            this.VwIrsaliyeFatura.GridControl = this.grdAktarilacakFisler;
            this.VwIrsaliyeFatura.Name = "VwIrsaliyeFatura";
            this.VwIrsaliyeFatura.OptionsBehavior.Editable = false;
            this.VwIrsaliyeFatura.OptionsCustomization.AllowGroup = false;
            this.VwIrsaliyeFatura.OptionsSelection.MultiSelect = true;
            this.VwIrsaliyeFatura.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.VwIrsaliyeFatura.OptionsView.ColumnAutoWidth = false;
            this.VwIrsaliyeFatura.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Şube Kodu";
            this.gridColumn7.FieldName = "SUBE_KODU";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 68;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fiş No";
            this.gridColumn8.FieldName = "FATIRS_NO";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 117;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cari Kodu";
            this.gridColumn9.FieldName = "CARI_KODU";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 105;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Cari İsim";
            this.gridColumn16.FieldName = "CARI_ISIM";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 234;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tarih";
            this.gridColumn10.FieldName = "TARIH";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 96;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grdAktarilan);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(799, 577);
            this.xtraTabPage2.Text = "Daha Önce Aktarılan";
            // 
            // grdAktarilan
            // 
            this.grdAktarilan.ContextMenuStrip = this.mnAktarilan;
            this.grdAktarilan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAktarilan.Location = new System.Drawing.Point(0, 0);
            this.grdAktarilan.MainView = this.vwAktarilan;
            this.grdAktarilan.Name = "grdAktarilan";
            this.grdAktarilan.Size = new System.Drawing.Size(799, 577);
            this.grdAktarilan.TabIndex = 0;
            this.grdAktarilan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwAktarilan});
            // 
            // mnAktarilan
            // 
            this.mnAktarilan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSeciliOlaniSil});
            this.mnAktarilan.Name = "mnAktarilan";
            this.mnAktarilan.Size = new System.Drawing.Size(148, 26);
            // 
            // mnSeciliOlaniSil
            // 
            this.mnSeciliOlaniSil.Name = "mnSeciliOlaniSil";
            this.mnSeciliOlaniSil.Size = new System.Drawing.Size(147, 22);
            this.mnSeciliOlaniSil.Text = "Seçili Olanı Sil";
            this.mnSeciliOlaniSil.Click += new System.EventHandler(this.mnSeciliOlaniSil_Click);
            // 
            // vwAktarilan
            // 
            this.vwAktarilan.GridControl = this.grdAktarilan;
            this.vwAktarilan.Name = "vwAktarilan";
            this.vwAktarilan.OptionsBehavior.Editable = false;
            this.vwAktarilan.OptionsCustomization.AllowGroup = false;
            this.vwAktarilan.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnDegistir);
            this.panelControl3.Controls.Add(this.btnGetir);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.grdAktarimTanim);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(805, 35);
            this.panelControl3.TabIndex = 3;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(512, 6);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 3;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Visible = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(435, 6);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Aktarım İşlemleri:";
            // 
            // grdAktarimTanim
            // 
            this.grdAktarimTanim.EditValue = "";
            this.grdAktarimTanim.Location = new System.Drawing.Point(96, 9);
            this.grdAktarimTanim.Name = "grdAktarimTanim";
            this.grdAktarimTanim.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.grdAktarimTanim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdAktarimTanim.Properties.ImmediatePopup = true;
            this.grdAktarimTanim.Properties.NullText = "";
            this.grdAktarimTanim.Properties.PopupView = this.gridLookUpEdit1View;
            this.grdAktarimTanim.Properties.ShowFooter = false;
            this.grdAktarimTanim.Size = new System.Drawing.Size(333, 20);
            this.grdAktarimTanim.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 55;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Açıklama";
            this.gridColumn2.FieldName = "Aciklama";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 181;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "K.Şirket";
            this.gridColumn3.FieldName = "KaynakSirket";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 200;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "H.Şirket";
            this.gridColumn4.FieldName = "HedefSirket";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 206;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "K.Belge Türü";
            this.gridColumn5.FieldName = "KaynakSirketBelgeTuru";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 190;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "H.Belge Türü";
            this.gridColumn6.FieldName = "HedefSirketBelgeTuru";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 217;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 644);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl2.Size = new System.Drawing.Size(809, 45);
            this.panelControl2.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Location = new System.Drawing.Point(729, 5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 35);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmIrsaliyeFaturaAktarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 689);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmIrsaliyeFaturaAktarim";
            this.Text = "İrsaliye-Fatura Aktarma";
            this.Load += new System.EventHandler(this.frmAktarim_Load);
            this.mnAktar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarilacakFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VwIrsaliyeFatura)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarilan)).EndInit();
            this.mnAktarilan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwAktarilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAktarimTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ContextMenuStrip mnAktar;
        private System.Windows.Forms.ToolStripMenuItem mnSecilenleriAktar;
        private System.Windows.Forms.ContextMenuStrip mnAktarilan;
        private System.Windows.Forms.ToolStripMenuItem mnSeciliOlaniSil;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl grdAktarilacakFisler;
        private DevExpress.XtraGrid.Views.Grid.GridView VwIrsaliyeFatura;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl grdAktarilan;
        private DevExpress.XtraGrid.Views.Grid.GridView vwAktarilan;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit grdAktarimTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colAktarildi;
    }
}