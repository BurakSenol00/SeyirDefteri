namespace SeyirDefteri.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpVarisTarihi = new DateTimePicker();
            dtpCikisTarihi = new DateTimePicker();
            cmbGemiAdi = new ComboBox();
            cmbVarisLimani = new ComboBox();
            cmbUgradigiLiman = new ComboBox();
            cmbCikisLimani = new ComboBox();
            btnSeferOlustur = new Button();
            btnGec = new Button();
            LvSeferler = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Çıkış Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(8, 63);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Varış Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(8, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Çıkış Limanı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(1, 201);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Uğradığı Liman";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(16, 106);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "Gemi Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(8, 244);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 5;
            label6.Text = "Varış Limanı";
            // 
            // dtpVarisTarihi
            // 
            dtpVarisTarihi.Location = new Point(118, 56);
            dtpVarisTarihi.Name = "dtpVarisTarihi";
            dtpVarisTarihi.Size = new Size(250, 27);
            dtpVarisTarihi.TabIndex = 6;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(118, 12);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(250, 27);
            dtpCikisTarihi.TabIndex = 7;
            // 
            // cmbGemiAdi
            // 
            cmbGemiAdi.FormattingEnabled = true;
            cmbGemiAdi.Location = new Point(118, 98);
            cmbGemiAdi.Name = "cmbGemiAdi";
            cmbGemiAdi.Size = new Size(250, 28);
            cmbGemiAdi.TabIndex = 8;
            // 
            // cmbVarisLimani
            // 
            cmbVarisLimani.FormattingEnabled = true;
            cmbVarisLimani.Location = new Point(118, 236);
            cmbVarisLimani.Name = "cmbVarisLimani";
            cmbVarisLimani.Size = new Size(250, 28);
            cmbVarisLimani.TabIndex = 9;
            // 
            // cmbUgradigiLiman
            // 
            cmbUgradigiLiman.FormattingEnabled = true;
            cmbUgradigiLiman.Location = new Point(118, 193);
            cmbUgradigiLiman.Name = "cmbUgradigiLiman";
            cmbUgradigiLiman.Size = new Size(250, 28);
            cmbUgradigiLiman.TabIndex = 10;
            // 
            // cmbCikisLimani
            // 
            cmbCikisLimani.FormattingEnabled = true;
            cmbCikisLimani.Location = new Point(118, 142);
            cmbCikisLimani.Name = "cmbCikisLimani";
            cmbCikisLimani.Size = new Size(250, 28);
            cmbCikisLimani.TabIndex = 11;
            // 
            // btnSeferOlustur
            // 
            btnSeferOlustur.BackColor = SystemColors.ButtonFace;
            btnSeferOlustur.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSeferOlustur.Location = new Point(118, 270);
            btnSeferOlustur.Name = "btnSeferOlustur";
            btnSeferOlustur.Size = new Size(117, 43);
            btnSeferOlustur.TabIndex = 12;
            btnSeferOlustur.Text = "Sefer Oluştur";
            btnSeferOlustur.UseVisualStyleBackColor = false;
            btnSeferOlustur.Click += btnSeferOlustur_Click;
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ButtonFace;
            btnGec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(250, 270);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(112, 43);
            btnGec.TabIndex = 13;
            btnGec.Text = "Sonraki";
            btnGec.UseVisualStyleBackColor = false;
            // 
            // LvSeferler
            // 
            LvSeferler.Location = new Point(8, 319);
            LvSeferler.Name = "LvSeferler";
            LvSeferler.Size = new Size(360, 232);
            LvSeferler.TabIndex = 14;
            LvSeferler.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(380, 563);
            Controls.Add(LvSeferler);
            Controls.Add(btnGec);
            Controls.Add(btnSeferOlustur);
            Controls.Add(cmbCikisLimani);
            Controls.Add(cmbUgradigiLiman);
            Controls.Add(cmbVarisLimani);
            Controls.Add(cmbGemiAdi);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(dtpVarisTarihi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seyir Defteri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpVarisTarihi;
        private DateTimePicker dtpCikisTarihi;
        private ComboBox cmbGemiAdi;
        private ComboBox cmbVarisLimani;
        private ComboBox cmbUgradigiLiman;
        private ComboBox cmbCikisLimani;
        private Button btnSeferOlustur;
        private Button btnGec;
        private ListView LvSeferler;
    }
}
