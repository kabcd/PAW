namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lv_lstLucrari = new System.Windows.Forms.ListView();
            this.codL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denumL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectiuni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb_lstSectiuni = new System.Windows.Forms.ComboBox();
            this.lb_sectiuni = new System.Windows.Forms.Label();
            this.lb_lucrari = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_sectiuni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_durata_totala = new System.Windows.Forms.Label();
            this.tb_durata_totala = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_lstLucrari
            // 
            this.lv_lstLucrari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codL,
            this.denumL,
            this.sectiuni});
            this.lv_lstLucrari.Location = new System.Drawing.Point(123, 90);
            this.lv_lstLucrari.Name = "lv_lstLucrari";
            this.lv_lstLucrari.Size = new System.Drawing.Size(304, 262);
            this.lv_lstLucrari.TabIndex = 0;
            this.lv_lstLucrari.UseCompatibleStateImageBehavior = false;
            this.lv_lstLucrari.View = System.Windows.Forms.View.Details;
            this.lv_lstLucrari.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_lstLucrari_MouseClick);
            // 
            // codL
            // 
            this.codL.Text = "codL";
            this.codL.Width = 99;
            // 
            // denumL
            // 
            this.denumL.Text = "denumL";
            this.denumL.Width = 93;
            // 
            // sectiuni
            // 
            this.sectiuni.Text = "sectiuni";
            this.sectiuni.Width = 96;
            // 
            // cb_lstSectiuni
            // 
            this.cb_lstSectiuni.FormattingEnabled = true;
            this.cb_lstSectiuni.Location = new System.Drawing.Point(591, 90);
            this.cb_lstSectiuni.Name = "cb_lstSectiuni";
            this.cb_lstSectiuni.Size = new System.Drawing.Size(121, 21);
            this.cb_lstSectiuni.TabIndex = 1;
            this.cb_lstSectiuni.SelectionChangeCommitted += new System.EventHandler(this.cb_lstSectiuni_SelectionChangeCommitted);
            // 
            // lb_sectiuni
            // 
            this.lb_sectiuni.AutoSize = true;
            this.lb_sectiuni.Location = new System.Drawing.Point(496, 93);
            this.lb_sectiuni.Name = "lb_sectiuni";
            this.lb_sectiuni.Size = new System.Drawing.Size(45, 13);
            this.lb_sectiuni.TabIndex = 2;
            this.lb_sectiuni.Text = "Sectiuni";
            // 
            // lb_lucrari
            // 
            this.lb_lucrari.AutoSize = true;
            this.lb_lucrari.Location = new System.Drawing.Point(27, 90);
            this.lb_lucrari.Name = "lb_lucrari";
            this.lb_lucrari.Size = new System.Drawing.Size(39, 13);
            this.lb_lucrari.TabIndex = 3;
            this.lb_lucrari.Text = "Lucrari";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // lv_sectiuni
            // 
            this.lv_sectiuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_sectiuni.Location = new System.Drawing.Point(499, 139);
            this.lv_sectiuni.Name = "lv_sectiuni";
            this.lv_sectiuni.Size = new System.Drawing.Size(253, 174);
            this.lv_sectiuni.TabIndex = 5;
            this.lv_sectiuni.UseCompatibleStateImageBehavior = false;
            this.lv_sectiuni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CodL";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DenumL";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sectiuni";
            // 
            // lb_durata_totala
            // 
            this.lb_durata_totala.AutoSize = true;
            this.lb_durata_totala.Location = new System.Drawing.Point(496, 339);
            this.lb_durata_totala.Name = "lb_durata_totala";
            this.lb_durata_totala.Size = new System.Drawing.Size(68, 13);
            this.lb_durata_totala.TabIndex = 6;
            this.lb_durata_totala.Text = "Durata totala";
            // 
            // tb_durata_totala
            // 
            this.tb_durata_totala.Location = new System.Drawing.Point(612, 339);
            this.tb_durata_totala.Name = "tb_durata_totala";
            this.tb_durata_totala.Size = new System.Drawing.Size(100, 20);
            this.tb_durata_totala.TabIndex = 7;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.Controls.Add(this.tb_durata_totala);
            this.Controls.Add(this.lb_durata_totala);
            this.Controls.Add(this.lv_sectiuni);
            this.Controls.Add(this.lb_lucrari);
            this.Controls.Add(this.lb_sectiuni);
            this.Controls.Add(this.cb_lstSectiuni);
            this.Controls.Add(this.lv_lstLucrari);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_lstLucrari;
        private System.Windows.Forms.ComboBox cb_lstSectiuni;
        private System.Windows.Forms.Label lb_sectiuni;
        private System.Windows.Forms.Label lb_lucrari;
        private System.Windows.Forms.ColumnHeader codL;
        private System.Windows.Forms.ColumnHeader denumL;
        private System.Windows.Forms.ColumnHeader sectiuni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ListView lv_sectiuni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lb_durata_totala;
        private System.Windows.Forms.TextBox tb_durata_totala;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

