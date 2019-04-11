namespace KaraokeManager
{
    partial class NewManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanli = new System.Windows.Forms.ToolStripMenuItem();
            this.âmNhạcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuantri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrangchu,
            this.menuQuanli,
            this.menuQuantri,
            this.menuTTNV,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTrangchu
            // 
            this.menuTrangchu.Name = "menuTrangchu";
            this.menuTrangchu.Size = new System.Drawing.Size(75, 20);
            this.menuTrangchu.Text = "Trang chủ ";
            // 
            // menuQuanli
            // 
            this.menuQuanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.âmNhạcToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.mónĂnToolStripMenuItem});
            this.menuQuanli.Name = "menuQuanli";
            this.menuQuanli.Size = new System.Drawing.Size(57, 20);
            this.menuQuanli.Text = "Quản lí";
            // 
            // âmNhạcToolStripMenuItem
            // 
            this.âmNhạcToolStripMenuItem.Name = "âmNhạcToolStripMenuItem";
            this.âmNhạcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.âmNhạcToolStripMenuItem.Text = "Âm nhạc";
            this.âmNhạcToolStripMenuItem.Click += new System.EventHandler(this.âmNhạcToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mónĂnToolStripMenuItem.Text = "Món ăn";
            this.mónĂnToolStripMenuItem.Click += new System.EventHandler(this.mónĂnToolStripMenuItem_Click);
            // 
            // menuQuantri
            // 
            this.menuQuantri.Name = "menuQuantri";
            this.menuQuantri.Size = new System.Drawing.Size(62, 20);
            this.menuQuantri.Text = "Quản trị";
            this.menuQuantri.Click += new System.EventHandler(this.menuQuantri_Click);
            // 
            // menuTTNV
            // 
            this.menuTTNV.Name = "menuTTNV";
            this.menuTTNV.Size = new System.Drawing.Size(126, 20);
            this.menuTTNV.Text = "Thông tin nhân viên";
            this.menuTTNV.Click += new System.EventHandler(this.menuTTNV_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(50, 20);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1,
            this.noDocumentsView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // NewManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewManagerForm";
            this.Text = "NewManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTrangchu;
        private System.Windows.Forms.ToolStripMenuItem menuQuanli;
        private System.Windows.Forms.ToolStripMenuItem âmNhạcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuantri;
        private System.Windows.Forms.ToolStripMenuItem menuTTNV;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
    }
}