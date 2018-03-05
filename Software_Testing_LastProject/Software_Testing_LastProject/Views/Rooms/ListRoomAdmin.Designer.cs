namespace Software_Testing_LastProject.Views.Rooms
{
    partial class ListRoomAdmin
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grid_OdaYetkilileri = new DevExpress.XtraGrid.GridControl();
            this.gridView_OdaYetkilileri = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaYetkilileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaYetkilileri)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1244, 69);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 745);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 28);
            // 
            // grid_OdaYetkilileri
            // 
            this.grid_OdaYetkilileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_OdaYetkilileri.Location = new System.Drawing.Point(0, 69);
            this.grid_OdaYetkilileri.MainView = this.gridView_OdaYetkilileri;
            this.grid_OdaYetkilileri.MenuManager = this.ribbon;
            this.grid_OdaYetkilileri.Name = "grid_OdaYetkilileri";
            this.grid_OdaYetkilileri.Size = new System.Drawing.Size(1244, 676);
            this.grid_OdaYetkilileri.TabIndex = 2;
            this.grid_OdaYetkilileri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_OdaYetkilileri});
            // 
            // gridView_OdaYetkilileri
            // 
            this.gridView_OdaYetkilileri.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_OdaYetkilileri.GridControl = this.grid_OdaYetkilileri;
            this.gridView_OdaYetkilileri.Name = "gridView_OdaYetkilileri";
            this.gridView_OdaYetkilileri.OptionsBehavior.Editable = false;
            this.gridView_OdaYetkilileri.OptionsBehavior.ReadOnly = true;
            this.gridView_OdaYetkilileri.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_OdaYetkilileri_RowClick);
            // 
            // ListRoomAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 773);
            this.Controls.Add(this.grid_OdaYetkilileri);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ListRoomAdmin";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Oda Yetkilileri Listesi";
            this.Load += new System.EventHandler(this.ListRoomAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OdaYetkilileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OdaYetkilileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl grid_OdaYetkilileri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_OdaYetkilileri;
    }
}