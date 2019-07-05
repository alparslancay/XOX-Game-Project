namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_ikikisilik = new System.Windows.Forms.RadioButton();
            this.rdo_pckarsi = new System.Windows.Forms.RadioButton();
            this.lbl_oyunsecimi = new System.Windows.Forms.Label();
            this.buton_oyna = new System.Windows.Forms.Button();
            this.rdo_lan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_O = new System.Windows.Forms.RadioButton();
            this.rdo_X = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.txtbx_Port = new System.Windows.Forms.TextBox();
            this.txtbx_Ip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_zor = new System.Windows.Forms.RadioButton();
            this.rdo_kolay = new System.Windows.Forms.RadioButton();
            this.rdo_orta = new System.Windows.Forms.RadioButton();
            this.lbl_oyuncuadi2 = new System.Windows.Forms.Label();
            this.txtbx_oyuncuadi2 = new System.Windows.Forms.TextBox();
            this.lbl_oyuncuadi1 = new System.Windows.Forms.Label();
            this.txtbx_oyuncuadi1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_ikikisilik
            // 
            this.rdo_ikikisilik.AutoSize = true;
            this.rdo_ikikisilik.Location = new System.Drawing.Point(6, 50);
            this.rdo_ikikisilik.Name = "rdo_ikikisilik";
            this.rdo_ikikisilik.Size = new System.Drawing.Size(65, 17);
            this.rdo_ikikisilik.TabIndex = 2;
            this.rdo_ikikisilik.TabStop = true;
            this.rdo_ikikisilik.Text = "İki Kişilik";
            this.rdo_ikikisilik.UseVisualStyleBackColor = true;
            this.rdo_ikikisilik.CheckedChanged += new System.EventHandler(this.rdo_ikikisilik_CheckedChanged);
            // 
            // rdo_pckarsi
            // 
            this.rdo_pckarsi.AutoSize = true;
            this.rdo_pckarsi.Location = new System.Drawing.Point(6, 85);
            this.rdo_pckarsi.Name = "rdo_pckarsi";
            this.rdo_pckarsi.Size = new System.Drawing.Size(101, 17);
            this.rdo_pckarsi.TabIndex = 3;
            this.rdo_pckarsi.TabStop = true;
            this.rdo_pckarsi.Text = "Bilgisayara Karşı";
            this.rdo_pckarsi.UseVisualStyleBackColor = true;
            this.rdo_pckarsi.CheckedChanged += new System.EventHandler(this.rdo_pckarsi_CheckedChanged);
            // 
            // lbl_oyunsecimi
            // 
            this.lbl_oyunsecimi.AutoSize = true;
            this.lbl_oyunsecimi.Location = new System.Drawing.Point(120, 16);
            this.lbl_oyunsecimi.Name = "lbl_oyunsecimi";
            this.lbl_oyunsecimi.Size = new System.Drawing.Size(66, 13);
            this.lbl_oyunsecimi.TabIndex = 4;
            this.lbl_oyunsecimi.Text = "Oyun Seçimi";
            // 
            // buton_oyna
            // 
            this.buton_oyna.Location = new System.Drawing.Point(113, 438);
            this.buton_oyna.Name = "buton_oyna";
            this.buton_oyna.Size = new System.Drawing.Size(101, 52);
            this.buton_oyna.TabIndex = 5;
            this.buton_oyna.Text = "Oyna!";
            this.buton_oyna.UseVisualStyleBackColor = true;
            this.buton_oyna.Click += new System.EventHandler(this.buton_oyna_Click);
            // 
            // rdo_lan
            // 
            this.rdo_lan.AutoSize = true;
            this.rdo_lan.Location = new System.Drawing.Point(6, 124);
            this.rdo_lan.Name = "rdo_lan";
            this.rdo_lan.Size = new System.Drawing.Size(113, 17);
            this.rdo_lan.TabIndex = 6;
            this.rdo_lan.TabStop = true;
            this.rdo_lan.Text = "Yerel Ağ Bağlantısı";
            this.rdo_lan.UseVisualStyleBackColor = true;
            this.rdo_lan.CheckedChanged += new System.EventHandler(this.rdo_lan_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_oyuncuadi2);
            this.groupBox1.Controls.Add(this.txtbx_oyuncuadi2);
            this.groupBox1.Controls.Add(this.lbl_oyuncuadi1);
            this.groupBox1.Controls.Add(this.txtbx_oyuncuadi1);
            this.groupBox1.Controls.Add(this.lbl_oyunsecimi);
            this.groupBox1.Controls.Add(this.rdo_lan);
            this.groupBox1.Controls.Add(this.rdo_ikikisilik);
            this.groupBox1.Controls.Add(this.rdo_pckarsi);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 420);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_O);
            this.groupBox3.Controls.Add(this.rdo_X);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_Port);
            this.groupBox3.Controls.Add(this.lbl_Ip);
            this.groupBox3.Controls.Add(this.txtbx_Port);
            this.groupBox3.Controls.Add(this.txtbx_Ip);
            this.groupBox3.Location = new System.Drawing.Point(6, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 114);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X/O";
            // 
            // rdo_O
            // 
            this.rdo_O.AutoSize = true;
            this.rdo_O.Location = new System.Drawing.Point(137, 91);
            this.rdo_O.Name = "rdo_O";
            this.rdo_O.Size = new System.Drawing.Size(136, 17);
            this.rdo_O.TabIndex = 6;
            this.rdo_O.TabStop = true;
            this.rdo_O.Text = "O\'da oynamak istiyorum";
            this.rdo_O.UseVisualStyleBackColor = true;
            this.rdo_O.CheckedChanged += new System.EventHandler(this.rdo_O_CheckedChanged);
            // 
            // rdo_X
            // 
            this.rdo_X.AutoSize = true;
            this.rdo_X.Location = new System.Drawing.Point(6, 91);
            this.rdo_X.Name = "rdo_X";
            this.rdo_X.Size = new System.Drawing.Size(132, 17);
            this.rdo_X.TabIndex = 5;
            this.rdo_X.TabStop = true;
            this.rdo_X.Text = "X\'te oynamak istiyorum";
            this.rdo_X.UseVisualStyleBackColor = true;
            this.rdo_X.CheckedChanged += new System.EventHandler(this.rdo_X_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "X/O seçeneğini \r\nseçiniz ve \r\ndeğerleri\r\ndeğiştirmeyiniz.";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(7, 58);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(35, 13);
            this.lbl_Port.TabIndex = 3;
            this.lbl_Port.Text = "label2";
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Location = new System.Drawing.Point(7, 22);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ip.TabIndex = 2;
            this.lbl_Ip.Text = "label1";
            // 
            // txtbx_Port
            // 
            this.txtbx_Port.Location = new System.Drawing.Point(63, 55);
            this.txtbx_Port.Name = "txtbx_Port";
            this.txtbx_Port.Size = new System.Drawing.Size(131, 20);
            this.txtbx_Port.TabIndex = 1;
            // 
            // txtbx_Ip
            // 
            this.txtbx_Ip.Location = new System.Drawing.Point(63, 19);
            this.txtbx_Ip.Name = "txtbx_Ip";
            this.txtbx_Ip.Size = new System.Drawing.Size(131, 20);
            this.txtbx_Ip.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_zor);
            this.groupBox2.Controls.Add(this.rdo_kolay);
            this.groupBox2.Controls.Add(this.rdo_orta);
            this.groupBox2.Location = new System.Drawing.Point(24, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 41);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zorluk";
            // 
            // rdo_zor
            // 
            this.rdo_zor.AutoSize = true;
            this.rdo_zor.Location = new System.Drawing.Point(149, 18);
            this.rdo_zor.Name = "rdo_zor";
            this.rdo_zor.Size = new System.Drawing.Size(41, 17);
            this.rdo_zor.TabIndex = 2;
            this.rdo_zor.TabStop = true;
            this.rdo_zor.Text = "Zor";
            this.rdo_zor.UseVisualStyleBackColor = true;
            // 
            // rdo_kolay
            // 
            this.rdo_kolay.AutoSize = true;
            this.rdo_kolay.Location = new System.Drawing.Point(17, 18);
            this.rdo_kolay.Name = "rdo_kolay";
            this.rdo_kolay.Size = new System.Drawing.Size(51, 17);
            this.rdo_kolay.TabIndex = 1;
            this.rdo_kolay.TabStop = true;
            this.rdo_kolay.Text = "Kolay";
            this.rdo_kolay.UseVisualStyleBackColor = true;
            // 
            // rdo_orta
            // 
            this.rdo_orta.AutoSize = true;
            this.rdo_orta.Location = new System.Drawing.Point(84, 18);
            this.rdo_orta.Name = "rdo_orta";
            this.rdo_orta.Size = new System.Drawing.Size(45, 17);
            this.rdo_orta.TabIndex = 0;
            this.rdo_orta.TabStop = true;
            this.rdo_orta.Text = "Orta";
            this.rdo_orta.UseVisualStyleBackColor = true;
            // 
            // lbl_oyuncuadi2
            // 
            this.lbl_oyuncuadi2.AutoSize = true;
            this.lbl_oyuncuadi2.Location = new System.Drawing.Point(21, 209);
            this.lbl_oyuncuadi2.Name = "lbl_oyuncuadi2";
            this.lbl_oyuncuadi2.Size = new System.Drawing.Size(71, 13);
            this.lbl_oyuncuadi2.TabIndex = 10;
            this.lbl_oyuncuadi2.Text = "2.Oyuncu Adı";
            // 
            // txtbx_oyuncuadi2
            // 
            this.txtbx_oyuncuadi2.Location = new System.Drawing.Point(98, 206);
            this.txtbx_oyuncuadi2.Name = "txtbx_oyuncuadi2";
            this.txtbx_oyuncuadi2.Size = new System.Drawing.Size(131, 20);
            this.txtbx_oyuncuadi2.TabIndex = 9;
            // 
            // lbl_oyuncuadi1
            // 
            this.lbl_oyuncuadi1.AutoSize = true;
            this.lbl_oyuncuadi1.Location = new System.Drawing.Point(21, 183);
            this.lbl_oyuncuadi1.Name = "lbl_oyuncuadi1";
            this.lbl_oyuncuadi1.Size = new System.Drawing.Size(71, 13);
            this.lbl_oyuncuadi1.TabIndex = 8;
            this.lbl_oyuncuadi1.Text = "1.Oyuncu Adı";
            // 
            // txtbx_oyuncuadi1
            // 
            this.txtbx_oyuncuadi1.Location = new System.Drawing.Point(98, 180);
            this.txtbx_oyuncuadi1.Name = "txtbx_oyuncuadi1";
            this.txtbx_oyuncuadi1.Size = new System.Drawing.Size(131, 20);
            this.txtbx_oyuncuadi1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.buton_oyna;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buton_oyna);
            this.Name = "Form1";
            this.Text = "iii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_ikikisilik;
        private System.Windows.Forms.RadioButton rdo_pckarsi;
        private System.Windows.Forms.Label lbl_oyunsecimi;
        private System.Windows.Forms.Button buton_oyna;
        private System.Windows.Forms.RadioButton rdo_lan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_oyuncuadi2;
        private System.Windows.Forms.TextBox txtbx_oyuncuadi2;
        private System.Windows.Forms.Label lbl_oyuncuadi1;
        private System.Windows.Forms.TextBox txtbx_oyuncuadi1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_zor;
        private System.Windows.Forms.RadioButton rdo_kolay;
        private System.Windows.Forms.RadioButton rdo_orta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txtbx_Port;
        private System.Windows.Forms.TextBox txtbx_Ip;
        private System.Windows.Forms.RadioButton rdo_O;
        private System.Windows.Forms.RadioButton rdo_X;
    }
}

