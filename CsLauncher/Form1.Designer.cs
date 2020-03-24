namespace CsLauncher
{
    partial class LauncherForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.PathListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addFromCBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openQSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divideSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathListBox
            // 
            this.PathListBox.AllowDrop = true;
            this.PathListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathListBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathListBox.FormattingEnabled = true;
            this.PathListBox.ItemHeight = 16;
            this.PathListBox.Location = new System.Drawing.Point(22, 4);
            this.PathListBox.Name = "PathListBox";
            this.PathListBox.Size = new System.Drawing.Size(774, 418);
            this.PathListBox.TabIndex = 0;
            this.PathListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathListBox_DragDrop);
            this.PathListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathListBox_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFromCBToolStripMenuItem,
            this.qSaveToolStripMenuItem,
            this.qLoadToolStripMenuItem,
            this.openQSaveToolStripMenuItem,
            this.saveListToolStripMenuItem,
            this.divideSaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addFromCBToolStripMenuItem
            // 
            this.addFromCBToolStripMenuItem.Name = "addFromCBToolStripMenuItem";
            this.addFromCBToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.addFromCBToolStripMenuItem.Text = "AddFromCB";
            this.addFromCBToolStripMenuItem.Click += new System.EventHandler(this.addFromCBToolStripMenuItem_Click);
            // 
            // qSaveToolStripMenuItem
            // 
            this.qSaveToolStripMenuItem.Name = "qSaveToolStripMenuItem";
            this.qSaveToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.qSaveToolStripMenuItem.Text = "QSave";
            this.qSaveToolStripMenuItem.Click += new System.EventHandler(this.quickSaveToolStripMenuItem_Click);
            // 
            // qLoadToolStripMenuItem
            // 
            this.qLoadToolStripMenuItem.Name = "qLoadToolStripMenuItem";
            this.qLoadToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.qLoadToolStripMenuItem.Text = "QLoad";
            this.qLoadToolStripMenuItem.Click += new System.EventHandler(this.quickLoadToolStripMenuItem_Click);
            // 
            // openQSaveToolStripMenuItem
            // 
            this.openQSaveToolStripMenuItem.Name = "openQSaveToolStripMenuItem";
            this.openQSaveToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.openQSaveToolStripMenuItem.Text = "OpenQSave";
            this.openQSaveToolStripMenuItem.Click += new System.EventHandler(this.OpenQSaveToolStripMenuItem_Click);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.saveListToolStripMenuItem.Text = "SaveList";
            // 
            // divideSaveToolStripMenuItem
            // 
            this.divideSaveToolStripMenuItem.Name = "divideSaveToolStripMenuItem";
            this.divideSaveToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.divideSaveToolStripMenuItem.Text = "DivideSave";
            this.divideSaveToolStripMenuItem.Click += new System.EventHandler(this.divideSaveToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.252816F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.74718F));
            this.tableLayoutPanel1.Controls.Add(this.PathListBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Layout_Paint);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LauncherForm";
            this.Text = "CsLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LauncherForm_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PathListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFromCBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLoadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem openQSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divideSaveToolStripMenuItem;
    }
}

