namespace EMLAK
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arsaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.araToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konutToolStripMenuItem,
            this.işyeriKayıtToolStripMenuItem,
            this.arsaKayıtToolStripMenuItem,
            this.müşteriKayıtToolStripMenuItem});
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.kayıtToolStripMenuItem.Text = "&KAYIT";
            // 
            // konutToolStripMenuItem
            // 
            this.konutToolStripMenuItem.Name = "konutToolStripMenuItem";
            this.konutToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.konutToolStripMenuItem.Text = "&Konut Kayıt";
            this.konutToolStripMenuItem.Click += new System.EventHandler(this.konutToolStripMenuItem_Click);
            // 
            // işyeriKayıtToolStripMenuItem
            // 
            this.işyeriKayıtToolStripMenuItem.Name = "işyeriKayıtToolStripMenuItem";
            this.işyeriKayıtToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.işyeriKayıtToolStripMenuItem.Text = "&İşyeri Kayıt";
            this.işyeriKayıtToolStripMenuItem.Click += new System.EventHandler(this.işyeriKayıtToolStripMenuItem_Click);
            // 
            // arsaKayıtToolStripMenuItem
            // 
            this.arsaKayıtToolStripMenuItem.Name = "arsaKayıtToolStripMenuItem";
            this.arsaKayıtToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.arsaKayıtToolStripMenuItem.Text = "&Arsa Kayıt";
            this.arsaKayıtToolStripMenuItem.Click += new System.EventHandler(this.arsaKayıtToolStripMenuItem_Click);
            // 
            // müşteriKayıtToolStripMenuItem
            // 
            this.müşteriKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satıcıToolStripMenuItem,
            this.alıcıToolStripMenuItem});
            this.müşteriKayıtToolStripMenuItem.Name = "müşteriKayıtToolStripMenuItem";
            this.müşteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.müşteriKayıtToolStripMenuItem.Text = "&Müşteri Kayıt";
            // 
            // satıcıToolStripMenuItem
            // 
            this.satıcıToolStripMenuItem.Name = "satıcıToolStripMenuItem";
            this.satıcıToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.satıcıToolStripMenuItem.Text = "Satıcı";
            this.satıcıToolStripMenuItem.Click += new System.EventHandler(this.satıcıToolStripMenuItem_Click);
            // 
            // alıcıToolStripMenuItem
            // 
            this.alıcıToolStripMenuItem.Name = "alıcıToolStripMenuItem";
            this.alıcıToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.alıcıToolStripMenuItem.Text = "Alıcı";
            this.alıcıToolStripMenuItem.Click += new System.EventHandler(this.alıcıToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.araToolStripMenuItem.Text = "&ARA";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.raporlamaToolStripMenuItem.Text = "&RAPORLAMA";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cikisToolStripMenuItem.Image")));
            this.cikisToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.cikisToolStripMenuItem.Text = "&ÇIKIŞ";
            this.cikisToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 470);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnasayfa";
            this.Text = "EMLAK İŞLEMLERİ";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arsaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alıcıToolStripMenuItem;
    }
}