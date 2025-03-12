namespace SeyirDefteri.UI
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
            lvZRaporu = new ListView();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            btnExcelOlustur = new Button();
            btnPdfOlustur = new Button();
            btnMailAt = new Button();
            SuspendLayout();
            // 
            // lvZRaporu
            // 
            lvZRaporu.Location = new Point(12, 110);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(518, 121);
            lvZRaporu.TabIndex = 0;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(12, 56);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(280, 56);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 1;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // btnExcelOlustur
            // 
            btnExcelOlustur.Location = new Point(12, 237);
            btnExcelOlustur.Name = "btnExcelOlustur";
            btnExcelOlustur.Size = new Size(151, 51);
            btnExcelOlustur.TabIndex = 2;
            btnExcelOlustur.Text = "Excel Oluştur";
            btnExcelOlustur.UseVisualStyleBackColor = true;
            btnExcelOlustur.Click += btnExcelOlustur_Click;
            // 
            // btnPdfOlustur
            // 
            btnPdfOlustur.Location = new Point(211, 237);
            btnPdfOlustur.Name = "btnPdfOlustur";
            btnPdfOlustur.Size = new Size(120, 54);
            btnPdfOlustur.TabIndex = 2;
            btnPdfOlustur.Text = "PDF Oluştur";
            btnPdfOlustur.UseVisualStyleBackColor = true;
            // 
            // btnMailAt
            // 
            btnMailAt.Location = new Point(381, 236);
            btnMailAt.Name = "btnMailAt";
            btnMailAt.Size = new Size(149, 54);
            btnMailAt.TabIndex = 2;
            btnMailAt.Text = "Excel Dosyasına Mail  At";
            btnMailAt.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(556, 321);
            Controls.Add(btnMailAt);
            Controls.Add(btnPdfOlustur);
            Controls.Add(btnExcelOlustur);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lvZRaporu);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvZRaporu;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private Button btnExcelOlustur;
        private Button btnPdfOlustur;
        private Button btnMailAt;
    }
}