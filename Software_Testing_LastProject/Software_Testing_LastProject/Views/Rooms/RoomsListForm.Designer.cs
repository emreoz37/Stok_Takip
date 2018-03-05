namespace Software_Testing_LastProject.Views.Rooms
{
    partial class RoomsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsListForm));
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.grid_OdaListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView_OdaListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_OdaTanimla = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grup_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // grup_Main
            // 
            this.grup_Main.Controls.Add(this.grid_OdaListesi);
            this.grup_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grup_Main.Location = new System.Drawing.Point(0, 185);
            this.grup_Main.Name = "grup_Main";
            this.grup_Main.Size = new System.Drawing.Size(1050, 419);
            this.grup_Main.TabIndex = 5;
            this.grup_Main.TabStop = false;
            // 
            // grid_OdaListesi
            // 
            this.grid_OdaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_OdaListesi.Location = new System.Drawing.Point(3, 19);
            this.grid_OdaListesi.MainView = this.gridView_OdaListesi;
            this.grid_OdaListesi.Name = "grid_OdaListesi";
            this.grid_OdaListesi.Size = new System.Drawing.Size(1044, 397);
            this.grid_OdaListesi.TabIndex = 1;
            this.grid_OdaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_OdaListesi});
            // 
            // gridView_OdaListesi
            // 
            this.gridView_OdaListesi.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_OdaListesi.GridControl = this.grid_OdaListesi;
            this.gridView_OdaListesi.Name = "gridView_OdaListesi";
            this.gridView_OdaListesi.OptionsBehavior.Editable = false;
            this.gridView_OdaListesi.OptionsBehavior.ReadOnly = true;
            this.gridView_OdaListesi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_OdaListesi_RowClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_OdaTanimla,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1050, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_OdaTanimla
            // 
            this.btn_OdaTanimla.Caption = "Oda Tanımla";
            this.btn_OdaTanimla.Id = 1;
            this.btn_OdaTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaTanimla.ImageOptions.Image")));
            this.btn_OdaTanimla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaTanimla.ImageOptions.LargeImage")));
            this.btn_OdaTanimla.Name = "btn_OdaTanimla";
            this.btn_OdaTanimla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_OdaTanimla_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Oda İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_OdaTanimla);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 604);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1050, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // RoomsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 632);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "RoomsListForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "RoomsListForm";
            this.Load += new System.EventHandler(this.RoomsListForm_Load);
            this.grup_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grup_Main;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_OdaTanimla;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl grid_OdaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_OdaListesi;
    }
}