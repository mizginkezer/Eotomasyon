
namespace _emlak_otomasyon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rbtnKiralikKonut = new System.Windows.Forms.RadioButton();
            this.rbtnSatilikKonut = new System.Windows.Forms.RadioButton();
            this.txtMaxMetrekare = new System.Windows.Forms.TextBox();
            this.txtMinMetrekare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxFiyat = new System.Windows.Forms.TextBox();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cbIsitma = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbEmlakTipi = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlaktipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isitma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnKiralikKonut
            // 
            this.rbtnKiralikKonut.AutoSize = true;
            this.rbtnKiralikKonut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnKiralikKonut.Location = new System.Drawing.Point(388, 129);
            this.rbtnKiralikKonut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnKiralikKonut.Name = "rbtnKiralikKonut";
            this.rbtnKiralikKonut.Size = new System.Drawing.Size(150, 29);
            this.rbtnKiralikKonut.TabIndex = 43;
            this.rbtnKiralikKonut.Text = "Kiralık Konut";
            this.rbtnKiralikKonut.UseVisualStyleBackColor = true;
            // 
            // rbtnSatilikKonut
            // 
            this.rbtnSatilikKonut.AutoSize = true;
            this.rbtnSatilikKonut.Checked = true;
            this.rbtnSatilikKonut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnSatilikKonut.Location = new System.Drawing.Point(244, 129);
            this.rbtnSatilikKonut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnSatilikKonut.Name = "rbtnSatilikKonut";
            this.rbtnSatilikKonut.Size = new System.Drawing.Size(146, 29);
            this.rbtnSatilikKonut.TabIndex = 42;
            this.rbtnSatilikKonut.TabStop = true;
            this.rbtnSatilikKonut.Text = "Satılık Konut";
            this.rbtnSatilikKonut.UseVisualStyleBackColor = true;
            // 
            // txtMaxMetrekare
            // 
            this.txtMaxMetrekare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxMetrekare.Location = new System.Drawing.Point(299, 71);
            this.txtMaxMetrekare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxMetrekare.MaxLength = 10;
            this.txtMaxMetrekare.Name = "txtMaxMetrekare";
            this.txtMaxMetrekare.Size = new System.Drawing.Size(68, 29);
            this.txtMaxMetrekare.TabIndex = 40;
            this.txtMaxMetrekare.Text = "0";
            // 
            // txtMinMetrekare
            // 
            this.txtMinMetrekare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinMetrekare.Location = new System.Drawing.Point(218, 71);
            this.txtMinMetrekare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinMetrekare.MaxLength = 10;
            this.txtMinMetrekare.Name = "txtMinMetrekare";
            this.txtMinMetrekare.Size = new System.Drawing.Size(68, 29);
            this.txtMinMetrekare.TabIndex = 39;
            this.txtMinMetrekare.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(284, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "-";
            // 
            // txtMaxFiyat
            // 
            this.txtMaxFiyat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaxFiyat.Location = new System.Drawing.Point(299, 29);
            this.txtMaxFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxFiyat.MaxLength = 10;
            this.txtMaxFiyat.Name = "txtMaxFiyat";
            this.txtMaxFiyat.Size = new System.Drawing.Size(68, 29);
            this.txtMaxFiyat.TabIndex = 36;
            this.txtMaxFiyat.Text = "0";
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinFiyat.Location = new System.Drawing.Point(218, 28);
            this.txtMinFiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinFiyat.MaxLength = 10;
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(68, 29);
            this.txtMinFiyat.TabIndex = 35;
            this.txtMinFiyat.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(285, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(335, 168);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(104, 56);
            this.btnAra.TabIndex = 34;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cbIsitma
            // 
            this.cbIsitma.DropDownHeight = 165;
            this.cbIsitma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsitma.DropDownWidth = 185;
            this.cbIsitma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIsitma.FormattingEnabled = true;
            this.cbIsitma.IntegralHeight = false;
            this.cbIsitma.Items.AddRange(new object[] {
            "Klima",
            "Merkezi Sistem",
            "Güneş Enerjisi",
            "Kombi (Elektrikli)",
            "Isıtma Sistemi Yok",
            "Jeotermal",
            "Kalorifer (Akaryakıt)",
            "Kalorifer (Doğalgaz)",
            "Kalorifer (Kömür)",
            "Kat Kaloriferi (Akaryakıt)",
            "Kombi (Doğalgaz)",
            "Soba (Doğalgaz)",
            "Soba (Kömür)",
            "Yerden Isıtma"});
            this.cbIsitma.Location = new System.Drawing.Point(500, 72);
            this.cbIsitma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIsitma.Name = "cbIsitma";
            this.cbIsitma.Size = new System.Drawing.Size(153, 28);
            this.cbIsitma.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(388, 75);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "Isıtma:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(88, 71);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 25);
            this.label20.TabIndex = 31;
            this.label20.Text = "Metrekare:";
            // 
            // cbEmlakTipi
            // 
            this.cbEmlakTipi.DropDownHeight = 212;
            this.cbEmlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmlakTipi.DropDownWidth = 165;
            this.cbEmlakTipi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEmlakTipi.FormattingEnabled = true;
            this.cbEmlakTipi.IntegralHeight = false;
            this.cbEmlakTipi.Items.AddRange(new object[] {
            "Ahşap Ev",
            "Apartman",
            "Apartman Dairesi",
            "Çiftlik Evi",
            "Dağ Evi",
            "Daire (Bahçe Dublex)",
            "Daire (Çatı Dublex)",
            "Dublex",
            "Fourlex",
            "İkiz Ev",
            "Köşk",
            "Köy Evi",
            "Malikane",
            "Müstakil Ev",
            "Residence",
            "Stüdyo",
            "Townhouse",
            "Triplex",
            "Villa",
            "Yalı",
            "Taş Ev",
            "Apart"});
            this.cbEmlakTipi.Location = new System.Drawing.Point(500, 29);
            this.cbEmlakTipi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmlakTipi.Name = "cbEmlakTipi";
            this.cbEmlakTipi.Size = new System.Drawing.Size(153, 28);
            this.cbEmlakTipi.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(388, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 25);
            this.label19.TabIndex = 28;
            this.label19.Text = "Emlak Tipi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fiyat,
            this.metre,
            this.emlaktipi,
            this.isitma,
            this.satilik,
            this.kiralik});
            this.dataGridView1.Location = new System.Drawing.Point(11, 233);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(783, 122);
            this.dataGridView1.TabIndex = 44;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat Aralığı";
            this.fiyat.MinimumWidth = 6;
            this.fiyat.Name = "fiyat";
            this.fiyat.Width = 125;
            // 
            // metre
            // 
            this.metre.HeaderText = "Metrekare";
            this.metre.MinimumWidth = 6;
            this.metre.Name = "metre";
            this.metre.Width = 125;
            // 
            // emlaktipi
            // 
            this.emlaktipi.HeaderText = "Emlak Tipi";
            this.emlaktipi.MinimumWidth = 6;
            this.emlaktipi.Name = "emlaktipi";
            this.emlaktipi.Width = 125;
            // 
            // isitma
            // 
            this.isitma.HeaderText = "Isıtma";
            this.isitma.MinimumWidth = 6;
            this.isitma.Name = "isitma";
            this.isitma.Width = 125;
            // 
            // satilik
            // 
            this.satilik.HeaderText = "Satılık";
            this.satilik.MinimumWidth = 6;
            this.satilik.Name = "satilik";
            this.satilik.Width = 125;
            // 
            // kiralik
            // 
            this.kiralik.HeaderText = "Kıralık";
            this.kiralik.MinimumWidth = 6;
            this.kiralik.Name = "kiralik";
            this.kiralik.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(692, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Geri Dön";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(805, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtnKiralikKonut);
            this.Controls.Add(this.rbtnSatilikKonut);
            this.Controls.Add(this.txtMaxMetrekare);
            this.Controls.Add(this.txtMinMetrekare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxFiyat);
            this.Controls.Add(this.txtMinFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbIsitma);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbEmlakTipi);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnKiralikKonut;
        private System.Windows.Forms.RadioButton rbtnSatilikKonut;
        private System.Windows.Forms.TextBox txtMaxMetrekare;
        private System.Windows.Forms.TextBox txtMinMetrekare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxFiyat;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cbIsitma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbEmlakTipi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn metre;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlaktipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isitma;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilik;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralik;
    }
}