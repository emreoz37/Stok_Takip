namespace Software_Testing_LastProject.Views.Fixtures
{
    partial class DemirbasOdaTanimlaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasOdaTanimlaForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_OdaDemirbasKisi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_Oda = new DevExpress.XtraGrid.GridControl();
            this.gridView_Oda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_Demirbas = new DevExpress.XtraGrid.GridControl();
            this.gridView_Demirbas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.lbl_oda = new System.Windows.Forms.Label();
            this.lbl_demirbas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Oda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Oda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbas)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_OdaDemirbasKisi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1629, 185);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btn_OdaDemirbasKisi
            // 
            this.btn_OdaDemirbasKisi.Caption = "Oda Demirbaş İlişkinlendir";
            this.btn_OdaDemirbasKisi.Id = 1;
            this.btn_OdaDemirbasKisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_OdaDemirbasKisi.ImageOptions.Image")));
            this.btn_OdaDemirbasKisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_OdaDemirbasKisi.ImageOptions.LargeImage")));
            this.btn_OdaDemirbasKisi.Name = "btn_OdaDemirbasKisi";
            this.btn_OdaDemirbasKisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_OdaDemirbasKisi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 776);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1629, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_Oda);
            this.panel3.Location = new System.Drawing.Point(12, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 564);
            this.panel3.TabIndex = 2;
            // 
            // grid_Oda
            // 
            this.grid_Oda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Oda.Location = new System.Drawing.Point(0, 0);
            this.grid_Oda.MainView = this.gridView_Oda;
            this.grid_Oda.MenuManager = this.ribbonControl1;
            this.grid_Oda.Name = "grid_Oda";
            this.grid_Oda.Size = new System.Drawing.Size(519, 564);
            this.grid_Oda.TabIndex = 1;
            this.grid_Oda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Oda});
            // 
            // gridView_Oda
            // 
            this.gridView_Oda.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Oda.GridControl = this.grid_Oda;
            this.gridView_Oda.Name = "gridView_Oda";
            this.gridView_Oda.OptionsBehavior.Editable = false;
            this.gridView_Oda.OptionsBehavior.ReadOnly = true;
            this.gridView_Oda.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Oda_RowClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_Demirbas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Adet);
            this.panel2.Location = new System.Drawing.Point(555, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 564);
            this.panel2.TabIndex = 3;
            // 
            // grid_Demirbas
            // 
            this.grid_Demirbas.Location = new System.Drawing.Point(7, 36);
            this.grid_Demirbas.MainView = this.gridView_Demirbas;
            this.grid_Demirbas.MenuManager = this.ribbonControl1;
            this.grid_Demirbas.Name = "grid_Demirbas";
            this.grid_Demirbas.Size = new System.Drawing.Size(588, 525);
            this.grid_Demirbas.TabIndex = 6;
            this.grid_Demirbas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Demirbas});
            // 
            // gridView_Demirbas
            // 
            this.gridView_Demirbas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Demirbas.GridControl = this.grid_Demirbas;
            this.gridView_Demirbas.Name = "gridView_Demirbas";
            this.gridView_Demirbas.OptionsBehavior.Editable = false;
            this.gridView_Demirbas.OptionsBehavior.ReadOnly = true;
            this.gridView_Demirbas.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Demirbas_RowClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Demirbaş Adedi";
            // 
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(112, 9);
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(100, 23);
            this.txt_Adet.TabIndex = 4;
            this.txt_Adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_oda
            // 
            this.lbl_oda.AutoSize = true;
            this.lbl_oda.Location = new System.Drawing.Point(198, 86);
            this.lbl_oda.Name = "lbl_oda";
            this.lbl_oda.Size = new System.Drawing.Size(125, 17);
            this.lbl_oda.TabIndex = 5;
            this.lbl_oda.Text = "Seçilen Oda Bilgileri:";
            // 
            // lbl_demirbas
            // 
            this.lbl_demirbas.AutoSize = true;
            this.lbl_demirbas.Location = new System.Drawing.Point(198, 122);
            this.lbl_demirbas.Name = "lbl_demirbas";
            this.lbl_demirbas.Size = new System.Drawing.Size(157, 17);
            this.lbl_demirbas.TabIndex = 5;
            this.lbl_demirbas.Text = "Seçilen Demirbaş Bilgileri:";
            // 
            // DemirbasOdaTanimlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_demirbas);
            this.Controls.Add(this.lbl_oda);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DemirbasOdaTanimlaForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DemirbasOdaTanimlaForm";
            this.Load += new System.EventHandler(this.DemirbasOdaTanimlaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Oda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Oda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Demirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Demirbas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grid_Oda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Oda;
        private DevExpress.XtraBars.BarButtonItem btn_OdaDemirbasKisi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Adet;
        private DevExpress.XtraGrid.GridControl grid_Demirbas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Demirbas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_oda;
        private System.Windows.Forms.Label lbl_demirbas;
    }
}