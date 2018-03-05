namespace Software_Testing_LastProject.Views.Fixtures
{
    partial class OdaZimmetleriGetirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaZimmetleriGetirForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grid_OdaDemirbaslari = new DevExpress.XtraGrid.GridControl();
            this.gridView_OdaDemirbaslari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_OdaAdi = new System.Windows.Forms.Label();
            this.lbl_Sorumlu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaDemirbaslari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaDemirbaslari)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1006, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Pdf Dökümü Al";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Excel Dökümü Al";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Döküm İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 669);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1006, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // grid_OdaDemirbaslari
            // 
            this.grid_OdaDemirbaslari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_OdaDemirbaslari.Location = new System.Drawing.Point(0, 185);
            this.grid_OdaDemirbaslari.MainView = this.gridView_OdaDemirbaslari;
            this.grid_OdaDemirbaslari.MenuManager = this.ribbonControl1;
            this.grid_OdaDemirbaslari.Name = "grid_OdaDemirbaslari";
            this.grid_OdaDemirbaslari.Size = new System.Drawing.Size(1006, 484);
            this.grid_OdaDemirbaslari.TabIndex = 3;
            this.grid_OdaDemirbaslari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_OdaDemirbaslari});
            // 
            // gridView_OdaDemirbaslari
            // 
            this.gridView_OdaDemirbaslari.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_OdaDemirbaslari.GridControl = this.grid_OdaDemirbaslari;
            this.gridView_OdaDemirbaslari.Name = "gridView_OdaDemirbaslari";
            this.gridView_OdaDemirbaslari.OptionsBehavior.Editable = false;
            this.gridView_OdaDemirbaslari.OptionsBehavior.ReadOnly = true;
            this.gridView_OdaDemirbaslari.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_OdaDemirbaslari_RowClick);
            this.gridView_OdaDemirbaslari.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_OdaDemirbaslari_CustomDrawRowIndicator);
            // 
            // lbl_OdaAdi
            // 
            this.lbl_OdaAdi.AutoSize = true;
            this.lbl_OdaAdi.Location = new System.Drawing.Point(415, 83);
            this.lbl_OdaAdi.Name = "lbl_OdaAdi";
            this.lbl_OdaAdi.Size = new System.Drawing.Size(60, 17);
            this.lbl_OdaAdi.TabIndex = 4;
            this.lbl_OdaAdi.Text = "Oda Adı:";
            // 
            // lbl_Sorumlu
            // 
            this.lbl_Sorumlu.AutoSize = true;
            this.lbl_Sorumlu.Location = new System.Drawing.Point(415, 113);
            this.lbl_Sorumlu.Name = "lbl_Sorumlu";
            this.lbl_Sorumlu.Size = new System.Drawing.Size(111, 17);
            this.lbl_Sorumlu.TabIndex = 4;
            this.lbl_Sorumlu.Text = "Oda Sorumlusu: ";
            // 
            // OdaZimmetleriGetirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 697);
            this.Controls.Add(this.lbl_Sorumlu);
            this.Controls.Add(this.lbl_OdaAdi);
            this.Controls.Add(this.grid_OdaDemirbaslari);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "OdaZimmetleriGetirForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Oda İçeriği";
            this.Load += new System.EventHandler(this.OdaZimmetleriGetirForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaDemirbaslari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaDemirbaslari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl grid_OdaDemirbaslari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_OdaDemirbaslari;
        private System.Windows.Forms.Label lbl_OdaAdi;
        private System.Windows.Forms.Label lbl_Sorumlu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}