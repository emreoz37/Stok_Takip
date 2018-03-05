namespace Software_Testing_LastProject.Views.Rooms
{
    partial class EditRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoomForm));
            this.btn_OdaTanimla = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OdaDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Departman = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OdaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.grid_Kisiler = new DevExpress.XtraGrid.GridControl();
            this.gridView_Kisiler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OdaListele = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Ekle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OdaSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cmb_Fakulte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grup_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OdaTanimla
            // 
            this.btn_OdaTanimla.Caption = "Oda Tanımla";
            this.btn_OdaTanimla.Id = 1;
            this.btn_OdaTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaTanimla.ImageOptions.Image")));
            this.btn_OdaTanimla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaTanimla.ImageOptions.LargeImage")));
            this.btn_OdaTanimla.Name = "btn_OdaTanimla";
            // 
            // btn_OdaDuzenle
            // 
            this.btn_OdaDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_OdaDuzenle.Location = new System.Drawing.Point(98, 179);
            this.btn_OdaDuzenle.Name = "btn_OdaDuzenle";
            this.btn_OdaDuzenle.Size = new System.Drawing.Size(181, 40);
            this.btn_OdaDuzenle.TabIndex = 10;
            this.btn_OdaDuzenle.Text = "Odayı Düzenle";
            this.btn_OdaDuzenle.Click += new System.EventHandler(this.btn_OdaDuzenle_Click);
            // 
            // cmb_Departman
            // 
            this.cmb_Departman.FormattingEnabled = true;
            this.cmb_Departman.Location = new System.Drawing.Point(98, 121);
            this.cmb_Departman.Name = "cmb_Departman";
            this.cmb_Departman.Size = new System.Drawing.Size(181, 24);
            this.cmb_Departman.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departman:";
            // 
            // txt_OdaAdi
            // 
            this.txt_OdaAdi.Location = new System.Drawing.Point(98, 27);
            this.txt_OdaAdi.Name = "txt_OdaAdi";
            this.txt_OdaAdi.Size = new System.Drawing.Size(181, 23);
            this.txt_OdaAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oda Adı:";
            // 
            // grup_Main
            // 
            this.grup_Main.Controls.Add(this.grid_Kisiler);
            this.grup_Main.Controls.Add(this.btn_OdaDuzenle);
            this.grup_Main.Controls.Add(this.cmb_Departman);
            this.grup_Main.Controls.Add(this.cmb_Fakulte);
            this.grup_Main.Controls.Add(this.label3);
            this.grup_Main.Controls.Add(this.txt_OdaAdi);
            this.grup_Main.Controls.Add(this.label2);
            this.grup_Main.Controls.Add(this.label1);
            this.grup_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grup_Main.Location = new System.Drawing.Point(0, 185);
            this.grup_Main.Name = "grup_Main";
            this.grup_Main.Size = new System.Drawing.Size(1095, 525);
            this.grup_Main.TabIndex = 5;
            this.grup_Main.TabStop = false;
            this.grup_Main.Text = "Oda Ekle";
            // 
            // grid_Kisiler
            // 
            this.grid_Kisiler.Location = new System.Drawing.Point(549, 22);
            this.grid_Kisiler.MainView = this.gridView_Kisiler;
            this.grid_Kisiler.MenuManager = this.ribbonControl1;
            this.grid_Kisiler.Name = "grid_Kisiler";
            this.grid_Kisiler.Size = new System.Drawing.Size(524, 500);
            this.grid_Kisiler.TabIndex = 11;
            this.grid_Kisiler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Kisiler});
            // 
            // gridView_Kisiler
            // 
            this.gridView_Kisiler.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Kisiler.GridControl = this.grid_Kisiler;
            this.gridView_Kisiler.Name = "gridView_Kisiler";
            this.gridView_Kisiler.OptionsBehavior.Editable = false;
            this.gridView_Kisiler.OptionsBehavior.ReadOnly = true;
            this.gridView_Kisiler.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Kisiler_RowClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.btn_OdaListele,
            this.btn_Ekle,
            this.barButtonItem4,
            this.btn_OdaSil});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1095, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btn_OdaListele
            // 
            this.btn_OdaListele.Caption = "Odaları Listele";
            this.btn_OdaListele.Id = 2;
            this.btn_OdaListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaListele.ImageOptions.Image")));
            this.btn_OdaListele.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaListele.ImageOptions.LargeImage")));
            this.btn_OdaListele.Name = "btn_OdaListele";
            this.btn_OdaListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_OdaListele_ItemClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Caption = "Oda Ekle";
            this.btn_Ekle.Id = 3;
            this.btn_Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.ImageOptions.Image")));
            this.btn_Ekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.ImageOptions.LargeImage")));
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Ekle_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btn_OdaSil
            // 
            this.btn_OdaSil.Caption = "Odayı Sil";
            this.btn_OdaSil.Id = 6;
            this.btn_OdaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaSil.ImageOptions.Image")));
            this.btn_OdaSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaSil.ImageOptions.LargeImage")));
            this.btn_OdaSil.Name = "btn_OdaSil";
            this.btn_OdaSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_OdaSil_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Ekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_OdaListele);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_OdaSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 710);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1095, 40);
            // 
            // cmb_Fakulte
            // 
            this.cmb_Fakulte.FormattingEnabled = true;
            this.cmb_Fakulte.Location = new System.Drawing.Point(98, 77);
            this.cmb_Fakulte.Name = "cmb_Fakulte";
            this.cmb_Fakulte.Size = new System.Drawing.Size(181, 24);
            this.cmb_Fakulte.TabIndex = 9;
            this.cmb_Fakulte.SelectedIndexChanged += new System.EventHandler(this.cmb_Fakulte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fakülte:";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // EditRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 750);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "EditRoomForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "EditRoomForm";
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            this.grup_Main.ResumeLayout(false);
            this.grup_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Kisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Kisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem btn_OdaTanimla;
        private DevExpress.XtraEditors.SimpleButton btn_OdaDuzenle;
        private System.Windows.Forms.ComboBox cmb_Departman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OdaAdi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grup_Main;
        private System.Windows.Forms.ComboBox cmb_Fakulte;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_OdaListele;
        private DevExpress.XtraBars.BarButtonItem btn_Ekle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_OdaSil;
        private DevExpress.XtraGrid.GridControl grid_Kisiler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Kisiler;
    }
}