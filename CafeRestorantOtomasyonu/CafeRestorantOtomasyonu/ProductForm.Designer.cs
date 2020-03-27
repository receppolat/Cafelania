namespace CafeRestorantOtomasyonu
{
    partial class ProductForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.cbtur = new System.Windows.Forms.ComboBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunid,
            this.ad,
            this.tur,
            this.fiyat});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(6, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 470);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // urunid
            // 
            this.urunid.Text = "Ürün ID";
            this.urunid.Width = 100;
            // 
            // ad
            // 
            this.ad.Text = "Ürün Adı";
            this.ad.Width = 105;
            // 
            // tur
            // 
            this.tur.Text = "Ürün Türü";
            this.tur.Width = 105;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Ürün Fiyatı";
            this.fiyat.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsearch.Location = new System.Drawing.Point(112, 25);
            this.tbsearch.Multiline = true;
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(179, 27);
            this.tbsearch.TabIndex = 3;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-106, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tbsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Adı:";
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(135, 34);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(121, 22);
            this.tbadi.TabIndex = 5;
            // 
            // cbtur
            // 
            this.cbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtur.FormattingEnabled = true;
            this.cbtur.Location = new System.Drawing.Point(135, 77);
            this.cbtur.Name = "cbtur";
            this.cbtur.Size = new System.Drawing.Size(121, 24);
            this.cbtur.TabIndex = 6;
            // 
            // tbfiyat
            // 
            this.tbfiyat.Location = new System.Drawing.Point(135, 118);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.Size = new System.Drawing.Size(121, 22);
            this.tbfiyat.TabIndex = 7;
            // 
            // btnekle
            // 
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(29, 153);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 44);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(166, 153);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 44);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.ForeColor = System.Drawing.Color.Black;
            this.btnduzenle.Location = new System.Drawing.Point(301, 153);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(75, 44);
            this.btnduzenle.TabIndex = 10;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnduzenle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnekle);
            this.groupBox2.Controls.Add(this.tbfiyat);
            this.groupBox2.Controls.Add(this.cbtur);
            this.groupBox2.Controls.Add(this.tbadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(588, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncikis.BackgroundImage")));
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Location = new System.Drawing.Point(1093, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(43, 34);
            this.btncikis.TabIndex = 2;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "CAFELANIA | Ürünler";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAFELANIA | Ürünler";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urunid;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader tur;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.ComboBox cbtur;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label label2;
    }
}