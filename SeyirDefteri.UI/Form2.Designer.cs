namespace SeyirDefteri.UI
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
            txtUrun = new TextBox();
            txtKisi = new TextBox();
            cmbSeferler = new ComboBox();
            cmbFirma = new ComboBox();
            nupTonaj = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnUrunEkle = new Button();
            lvGonderim = new ListView();
            msdTelefon = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nupTonaj).BeginInit();
            SuspendLayout();
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(99, 65);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(288, 27);
            txtUrun.TabIndex = 0;
            // 
            // txtKisi
            // 
            txtKisi.Location = new Point(99, 195);
            txtKisi.Name = "txtKisi";
            txtKisi.Size = new Size(288, 27);
            txtKisi.TabIndex = 1;
            // 
            // cmbSeferler
            // 
            cmbSeferler.FormattingEnabled = true;
            cmbSeferler.Location = new Point(99, 23);
            cmbSeferler.Name = "cmbSeferler";
            cmbSeferler.Size = new Size(288, 28);
            cmbSeferler.TabIndex = 3;
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(99, 150);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(288, 28);
            cmbFirma.TabIndex = 4;
            // 
            // nupTonaj
            // 
            nupTonaj.Location = new Point(99, 107);
            nupTonaj.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            nupTonaj.Name = "nupTonaj";
            nupTonaj.Size = new Size(288, 27);
            nupTonaj.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 6;
            label1.Text = "Sefer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 72);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 7;
            label2.Text = "Ürün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Tonaj";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(30, 195);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 9;
            label4.Text = "Kişi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 158);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Firma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(8, 245);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 11;
            label6.Text = "Kişi Telefon";
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = SystemColors.ButtonFace;
            btnUrunEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunEkle.Location = new Point(406, 233);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(94, 37);
            btnUrunEkle.TabIndex = 12;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // lvGonderim
            // 
            lvGonderim.Location = new Point(8, 276);
            lvGonderim.Name = "lvGonderim";
            lvGonderim.Size = new Size(485, 162);
            lvGonderim.TabIndex = 13;
            lvGonderim.UseCompatibleStateImageBehavior = false;
            // 
            // msdTelefon
            // 
            msdTelefon.Location = new Point(100, 238);
            msdTelefon.Mask = "(999) 000-0000";
            msdTelefon.Name = "msdTelefon";
            msdTelefon.Size = new Size(287, 27);
            msdTelefon.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(512, 450);
            Controls.Add(msdTelefon);
            Controls.Add(lvGonderim);
            Controls.Add(btnUrunEkle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nupTonaj);
            Controls.Add(cmbFirma);
            Controls.Add(cmbSeferler);
            Controls.Add(txtKisi);
            Controls.Add(txtUrun);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nupTonaj).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrun;
        private TextBox txtKisi;
        private TextBox textBox3;
        private ComboBox cmbSeferler;
        private ComboBox cmbFirma;
        private NumericUpDown nupTonaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnUrunEkle;
        private ListView lvGonderim;
        private MaskedTextBox msdTelefon;
    }
}