namespace OpenLibrary.Presentation
{
    partial class OpenLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenLibrary));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ribbon1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btndangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ribbon1
            // 
            this.ribbon1.ExpandCollapseItem.Id = 0;
            this.ribbon1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon1.ExpandCollapseItem,
            this.ribbon1.SearchEditItem,
            this.btndangnhap,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.MaxItemId = 13;
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon1.Size = new System.Drawing.Size(2008, 292);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Caption = "Đăng nhập";
            this.btndangnhap.Id = 1;
            this.btndangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.ImageOptions.Image")));
            this.btndangnhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndangnhap.ImageOptions.LargeImage")));
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thông tin cá nhân";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đổi mật ";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản Lý Chi Nhánh";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Quản Lý Chuyên Ngành";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.fullstackedbar2_16x16;
            this.barButtonItem5.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.fullstackedbar2_32x32;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Quản Lý Sách";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.content_16x16;
            this.barButtonItem6.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.content_32x32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Phân Bổ Sách";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.switchrowcolumn_16x16;
            this.barButtonItem7.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.switchrowcolumn_32x32;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thống Kê Yêu Cầu Mua Sách";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.bar_16x16;
            this.barButtonItem8.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.bar_32x32;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Quản Lý Độc Giả";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.employee_16x16;
            this.barButtonItem9.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.employee_32x32;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Quản Lý Mượn Trả Sách";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.chartsrotate_16x16;
            this.barButtonItem10.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.chartsrotate_32x32;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Quản Lý Loại Nhân Viên";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.publicfix_16x16;
            this.barButtonItem11.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.publicfix_32x32;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Quản Lý Nhân Viên";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.ImageOptions.Image = global::OpenLibrary.Presentation.Properties.Resources.boemployee_16x16;
            this.barButtonItem12.ImageOptions.LargeImage = global::OpenLibrary.Presentation.Properties.Resources.boemployee_32x32;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroup1,
            this.rbPageGroup2,
            this.rbPageGroup3,
            this.rbPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // rbPageGroup1
            // 
            this.rbPageGroup1.ItemLinks.Add(this.btndangnhap);
            this.rbPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.rbPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.rbPageGroup1.Name = "rbPageGroup1";
            this.rbPageGroup1.Text = "Hệ Thống";
            // 
            // rbPageGroup2
            // 
            this.rbPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.rbPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.rbPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.rbPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.rbPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.rbPageGroup2.Name = "rbPageGroup2";
            this.rbPageGroup2.Text = "Quản Lý Tài Nguyên";
            // 
            // rbPageGroup3
            // 
            this.rbPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.rbPageGroup3.ItemLinks.Add(this.barButtonItem10);
            this.rbPageGroup3.Name = "rbPageGroup3";
            this.rbPageGroup3.Text = "Quản Lý Mượn Trả Sách";
            // 
            // rbPageGroup4
            // 
            this.rbPageGroup4.ItemLinks.Add(this.barButtonItem11);
            this.rbPageGroup4.ItemLinks.Add(this.barButtonItem12);
            this.rbPageGroup4.Name = "rbPageGroup4";
            this.rbPageGroup4.Text = "Phân Quyền Hệ Thống";
            // 
            // OpenLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2008, 728);
            this.Controls.Add(this.ribbon1);
            this.Name = "OpenLibrary";
            this.Text = "OpenLibrary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btndangnhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
    }
}