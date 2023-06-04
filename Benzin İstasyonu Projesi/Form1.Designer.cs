namespace Benzin_İstasyonu_Projesi
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
            sayfa_tutucu = new TabControl();
            tabPage1 = new TabPage();
            depo_guncelle = new Button();
            lpg_cubuk = new ProgressBar();
            eurodizel_cubuk = new ProgressBar();
            dizel_cubuk = new ProgressBar();
            benzin97_cubuk = new ProgressBar();
            benzin95_cubuk = new ProgressBar();
            lpg_guncel = new TextBox();
            eurodizel_guncel = new TextBox();
            dizel_guncel = new TextBox();
            benzin97_guncel = new TextBox();
            benzin95_guncel = new TextBox();
            lpg_depo = new Label();
            eurodizel_depo = new Label();
            label5 = new Label();
            dizel_depo = new Label();
            label4 = new Label();
            benzin97_depo = new Label();
            label3 = new Label();
            benzin95_depo = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel5 = new Panel();
            benzin97_indirim = new RadioButton();
            benzin97_zam = new RadioButton();
            panel2 = new Panel();
            dizel_indirim = new RadioButton();
            dizel_zam = new RadioButton();
            panel3 = new Panel();
            eurodizel_indirim = new RadioButton();
            eurodizel_zam = new RadioButton();
            panel4 = new Panel();
            lpg_indirim = new RadioButton();
            lpg_zam = new RadioButton();
            fiyat_guncelle = new Button();
            label21 = new Label();
            panel1 = new Panel();
            benzin95_indirim = new RadioButton();
            benzin95_zam = new RadioButton();
            lpg_oran = new TextBox();
            eurodizel_oran = new TextBox();
            benzin97_oran = new TextBox();
            dizel_oran = new TextBox();
            benzin95_oran = new TextBox();
            lpg_fiyat = new Label();
            label15 = new Label();
            eurodizel_fiyat = new Label();
            dizel_fiyat = new Label();
            label14 = new Label();
            benzin97_fiyat = new Label();
            label13 = new Label();
            benzin95_fiyat = new Label();
            label12 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            satıs_yap = new Button();
            toplam_tutar = new Label();
            lpg_satis = new NumericUpDown();
            eurodizel_satis = new NumericUpDown();
            dizel_satis = new NumericUpDown();
            benzin97_satis = new NumericUpDown();
            benzin95_satis = new NumericUpDown();
            yakıt_turu = new ComboBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            sayfa_tutucu.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lpg_satis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eurodizel_satis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dizel_satis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benzin97_satis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)benzin95_satis).BeginInit();
            SuspendLayout();
            // 
            // sayfa_tutucu
            // 
            sayfa_tutucu.Controls.Add(tabPage1);
            sayfa_tutucu.Controls.Add(tabPage2);
            sayfa_tutucu.Controls.Add(tabPage3);
            sayfa_tutucu.Location = new Point(12, 12);
            sayfa_tutucu.Name = "sayfa_tutucu";
            sayfa_tutucu.SelectedIndex = 0;
            sayfa_tutucu.Size = new Size(1063, 578);
            sayfa_tutucu.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(depo_guncelle);
            tabPage1.Controls.Add(lpg_cubuk);
            tabPage1.Controls.Add(eurodizel_cubuk);
            tabPage1.Controls.Add(dizel_cubuk);
            tabPage1.Controls.Add(benzin97_cubuk);
            tabPage1.Controls.Add(benzin95_cubuk);
            tabPage1.Controls.Add(lpg_guncel);
            tabPage1.Controls.Add(eurodizel_guncel);
            tabPage1.Controls.Add(dizel_guncel);
            tabPage1.Controls.Add(benzin97_guncel);
            tabPage1.Controls.Add(benzin95_guncel);
            tabPage1.Controls.Add(lpg_depo);
            tabPage1.Controls.Add(eurodizel_depo);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dizel_depo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(benzin97_depo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(benzin95_depo);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1055, 545);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DEPO BİLGİLERİ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // depo_guncelle
            // 
            depo_guncelle.Location = new Point(613, 456);
            depo_guncelle.Name = "depo_guncelle";
            depo_guncelle.Size = new Size(365, 40);
            depo_guncelle.TabIndex = 7;
            depo_guncelle.Text = "DEPO BİLGİLERİNİ GÜNCELLE";
            depo_guncelle.UseVisualStyleBackColor = true;
            depo_guncelle.Click += depo_guncelle_Click;
            // 
            // lpg_cubuk
            // 
            lpg_cubuk.Location = new Point(613, 374);
            lpg_cubuk.Name = "lpg_cubuk";
            lpg_cubuk.Size = new Size(365, 29);
            lpg_cubuk.TabIndex = 6;
            // 
            // eurodizel_cubuk
            // 
            eurodizel_cubuk.Location = new Point(613, 308);
            eurodizel_cubuk.Name = "eurodizel_cubuk";
            eurodizel_cubuk.Size = new Size(365, 29);
            eurodizel_cubuk.TabIndex = 6;
            // 
            // dizel_cubuk
            // 
            dizel_cubuk.Location = new Point(613, 242);
            dizel_cubuk.Name = "dizel_cubuk";
            dizel_cubuk.Size = new Size(365, 29);
            dizel_cubuk.TabIndex = 6;
            // 
            // benzin97_cubuk
            // 
            benzin97_cubuk.Location = new Point(613, 176);
            benzin97_cubuk.Name = "benzin97_cubuk";
            benzin97_cubuk.Size = new Size(365, 29);
            benzin97_cubuk.TabIndex = 6;
            // 
            // benzin95_cubuk
            // 
            benzin95_cubuk.Location = new Point(613, 110);
            benzin95_cubuk.Name = "benzin95_cubuk";
            benzin95_cubuk.Size = new Size(365, 29);
            benzin95_cubuk.TabIndex = 6;
            // 
            // lpg_guncel
            // 
            lpg_guncel.Location = new Point(402, 376);
            lpg_guncel.Name = "lpg_guncel";
            lpg_guncel.Size = new Size(125, 27);
            lpg_guncel.TabIndex = 5;
            lpg_guncel.KeyPress += benzin95_guncel_KeyPress;
            // 
            // eurodizel_guncel
            // 
            eurodizel_guncel.Location = new Point(402, 310);
            eurodizel_guncel.Name = "eurodizel_guncel";
            eurodizel_guncel.Size = new Size(125, 27);
            eurodizel_guncel.TabIndex = 5;
            eurodizel_guncel.KeyPress += benzin95_guncel_KeyPress;
            // 
            // dizel_guncel
            // 
            dizel_guncel.Location = new Point(402, 248);
            dizel_guncel.Name = "dizel_guncel";
            dizel_guncel.Size = new Size(125, 27);
            dizel_guncel.TabIndex = 5;
            dizel_guncel.KeyPress += benzin95_guncel_KeyPress;
            // 
            // benzin97_guncel
            // 
            benzin97_guncel.Location = new Point(402, 178);
            benzin97_guncel.Name = "benzin97_guncel";
            benzin97_guncel.Size = new Size(125, 27);
            benzin97_guncel.TabIndex = 5;
            benzin97_guncel.KeyPress += benzin95_guncel_KeyPress;
            // 
            // benzin95_guncel
            // 
            benzin95_guncel.Location = new Point(402, 112);
            benzin95_guncel.Name = "benzin95_guncel";
            benzin95_guncel.Size = new Size(125, 27);
            benzin95_guncel.TabIndex = 5;
            benzin95_guncel.KeyPress += benzin95_guncel_KeyPress;
            // 
            // lpg_depo
            // 
            lpg_depo.AutoSize = true;
            lpg_depo.Location = new Point(259, 383);
            lpg_depo.Name = "lpg_depo";
            lpg_depo.Size = new Size(50, 20);
            lpg_depo.TabIndex = 4;
            lpg_depo.Text = "label5";
            // 
            // eurodizel_depo
            // 
            eurodizel_depo.AutoSize = true;
            eurodizel_depo.Location = new Point(259, 317);
            eurodizel_depo.Name = "eurodizel_depo";
            eurodizel_depo.Size = new Size(50, 20);
            eurodizel_depo.TabIndex = 3;
            eurodizel_depo.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 383);
            label5.Name = "label5";
            label5.Size = new Size(38, 18);
            label5.TabIndex = 4;
            label5.Text = "LPG";
            // 
            // dizel_depo
            // 
            dizel_depo.AutoSize = true;
            dizel_depo.Location = new Point(259, 251);
            dizel_depo.Name = "dizel_depo";
            dizel_depo.Size = new Size(50, 20);
            dizel_depo.TabIndex = 2;
            dizel_depo.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 317);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 3;
            label4.Text = "EURO DİZEL";
            // 
            // benzin97_depo
            // 
            benzin97_depo.AutoSize = true;
            benzin97_depo.Location = new Point(259, 185);
            benzin97_depo.Name = "benzin97_depo";
            benzin97_depo.Size = new Size(50, 20);
            benzin97_depo.TabIndex = 1;
            benzin97_depo.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 251);
            label3.Name = "label3";
            label3.Size = new Size(49, 18);
            label3.TabIndex = 2;
            label3.Text = "DİZEL";
            // 
            // benzin95_depo
            // 
            benzin95_depo.AutoSize = true;
            benzin95_depo.Location = new Point(259, 119);
            benzin95_depo.Name = "benzin95_depo";
            benzin95_depo.Size = new Size(50, 20);
            benzin95_depo.TabIndex = 0;
            benzin95_depo.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 185);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 1;
            label2.Text = "BENZİN (97)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 119);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 0;
            label1.Text = "BENZİN (95)";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(fiyat_guncelle);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(lpg_oran);
            tabPage2.Controls.Add(eurodizel_oran);
            tabPage2.Controls.Add(benzin97_oran);
            tabPage2.Controls.Add(dizel_oran);
            tabPage2.Controls.Add(benzin95_oran);
            tabPage2.Controls.Add(lpg_fiyat);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(eurodizel_fiyat);
            tabPage2.Controls.Add(dizel_fiyat);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(benzin97_fiyat);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(benzin95_fiyat);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1055, 545);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "FİYAT BİLGİLERİ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(benzin97_indirim);
            panel5.Controls.Add(benzin97_zam);
            panel5.Location = new Point(750, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(282, 27);
            panel5.TabIndex = 11;
            // 
            // benzin97_indirim
            // 
            benzin97_indirim.AutoSize = true;
            benzin97_indirim.Location = new Point(162, 1);
            benzin97_indirim.Name = "benzin97_indirim";
            benzin97_indirim.Size = new Size(77, 24);
            benzin97_indirim.TabIndex = 0;
            benzin97_indirim.TabStop = true;
            benzin97_indirim.Text = "İndirim";
            benzin97_indirim.UseVisualStyleBackColor = true;
            // 
            // benzin97_zam
            // 
            benzin97_zam.AutoSize = true;
            benzin97_zam.Location = new Point(3, 1);
            benzin97_zam.Name = "benzin97_zam";
            benzin97_zam.Size = new Size(60, 24);
            benzin97_zam.TabIndex = 0;
            benzin97_zam.TabStop = true;
            benzin97_zam.Text = "Zam";
            benzin97_zam.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dizel_indirim);
            panel2.Controls.Add(dizel_zam);
            panel2.Location = new Point(750, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 27);
            panel2.TabIndex = 11;
            // 
            // dizel_indirim
            // 
            dizel_indirim.AutoSize = true;
            dizel_indirim.Location = new Point(162, 1);
            dizel_indirim.Name = "dizel_indirim";
            dizel_indirim.Size = new Size(77, 24);
            dizel_indirim.TabIndex = 0;
            dizel_indirim.TabStop = true;
            dizel_indirim.Text = "İndirim";
            dizel_indirim.UseVisualStyleBackColor = true;
            // 
            // dizel_zam
            // 
            dizel_zam.AutoSize = true;
            dizel_zam.Location = new Point(3, 1);
            dizel_zam.Name = "dizel_zam";
            dizel_zam.Size = new Size(60, 24);
            dizel_zam.TabIndex = 0;
            dizel_zam.TabStop = true;
            dizel_zam.Text = "Zam";
            dizel_zam.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(eurodizel_indirim);
            panel3.Controls.Add(eurodizel_zam);
            panel3.Location = new Point(747, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 27);
            panel3.TabIndex = 11;
            // 
            // eurodizel_indirim
            // 
            eurodizel_indirim.AutoSize = true;
            eurodizel_indirim.Location = new Point(162, 1);
            eurodizel_indirim.Name = "eurodizel_indirim";
            eurodizel_indirim.Size = new Size(77, 24);
            eurodizel_indirim.TabIndex = 0;
            eurodizel_indirim.TabStop = true;
            eurodizel_indirim.Text = "İndirim";
            eurodizel_indirim.UseVisualStyleBackColor = true;
            // 
            // eurodizel_zam
            // 
            eurodizel_zam.AutoSize = true;
            eurodizel_zam.Location = new Point(6, 1);
            eurodizel_zam.Name = "eurodizel_zam";
            eurodizel_zam.Size = new Size(60, 24);
            eurodizel_zam.TabIndex = 0;
            eurodizel_zam.TabStop = true;
            eurodizel_zam.Text = "Zam";
            eurodizel_zam.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lpg_indirim);
            panel4.Controls.Add(lpg_zam);
            panel4.Location = new Point(747, 390);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 27);
            panel4.TabIndex = 11;
            // 
            // lpg_indirim
            // 
            lpg_indirim.AutoSize = true;
            lpg_indirim.Location = new Point(162, 1);
            lpg_indirim.Name = "lpg_indirim";
            lpg_indirim.Size = new Size(77, 24);
            lpg_indirim.TabIndex = 0;
            lpg_indirim.TabStop = true;
            lpg_indirim.Text = "İndirim";
            lpg_indirim.UseVisualStyleBackColor = true;
            // 
            // lpg_zam
            // 
            lpg_zam.AutoSize = true;
            lpg_zam.Location = new Point(6, 1);
            lpg_zam.Name = "lpg_zam";
            lpg_zam.Size = new Size(60, 24);
            lpg_zam.TabIndex = 0;
            lpg_zam.TabStop = true;
            lpg_zam.Text = "Zam";
            lpg_zam.UseVisualStyleBackColor = true;
            // 
            // fiyat_guncelle
            // 
            fiyat_guncelle.Location = new Point(512, 448);
            fiyat_guncelle.Name = "fiyat_guncelle";
            fiyat_guncelle.Size = new Size(125, 57);
            fiyat_guncelle.TabIndex = 13;
            fiyat_guncelle.Text = "Fiyatları Güncelle";
            fiyat_guncelle.UseVisualStyleBackColor = true;
            fiyat_guncelle.Click += fiyat_guncelle_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(494, 37);
            label21.Name = "label21";
            label21.Size = new Size(179, 20);
            label21.TabIndex = 12;
            label21.Text = "Zam / İndirim Oranları(%)";
            // 
            // panel1
            // 
            panel1.Controls.Add(benzin95_indirim);
            panel1.Controls.Add(benzin95_zam);
            panel1.Location = new Point(747, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 27);
            panel1.TabIndex = 10;
            // 
            // benzin95_indirim
            // 
            benzin95_indirim.AutoSize = true;
            benzin95_indirim.Location = new Point(162, 1);
            benzin95_indirim.Name = "benzin95_indirim";
            benzin95_indirim.Size = new Size(77, 24);
            benzin95_indirim.TabIndex = 0;
            benzin95_indirim.TabStop = true;
            benzin95_indirim.Text = "İndirim";
            benzin95_indirim.UseVisualStyleBackColor = true;
            // 
            // benzin95_zam
            // 
            benzin95_zam.AutoSize = true;
            benzin95_zam.Location = new Point(3, 1);
            benzin95_zam.Name = "benzin95_zam";
            benzin95_zam.Size = new Size(60, 24);
            benzin95_zam.TabIndex = 0;
            benzin95_zam.TabStop = true;
            benzin95_zam.Text = "Zam";
            benzin95_zam.UseVisualStyleBackColor = true;
            // 
            // lpg_oran
            // 
            lpg_oran.Location = new Point(512, 390);
            lpg_oran.Name = "lpg_oran";
            lpg_oran.Size = new Size(125, 27);
            lpg_oran.TabIndex = 9;
            lpg_oran.KeyPress += benzin95_guncel_KeyPress;
            // 
            // eurodizel_oran
            // 
            eurodizel_oran.Location = new Point(512, 313);
            eurodizel_oran.Name = "eurodizel_oran";
            eurodizel_oran.Size = new Size(125, 27);
            eurodizel_oran.TabIndex = 8;
            eurodizel_oran.KeyPress += benzin95_guncel_KeyPress;
            // 
            // benzin97_oran
            // 
            benzin97_oran.Location = new Point(512, 159);
            benzin97_oran.Name = "benzin97_oran";
            benzin97_oran.Size = new Size(125, 27);
            benzin97_oran.TabIndex = 7;
            benzin97_oran.KeyPress += benzin95_guncel_KeyPress;
            // 
            // dizel_oran
            // 
            dizel_oran.Location = new Point(512, 236);
            dizel_oran.Name = "dizel_oran";
            dizel_oran.Size = new Size(125, 27);
            dizel_oran.TabIndex = 6;
            dizel_oran.KeyPress += benzin95_guncel_KeyPress;
            // 
            // benzin95_oran
            // 
            benzin95_oran.Location = new Point(512, 82);
            benzin95_oran.Name = "benzin95_oran";
            benzin95_oran.Size = new Size(125, 27);
            benzin95_oran.TabIndex = 5;
            benzin95_oran.KeyPress += benzin95_guncel_KeyPress;
            // 
            // lpg_fiyat
            // 
            lpg_fiyat.AutoSize = true;
            lpg_fiyat.Location = new Point(275, 397);
            lpg_fiyat.Name = "lpg_fiyat";
            lpg_fiyat.Size = new Size(58, 20);
            lpg_fiyat.TabIndex = 4;
            lpg_fiyat.Text = "label15";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(85, 397);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 4;
            label15.Text = "LPG";
            // 
            // eurodizel_fiyat
            // 
            eurodizel_fiyat.AutoSize = true;
            eurodizel_fiyat.Location = new Point(275, 320);
            eurodizel_fiyat.Name = "eurodizel_fiyat";
            eurodizel_fiyat.Size = new Size(58, 20);
            eurodizel_fiyat.TabIndex = 3;
            eurodizel_fiyat.Text = "label14";
            // 
            // dizel_fiyat
            // 
            dizel_fiyat.AutoSize = true;
            dizel_fiyat.Location = new Point(275, 243);
            dizel_fiyat.Name = "dizel_fiyat";
            dizel_fiyat.Size = new Size(58, 20);
            dizel_fiyat.TabIndex = 2;
            dizel_fiyat.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(85, 320);
            label14.Name = "label14";
            label14.Size = new Size(90, 20);
            label14.TabIndex = 3;
            label14.Text = "EURO DİZEL";
            // 
            // benzin97_fiyat
            // 
            benzin97_fiyat.AutoSize = true;
            benzin97_fiyat.Location = new Point(275, 166);
            benzin97_fiyat.Name = "benzin97_fiyat";
            benzin97_fiyat.Size = new Size(58, 20);
            benzin97_fiyat.TabIndex = 1;
            benzin97_fiyat.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(85, 243);
            label13.Name = "label13";
            label13.Size = new Size(48, 20);
            label13.TabIndex = 2;
            label13.Text = "DİZEL";
            // 
            // benzin95_fiyat
            // 
            benzin95_fiyat.AutoSize = true;
            benzin95_fiyat.Location = new Point(275, 89);
            benzin95_fiyat.Name = "benzin95_fiyat";
            benzin95_fiyat.Size = new Size(58, 20);
            benzin95_fiyat.TabIndex = 0;
            benzin95_fiyat.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(85, 166);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 1;
            label12.Text = "BENZİN 97";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(85, 89);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 0;
            label11.Text = "BENZİN 95";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(satıs_yap);
            tabPage3.Controls.Add(toplam_tutar);
            tabPage3.Controls.Add(lpg_satis);
            tabPage3.Controls.Add(eurodizel_satis);
            tabPage3.Controls.Add(dizel_satis);
            tabPage3.Controls.Add(benzin97_satis);
            tabPage3.Controls.Add(benzin95_satis);
            tabPage3.Controls.Add(yakıt_turu);
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label22);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1055, 545);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SATIŞ YAP";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // satıs_yap
            // 
            satıs_yap.Location = new Point(729, 53);
            satıs_yap.Name = "satıs_yap";
            satıs_yap.Size = new Size(115, 29);
            satıs_yap.TabIndex = 12;
            satıs_yap.Text = "SATIŞ YAP";
            satıs_yap.UseVisualStyleBackColor = true;
            satıs_yap.Click += satıs_yap_Click;
            // 
            // toplam_tutar
            // 
            toplam_tutar.AutoSize = true;
            toplam_tutar.Location = new Point(479, 464);
            toplam_tutar.Name = "toplam_tutar";
            toplam_tutar.Size = new Size(0, 20);
            toplam_tutar.TabIndex = 11;
            // 
            // lpg_satis
            // 
            lpg_satis.Location = new Point(480, 394);
            lpg_satis.Name = "lpg_satis";
            lpg_satis.Size = new Size(150, 27);
            lpg_satis.TabIndex = 10;
            lpg_satis.ValueChanged += benzin95_satis_ValueChanged;
            // 
            // eurodizel_satis
            // 
            eurodizel_satis.Location = new Point(480, 326);
            eurodizel_satis.Name = "eurodizel_satis";
            eurodizel_satis.Size = new Size(150, 27);
            eurodizel_satis.TabIndex = 9;
            eurodizel_satis.ValueChanged += benzin95_satis_ValueChanged;
            // 
            // dizel_satis
            // 
            dizel_satis.Location = new Point(479, 257);
            dizel_satis.Name = "dizel_satis";
            dizel_satis.Size = new Size(150, 27);
            dizel_satis.TabIndex = 8;
            dizel_satis.ValueChanged += benzin95_satis_ValueChanged;
            // 
            // benzin97_satis
            // 
            benzin97_satis.Location = new Point(480, 191);
            benzin97_satis.Name = "benzin97_satis";
            benzin97_satis.Size = new Size(150, 27);
            benzin97_satis.TabIndex = 8;
            benzin97_satis.ValueChanged += benzin95_satis_ValueChanged;
            // 
            // benzin95_satis
            // 
            benzin95_satis.Location = new Point(480, 121);
            benzin95_satis.Name = "benzin95_satis";
            benzin95_satis.Size = new Size(150, 27);
            benzin95_satis.TabIndex = 7;
            benzin95_satis.ValueChanged += benzin95_satis_ValueChanged;
            // 
            // yakıt_turu
            // 
            yakıt_turu.FormattingEnabled = true;
            yakıt_turu.Location = new Point(479, 54);
            yakıt_turu.Name = "yakıt_turu";
            yakıt_turu.Size = new Size(151, 28);
            yakıt_turu.TabIndex = 6;
            yakıt_turu.SelectedIndexChanged += yakıt_turu_SelectedIndexChanged;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(262, 464);
            label28.Name = "label28";
            label28.Size = new Size(132, 20);
            label28.TabIndex = 5;
            label28.Text = "ÖDENECEK TUTAR";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(262, 401);
            label27.Name = "label27";
            label27.Size = new Size(34, 20);
            label27.TabIndex = 5;
            label27.Text = "LPG";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(262, 333);
            label26.Name = "label26";
            label26.Size = new Size(90, 20);
            label26.TabIndex = 4;
            label26.Text = "EURO DİZEL";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(262, 264);
            label25.Name = "label25";
            label25.Size = new Size(48, 20);
            label25.TabIndex = 3;
            label25.Text = "DİZEL";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(262, 198);
            label24.Name = "label24";
            label24.Size = new Size(91, 20);
            label24.TabIndex = 2;
            label24.Text = "BENZİN (97)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(262, 128);
            label23.Name = "label23";
            label23.Size = new Size(91, 20);
            label23.TabIndex = 1;
            label23.Text = "BENZİN (95)";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(262, 62);
            label22.Name = "label22";
            label22.Size = new Size(88, 20);
            label22.TabIndex = 0;
            label22.Text = "YAKIT TÜRÜ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 602);
            Controls.Add(sayfa_tutucu);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            sayfa_tutucu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lpg_satis).EndInit();
            ((System.ComponentModel.ISupportInitialize)eurodizel_satis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dizel_satis).EndInit();
            ((System.ComponentModel.ISupportInitialize)benzin97_satis).EndInit();
            ((System.ComponentModel.ISupportInitialize)benzin95_satis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl sayfa_tutucu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox eurodizel_guncel;
        private TextBox dizel_guncel;
        private TextBox benzin97_guncel;
        private TextBox benzin95_guncel;
        private Label lpg_depo;
        private Label eurodizel_depo;
        private Label label5;
        private Label dizel_depo;
        private Label label4;
        private Label benzin97_depo;
        private Label label3;
        private Label benzin95_depo;
        private Label label2;
        private Label label1;
        private Button depo_guncelle;
        private ProgressBar lpg_cubuk;
        private ProgressBar eurodizel_cubuk;
        private ProgressBar dizel_cubuk;
        private ProgressBar benzin97_cubuk;
        private ProgressBar benzin95_cubuk;
        private TextBox lpg_guncel;
        private Button fiyat_guncelle;
        private Label label21;
        private Panel panel1;
        private TextBox lpg_oran;
        private TextBox eurodizel_oran;
        private TextBox benzin97_oran;
        private TextBox dizel_oran;
        private TextBox benzin95_oran;
        private Label lpg_fiyat;
        private Label label15;
        private Label eurodizel_fiyat;
        private Label dizel_fiyat;
        private Label label14;
        private Label benzin97_fiyat;
        private Label label13;
        private Label benzin95_fiyat;
        private Label label12;
        private Label label11;
        private Button satıs_yap;
        private Label toplam_tutar;
        private NumericUpDown lpg_satis;
        private NumericUpDown eurodizel_satis;
        private NumericUpDown dizel_satis;
        private NumericUpDown benzin97_satis;
        private NumericUpDown benzin95_satis;
        private ComboBox yakıt_turu;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private RadioButton benzin95_indirim;
        private RadioButton benzin95_zam;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private RadioButton lpg_indirim;
        private RadioButton lpg_zam;
        private RadioButton eurodizel_indirim;
        private RadioButton eurodizel_zam;
        private RadioButton dizel_indirim;
        private RadioButton dizel_zam;
        private Panel panel5;
        private RadioButton benzin97_indirim;
        private RadioButton benzin97_zam;
    }
}