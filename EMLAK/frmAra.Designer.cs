namespace EMLAK
{
    partial class frmAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAra));
            this.dgvAra = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtMaxMetrekare = new System.Windows.Forms.TextBox();
            this.txtMinMetrekare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbİslemTuru = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvAra = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAra
            // 
            this.dgvAra.AllowUserToAddRows = false;
            this.dgvAra.AllowUserToDeleteRows = false;
            this.dgvAra.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAra.Location = new System.Drawing.Point(0, 146);
            this.dgvAra.MultiSelect = false;
            this.dgvAra.Name = "dgvAra";
            this.dgvAra.ReadOnly = true;
            this.dgvAra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAra.Size = new System.Drawing.Size(796, 246);
            this.dgvAra.TabIndex = 1;
            this.dgvAra.DoubleClick += new System.EventHandler(this.dgvAra_DoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(711, 34);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(72, 43);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtMaxMetrekare
            // 
            this.txtMaxMetrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxMetrekare.Location = new System.Drawing.Point(225, 65);
            this.txtMaxMetrekare.MaxLength = 10;
            this.txtMaxMetrekare.Name = "txtMaxMetrekare";
            this.txtMaxMetrekare.Size = new System.Drawing.Size(71, 22);
            this.txtMaxMetrekare.TabIndex = 5;
            this.txtMaxMetrekare.Text = "0";
            // 
            // txtMinMetrekare
            // 
            this.txtMinMetrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinMetrekare.Location = new System.Drawing.Point(146, 65);
            this.txtMinMetrekare.MaxLength = 10;
            this.txtMinMetrekare.Name = "txtMinMetrekare";
            this.txtMinMetrekare.Size = new System.Drawing.Size(71, 22);
            this.txtMinMetrekare.TabIndex = 4;
            this.txtMinMetrekare.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxFiyat.Location = new System.Drawing.Point(225, 32);
            this.txtMaxFiyat.MaxLength = 10;
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(71, 22);
            this.txtMaxFiyat.TabIndex = 3;
            this.txtMaxFiyat.Text = "0";
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinFiyat.Location = new System.Drawing.Point(146, 32);
            this.txtMinFiyat.MaxLength = 10;
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(71, 22);
            this.txtMinFiyat.TabIndex = 2;
            this.txtMinFiyat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(215, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(302, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 16);
            this.label21.TabIndex = 25;
            this.label21.Text = "m²";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(26, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "Metrekare:";
            // 
            // cbİslemTuru
            // 
            this.cbİslemTuru.DropDownHeight = 212;
            this.cbİslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbİslemTuru.DropDownWidth = 165;
            this.cbİslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbİslemTuru.FormattingEnabled = true;
            this.cbİslemTuru.IntegralHeight = false;
            this.cbİslemTuru.Items.AddRange(new object[] {
            "Konut - Kiralık",
            "Konut - Satılık",
            "İşyeri  - Kiralık",
            "İşyeri - Satılık",
            "Arsa"});
            this.cbİslemTuru.Location = new System.Drawing.Point(502, 27);
            this.cbİslemTuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbİslemTuru.Name = "cbİslemTuru";
            this.cbİslemTuru.Size = new System.Drawing.Size(153, 24);
            this.cbİslemTuru.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(400, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "İşlem Türü :";
            // 
            // txtil
            // 
            this.txtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtil.Location = new System.Drawing.Point(502, 68);
            this.txtil.Name = "txtil";
            this.txtil.Size = new System.Drawing.Size(153, 22);
            this.txtil.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(385, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Adres / Şehir :";
            // 
            // lvAra
            // 
            this.lvAra.Location = new System.Drawing.Point(0, 146);
            this.lvAra.Name = "lvAra";
            this.lvAra.Size = new System.Drawing.Size(10, 10);
            this.lvAra.TabIndex = 40;
            this.lvAra.UseCompatibleStateImageBehavior = false;
            this.lvAra.Visible = false;
            // 
            // frmAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 392);
            this.Controls.Add(this.lvAra);
            this.Controls.Add(this.txtil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbİslemTuru);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMaxMetrekare);
            this.Controls.Add(this.txtMinMetrekare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dgvAra);
            this.Name = "frmAra";
            this.Text = "Emlak Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtMaxMetrekare;
        private System.Windows.Forms.TextBox txtMinMetrekare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbİslemTuru;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvAra;
    }
}