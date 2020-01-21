namespace SirketlerArasiAktarim
{
    partial class frmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnIrsaliyeFatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnCekSenet = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnAktarimTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaglantiAyari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnDekont = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnIrsaliyeFatura,
            this.btnCekSenet,
            this.skinRibbonGalleryBarItem2,
            this.btnAktarimTanimlari,
            this.btnBaglantiAyari,
            this.btnDekont});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(997, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnIrsaliyeFatura
            // 
            this.btnIrsaliyeFatura.Caption = "İrsaliye-Fatura";
            this.btnIrsaliyeFatura.Id = 1;
            this.btnIrsaliyeFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIrsaliyeFatura.ImageOptions.Image")));
            this.btnIrsaliyeFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnIrsaliyeFatura.ImageOptions.LargeImage")));
            this.btnIrsaliyeFatura.Name = "btnIrsaliyeFatura";
            this.btnIrsaliyeFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIrsaliyeFatura_ItemClick);
            // 
            // btnCekSenet
            // 
            this.btnCekSenet.Caption = "Müşteri Çek-Senet";
            this.btnCekSenet.Id = 2;
            this.btnCekSenet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCekSenet.ImageOptions.Image")));
            this.btnCekSenet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCekSenet.ImageOptions.LargeImage")));
            this.btnCekSenet.Name = "btnCekSenet";
            this.btnCekSenet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCekSenet_ItemClick);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 6;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // btnAktarimTanimlari
            // 
            this.btnAktarimTanimlari.Caption = "Aktarım Profilleri";
            this.btnAktarimTanimlari.Id = 7;
            this.btnAktarimTanimlari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAktarimTanimlari.ImageOptions.Image")));
            this.btnAktarimTanimlari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAktarimTanimlari.ImageOptions.LargeImage")));
            this.btnAktarimTanimlari.LargeWidth = 80;
            this.btnAktarimTanimlari.Name = "btnAktarimTanimlari";
            this.btnAktarimTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAktarimTanimlari_ItemClick);
            // 
            // btnBaglantiAyari
            // 
            this.btnBaglantiAyari.Caption = "barButtonItem1";
            this.btnBaglantiAyari.Id = 8;
            this.btnBaglantiAyari.Name = "btnBaglantiAyari";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tanım";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAktarimTanimlari);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Aktarım Profilleri";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Aktarım";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIrsaliyeFatura);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCekSenet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDekont);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Aktarım İşlemleri";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ayar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tema";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBaglantiAyari);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(997, 31);
            // 
            // btnDekont
            // 
            this.btnDekont.Caption = "Dekont";
            this.btnDekont.Id = 9;
            this.btnDekont.Name = "btnDekont";
            this.btnDekont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDekont_ItemClick);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmAnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Şirketler Arası Aktarım";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnIrsaliyeFatura;
        private DevExpress.XtraBars.BarButtonItem btnCekSenet;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.BarButtonItem btnAktarimTanimlari;
        private DevExpress.XtraBars.BarButtonItem btnBaglantiAyari;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDekont;
    }
}