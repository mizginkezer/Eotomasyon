
namespace _emlak_otomasyon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.kullanici = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.Button();
            this.kiralik = new System.Windows.Forms.Button();
            this.satilik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(-10, -24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1547, 702);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // kapat
            // 
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.Image = ((System.Drawing.Image)(resources.GetObject("kapat.Image")));
            this.kapat.Location = new System.Drawing.Point(157, 332);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(83, 81);
            this.kapat.TabIndex = 12;
            this.kapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // kullanici
            // 
            this.kullanici.Image = ((System.Drawing.Image)(resources.GetObject("kullanici.Image")));
            this.kullanici.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kullanici.Location = new System.Drawing.Point(203, 91);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(116, 106);
            this.kullanici.TabIndex = 11;
            this.kullanici.Text = "Kullanıcılar";
            this.kullanici.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kullanici.UseVisualStyleBackColor = true;
            this.kullanici.Click += new System.EventHandler(this.kullanici_Click);
            // 
            // arama
            // 
            this.arama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.arama.Image = ((System.Drawing.Image)(resources.GetObject("arama.Image")));
            this.arama.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.arama.Location = new System.Drawing.Point(80, 91);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(116, 106);
            this.arama.TabIndex = 10;
            this.arama.Text = "Arama";
            this.arama.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.arama.UseVisualStyleBackColor = false;
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // kiralik
            // 
            this.kiralik.Image = ((System.Drawing.Image)(resources.GetObject("kiralik.Image")));
            this.kiralik.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kiralik.Location = new System.Drawing.Point(203, 203);
            this.kiralik.Name = "kiralik";
            this.kiralik.Size = new System.Drawing.Size(116, 106);
            this.kiralik.TabIndex = 9;
            this.kiralik.Text = "Kiralık";
            this.kiralik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kiralik.UseVisualStyleBackColor = true;
            this.kiralik.Click += new System.EventHandler(this.kiralik_Click);
            // 
            // satilik
            // 
            this.satilik.Image = ((System.Drawing.Image)(resources.GetObject("satilik.Image")));
            this.satilik.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satilik.Location = new System.Drawing.Point(80, 203);
            this.satilik.Name = "satilik";
            this.satilik.Size = new System.Drawing.Size(116, 106);
            this.satilik.TabIndex = 8;
            this.satilik.Text = "Satılık";
            this.satilik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satilik.UseVisualStyleBackColor = true;
            this.satilik.Click += new System.EventHandler(this.satilik_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 598);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.kiralik);
            this.Controls.Add(this.satilik);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZMD Emlak Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button kullanici;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.Button kiralik;
        private System.Windows.Forms.Button satilik;
    }
}