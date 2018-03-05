namespace Software_Testing_LastProject.Views.Rooms
{
    partial class OdaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaEkle));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grup_Main = new System.Windows.Forms.GroupBox();
            this.btn_OdaDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Departman = new System.Windows.Forms.ComboBox();
            this.cmb_Fakulte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_OdaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grup_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(654, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Oda Kisi Yetkinlendir";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Oda Ekleme";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 597);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(654, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // grup_Main
            // 
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
            this.grup_Main.Size = new System.Drawing.Size(654, 412);
            this.grup_Main.TabIndex = 9;
            this.grup_Main.TabStop = false;
            this.grup_Main.Text = "Oda Ekle";
            // 
            // btn_OdaDuzenle
            // 
            this.btn_OdaDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_OdaDuzenle.Location = new System.Drawing.Point(238, 229);
            this.btn_OdaDuzenle.Name = "btn_OdaDuzenle";
            this.btn_OdaDuzenle.Size = new System.Drawing.Size(181, 40);
            this.btn_OdaDuzenle.TabIndex = 10;
            this.btn_OdaDuzenle.Text = "Oda Ekle";
            this.btn_OdaDuzenle.Click += new System.EventHandler(this.btn_OdaDuzenle_Click);
            // 
            // cmb_Departman
            // 
            this.cmb_Departman.FormattingEnabled = true;
            this.cmb_Departman.Location = new System.Drawing.Point(238, 177);
            this.cmb_Departman.Name = "cmb_Departman";
            this.cmb_Departman.Size = new System.Drawing.Size(181, 24);
            this.cmb_Departman.TabIndex = 8;
            // 
            // cmb_Fakulte
            // 
            this.cmb_Fakulte.FormattingEnabled = true;
            this.cmb_Fakulte.Location = new System.Drawing.Point(238, 133);
            this.cmb_Fakulte.Name = "cmb_Fakulte";
            this.cmb_Fakulte.Size = new System.Drawing.Size(181, 24);
            this.cmb_Fakulte.TabIndex = 9;
            this.cmb_Fakulte.SelectedIndexChanged += new System.EventHandler(this.cmb_Fakulte_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departman:";
            // 
            // txt_OdaAdi
            // 
            this.txt_OdaAdi.Location = new System.Drawing.Point(238, 83);
            this.txt_OdaAdi.Name = "txt_OdaAdi";
            this.txt_OdaAdi.Size = new System.Drawing.Size(181, 23);
            this.txt_OdaAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fakülte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oda Adı:";
            // 
            // OdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 625);
            this.Controls.Add(this.grup_Main);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "OdaEkle";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "OdaEkle";
            this.Load += new System.EventHandler(this.OdaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grup_Main.ResumeLayout(false);
            this.grup_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        public System.Windows.Forms.GroupBox grup_Main;
        private DevExpress.XtraEditors.SimpleButton btn_OdaDuzenle;
        private System.Windows.Forms.ComboBox cmb_Departman;
        private System.Windows.Forms.ComboBox cmb_Fakulte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_OdaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}