namespace _Hell_BTC_e_Monitor
{
    partial class fIndex
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Default", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Default", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Default", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Default", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Cource", System.Windows.Forms.HorizontalAlignment.Left);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvProfile = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPrices = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvMyTrade = new System.Windows.Forms.ListView();
            this.gbTrades = new System.Windows.Forms.GroupBox();
            this.lvTrades = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssError = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTrades.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvProfile);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 260);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My profile:";
            // 
            // lvProfile
            // 
            this.lvProfile.FullRowSelect = true;
            this.lvProfile.GridLines = true;
            listViewGroup1.Header = "Default";
            listViewGroup1.Name = "Default";
            this.lvProfile.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvProfile.Location = new System.Drawing.Point(6, 19);
            this.lvProfile.MultiSelect = false;
            this.lvProfile.Name = "lvProfile";
            this.lvProfile.ShowGroups = false;
            this.lvProfile.Size = new System.Drawing.Size(360, 235);
            this.lvProfile.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvProfile.TabIndex = 0;
            this.lvProfile.UseCompatibleStateImageBehavior = false;
            this.lvProfile.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvPrices);
            this.groupBox2.Location = new System.Drawing.Point(12, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prices:";
            // 
            // lvPrices
            // 
            this.lvPrices.FullRowSelect = true;
            this.lvPrices.GridLines = true;
            listViewGroup2.Header = "Default";
            listViewGroup2.Name = "Default";
            this.lvPrices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lvPrices.Location = new System.Drawing.Point(6, 19);
            this.lvPrices.MultiSelect = false;
            this.lvPrices.Name = "lvPrices";
            this.lvPrices.ShowGroups = false;
            this.lvPrices.Size = new System.Drawing.Size(360, 219);
            this.lvPrices.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvPrices.TabIndex = 0;
            this.lvPrices.UseCompatibleStateImageBehavior = false;
            this.lvPrices.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvMyTrade);
            this.groupBox3.Location = new System.Drawing.Point(399, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 260);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My trades:";
            // 
            // lvMyTrade
            // 
            this.lvMyTrade.FullRowSelect = true;
            this.lvMyTrade.GridLines = true;
            listViewGroup3.Header = "Default";
            listViewGroup3.Name = "Default";
            this.lvMyTrade.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.lvMyTrade.Location = new System.Drawing.Point(6, 19);
            this.lvMyTrade.MultiSelect = false;
            this.lvMyTrade.Name = "lvMyTrade";
            this.lvMyTrade.ShowGroups = false;
            this.lvMyTrade.Size = new System.Drawing.Size(361, 235);
            this.lvMyTrade.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvMyTrade.TabIndex = 0;
            this.lvMyTrade.UseCompatibleStateImageBehavior = false;
            this.lvMyTrade.View = System.Windows.Forms.View.Details;
            // 
            // gbTrades
            // 
            this.gbTrades.Controls.Add(this.lvTrades);
            this.gbTrades.Location = new System.Drawing.Point(399, 293);
            this.gbTrades.Name = "gbTrades";
            this.gbTrades.Size = new System.Drawing.Size(373, 244);
            this.gbTrades.TabIndex = 5;
            this.gbTrades.TabStop = false;
            this.gbTrades.Text = "Trades:";
            // 
            // lvTrades
            // 
            this.lvTrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTrades.FullRowSelect = true;
            this.lvTrades.GridLines = true;
            listViewGroup4.Header = "Default";
            listViewGroup4.Name = "Default";
            listViewGroup5.Header = "Cource";
            listViewGroup5.Name = "listViewGroup1";
            this.lvTrades.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5});
            this.lvTrades.Location = new System.Drawing.Point(6, 19);
            this.lvTrades.MultiSelect = false;
            this.lvTrades.Name = "lvTrades";
            this.lvTrades.ShowGroups = false;
            this.lvTrades.Size = new System.Drawing.Size(361, 219);
            this.lvTrades.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTrades.TabIndex = 0;
            this.lvTrades.UseCompatibleStateImageBehavior = false;
            this.lvTrades.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tssError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "Status: offline";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tssError
            // 
            this.tssError.Name = "tssError";
            this.tssError.Size = new System.Drawing.Size(58, 17);
            this.tssError.Text = "Error: null";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pair";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Currency";
            this.columnHeader2.Width = 225;
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbTrades);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbTrades.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvProfile;
        private System.Windows.Forms.ListView lvPrices;
        private System.Windows.Forms.ListView lvMyTrade;
        private System.Windows.Forms.GroupBox gbTrades;
        private System.Windows.Forms.ListView lvTrades;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssError;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

