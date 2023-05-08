namespace IsletimSistemleriDonemProjesi
{
    partial class GorevYoneticisi
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
            this.grpProcessApp = new System.Windows.Forms.GroupBox();
            this.dataGridViewProcessApp = new System.Windows.Forms.DataGridView();
            this.btnKill = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAllItemKill = new System.Windows.Forms.Button();
            this.grpProcessApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessApp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcessApp
            // 
            this.grpProcessApp.Controls.Add(this.dataGridViewProcessApp);
            this.grpProcessApp.Location = new System.Drawing.Point(12, 86);
            this.grpProcessApp.Name = "grpProcessApp";
            this.grpProcessApp.Size = new System.Drawing.Size(678, 301);
            this.grpProcessApp.TabIndex = 5;
            this.grpProcessApp.TabStop = false;
            this.grpProcessApp.Text = "ÇALIŞAN UYGULAMALAR";
            // 
            // dataGridViewProcessApp
            // 
            this.dataGridViewProcessApp.AllowUserToAddRows = false;
            this.dataGridViewProcessApp.AllowUserToDeleteRows = false;
            this.dataGridViewProcessApp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProcessApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcessApp.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewProcessApp.Name = "dataGridViewProcessApp";
            this.dataGridViewProcessApp.ReadOnly = true;
            this.dataGridViewProcessApp.RowTemplate.ReadOnly = true;
            this.dataGridViewProcessApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcessApp.Size = new System.Drawing.Size(672, 282);
            this.dataGridViewProcessApp.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(510, 390);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(174, 23);
            this.btnKill.TabIndex = 6;
            this.btnKill.Text = "GÖREVİ SONLANDIR";
            this.toolTip1.SetToolTip(this.btnKill, "Listede seçili, uygulamayı direkt kapatır.");
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(609, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnAllItemKill
            // 
            this.btnAllItemKill.Location = new System.Drawing.Point(15, 390);
            this.btnAllItemKill.Name = "btnAllItemKill";
            this.btnAllItemKill.Size = new System.Drawing.Size(148, 23);
            this.btnAllItemKill.TabIndex = 9;
            this.btnAllItemKill.Text = "TÜMÜNÜ SONLANDIR";
            this.btnAllItemKill.UseVisualStyleBackColor = true;
            this.btnAllItemKill.Click += new System.EventHandler(this.btnAllItemKill_Click_1);
            // 
            // GorevYoneticisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 423);
            this.Controls.Add(this.grpProcessApp);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAllItemKill);
            this.Name = "GorevYoneticisi";
            this.Text = "GorevYoneticisi";
            this.Load += new System.EventHandler(this.GorevYoneticisi_Load);
            this.grpProcessApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessApp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcessApp;
        private System.Windows.Forms.DataGridView dataGridViewProcessApp;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAllItemKill;
    }
}