namespace ServerApp.PredefinedReports {
    partial class TestReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.label3 = new DevExpress.XtraReports.UI.XRLabel();
         this.label2 = new DevExpress.XtraReports.UI.XRLabel();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // TopMargin
         // 
         this.TopMargin.Dpi = 254F;
         this.TopMargin.HeightF = 47.625F;
         this.TopMargin.Name = "TopMargin";
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label3,
            this.label2});
         this.Detail.Dpi = 254F;
         this.Detail.HeightF = 169.875F;
         this.Detail.HierarchyPrintOptions.Indent = 50.8F;
         this.Detail.Name = "Detail";
         // 
         // BottomMargin
         // 
         this.BottomMargin.Dpi = 254F;
         this.BottomMargin.HeightF = 0F;
         this.BottomMargin.Name = "BottomMargin";
         // 
         // label3
         // 
         this.label3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.label3.Dpi = 254F;
         this.label3.Font = new DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold);
         this.label3.LocationFloat = new DevExpress.Utils.PointFloat(1296.333F, 88.16661F);
         this.label3.Name = "label3";
         this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
         this.label3.Scripts.OnBeforePrint = "label2_BeforePrint";
         this.label3.SizeF = new System.Drawing.SizeF(60F, 60F);
         this.label3.StylePriority.UseBorders = false;
         this.label3.StylePriority.UseFont = false;
         this.label3.StylePriority.UseTextAlignment = false;
         this.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // label2
         // 
         this.label2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.label2.Dpi = 254F;
         this.label2.EditOptions.Enabled = true;
         this.label2.Font = new DevExpress.Drawing.DXFont("Arial", 12F, DevExpress.Drawing.DXFontStyle.Bold);
         this.label2.LocationFloat = new DevExpress.Utils.PointFloat(1183.62F, 88.16661F);
         this.label2.Name = "label2";
         this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
         this.label2.Scripts.OnBeforePrint = "label2_BeforePrint";
         this.label2.SizeF = new System.Drawing.SizeF(60F, 60F);
         this.label2.StylePriority.UseBorders = false;
         this.label2.StylePriority.UseFont = false;
         this.label2.StylePriority.UseTextAlignment = false;
         this.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // TestReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
         this.DesignerOptions.ShowExportWarnings = false;
         this.DisplayName = "V_VerordnungKrankenpflege.repx";
         this.Dpi = 254F;
         this.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
         this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
         this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 47.625F, 0F);
         this.PageHeight = 2970;
         this.PageWidth = 2100;
         this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
         this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
         this.RequestParameters = false;
         this.ScriptsSource = "\r\nprivate void label2_BeforePrint(object sender, System.ComponentModel.CancelEven" +
    "tArgs e)\r\n{\r\n   (sender as XRControl).Text = \"X\";\r\n}\r\n";
         this.SnapGridSize = 25F;
         this.Version = "24.2";
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

      #endregion

      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.XRLabel label3;
      private DevExpress.XtraReports.UI.XRLabel label2;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
   }
}
