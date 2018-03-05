﻿namespace Software_Testing_LastProject.Views.Fixtures
{
    partial class FixturesListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixturesListsForm));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Duzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lbl_SeciliUrun = new System.Windows.Forms.Label();
            this.grid_Demirbaslar = new DevExpress.XtraGrid.GridControl();
            this.gridView_Demirbaslar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_Toplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_Duzenle,
            this.btn_Sil});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(958, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Caption = "Seçilen Ürünü Düzenle";
            this.btn_Duzenle.Id = 1;
            this.btn_Duzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Duzenle.ImageOptions.Image")));
            this.btn_Duzenle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Duzenle.ImageOptions.LargeImage")));
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Duzenle_ItemClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Caption = "Seçilen Ürünü Demirbaştan Kaldır";
            this.btn_Sil.Id = 3;
            this.btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.Image")));
            this.btn_Sil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.LargeImage")));
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Sil_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Duzenle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Sil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 612);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(958, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // lbl_SeciliUrun
            // 
            this.lbl_SeciliUrun.AutoSize = true;
            this.lbl_SeciliUrun.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_SeciliUrun.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SeciliUrun.Location = new System.Drawing.Point(663, 133);
            this.lbl_SeciliUrun.Name = "lbl_SeciliUrun";
            this.lbl_SeciliUrun.Size = new System.Drawing.Size(0, 21);
            this.lbl_SeciliUrun.TabIndex = 5;
            // 
            // grid_Demirbaslar
            // 
            this.grid_Demirbaslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Demirbaslar.Location = new System.Drawing.Point(0, 185);
            this.grid_Demirbaslar.MainView = this.gridView_Demirbaslar;
            this.grid_Demirbaslar.MenuManager = this.ribbonControl1;
            this.grid_Demirbaslar.Name = "grid_Demirbaslar";
            this.grid_Demirbaslar.Size = new System.Drawing.Size(958, 427);
            this.grid_Demirbaslar.TabIndex = 8;
            this.grid_Demirbaslar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Demirbaslar});
            // 
            // gridView_Demirbaslar
            // 
            this.gridView_Demirbaslar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Demirbaslar.GridControl = this.grid_Demirbaslar;
            this.gridView_Demirbaslar.Name = "gridView_Demirbaslar";
            this.gridView_Demirbaslar.OptionsBehavior.Editable = false;
            this.gridView_Demirbaslar.OptionsBehavior.ReadOnly = true;
            this.gridView_Demirbaslar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Demirbaslar_RowClick);
            // 
            // lbl_Toplam
            // 
            this.lbl_Toplam.AutoSize = true;
            this.lbl_Toplam.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_Toplam.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Toplam.Location = new System.Drawing.Point(663, 81);
            this.lbl_Toplam.Name = "lbl_Toplam";
            this.lbl_Toplam.Size = new System.Drawing.Size(199, 21);
            this.lbl_Toplam.TabIndex = 5;
            this.lbl_Toplam.Text = "Toplam Demirbaş Sayısı: ";
            // 
            // FixturesListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 640);
            this.Controls.Add(this.grid_Demirbaslar);
            this.Controls.Add(this.lbl_Toplam);
            this.Controls.Add(this.lbl_SeciliUrun);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FixturesListsForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Demirbaş Listesi";
            this.Load += new System.EventHandler(this.FixturesListsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbaslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_Duzenle;
        private DevExpress.XtraBars.BarButtonItem btn_Sil;
        private System.Windows.Forms.Label lbl_SeciliUrun;
        private DevExpress.XtraGrid.GridControl grid_Demirbaslar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Demirbaslar;
        private System.Windows.Forms.Label lbl_Toplam;
    }
}