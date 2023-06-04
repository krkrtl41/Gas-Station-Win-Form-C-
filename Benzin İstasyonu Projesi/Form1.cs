namespace Benzin_İstasyonu_Projesi
{
    public partial class Form1 : Form
    {
        static double benzin95_stok;
        static double benzin97_stok;
        static double dizel_stok;
        static double eurodizel_stok;
        static double lpg_stok;

        static double benzin95_ucret;
        static double benzin97_ucret;
        static double dizel_ucret;
        static double eurodizel_ucret;
        static double lpg_ucret;

        static double price;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.BackColor = Color.DarkGray;
            this.Text = "Akaryakıt Merkezi Otomasyonu";

            //birinci sayfa
            sayfa_tutucu.Dock = DockStyle.Fill;

            //properties of all of progressbar; 
            benzin95_cubuk.Minimum = 0;
            benzin95_cubuk.Maximum = 1000;
            benzin95_cubuk.Style = ProgressBarStyle.Blocks;
            benzin95_cubuk.Dock = DockStyle.None;
            benzin97_cubuk.Minimum = 0;
            benzin97_cubuk.Maximum = 1000;
            benzin97_cubuk.Style = ProgressBarStyle.Blocks;
            benzin97_cubuk.Dock = DockStyle.None;
            dizel_cubuk.Minimum = 0;
            dizel_cubuk.Maximum = 1000;
            dizel_cubuk.Style = ProgressBarStyle.Blocks;
            dizel_cubuk.Dock = DockStyle.None;
            eurodizel_cubuk.Maximum = 1000;
            eurodizel_cubuk.Minimum = 0;
            eurodizel_cubuk.Style = ProgressBarStyle.Blocks;
            eurodizel_cubuk.Dock = DockStyle.None;
            lpg_cubuk.Minimum = 0;
            lpg_cubuk.Maximum = 1000;
            lpg_cubuk.Dock = DockStyle.None;
            lpg_cubuk.Style = ProgressBarStyle.Blocks;

            string dosya = @"C:\Benzin İstasyonu\Depo.txt";
            string[] veriler = File.ReadAllLines(dosya);
            double[] degerler = new double[5];

            for (int a = 0; a < veriler.Length; a++)
            {
                degerler[a] = Convert.ToDouble(veriler[a]);
            }

            benzin95_stok = degerler[0];
            benzin97_stok = degerler[1];
            dizel_stok = degerler[2];
            eurodizel_stok = degerler[3];
            lpg_stok = degerler[4];

            benzin95_cubuk.Value = Convert.ToInt32(degerler[0]);
            benzin97_cubuk.Value = Convert.ToInt32(degerler[1]);
            dizel_cubuk.Value = Convert.ToInt32(degerler[2]);
            eurodizel_cubuk.Value = Convert.ToInt32(degerler[3]);
            lpg_cubuk.Value = Convert.ToInt32(degerler[4]);

            benzin95_depo.Text = degerler[0].ToString("N");
            benzin97_depo.Text = degerler[1].ToString("N");
            dizel_depo.Text = degerler[2].ToString("N");
            eurodizel_depo.Text = degerler[3].ToString("N");
            lpg_depo.Text = degerler[4].ToString("N");

            //ikinci sayfa

            string dosya_2 = @"C:\Benzin İstasyonu\Fiyat.txt";
            string[] veriler_2 = File.ReadAllLines(dosya_2);
            double[] degerler_2 = new double[veriler_2.Length];

            for (int a = 0; a < veriler_2.Length; a++)
            {
                degerler_2[a] = Convert.ToDouble(veriler_2[a]);
            }

            benzin95_ucret = degerler_2[0];
            benzin97_ucret = degerler_2[1];
            dizel_ucret = degerler_2[2];
            eurodizel_ucret = degerler_2[3];
            lpg_ucret = degerler_2[4];

            benzin95_fiyat.Text = benzin95_ucret.ToString("N");
            benzin97_fiyat.Text = benzin97_ucret.ToString("N");
            dizel_fiyat.Text = dizel_ucret.ToString("N");
            eurodizel_fiyat.Text = eurodizel_ucret.ToString("N");
            lpg_fiyat.Text = lpg_ucret.ToString("N");

            //ucuncu sayfa
            benzin95_satis.DecimalPlaces = 2;
            benzin95_satis.Hexadecimal = false;
            benzin95_satis.Increment = 0.2m;
            benzin95_satis.InterceptArrowKeys = true;
            benzin95_satis.Minimum = 0;
            benzin95_satis.Maximum = Convert.ToDecimal(benzin95_stok);
            benzin95_satis.ReadOnly = true;
            benzin95_satis.RightToLeft = RightToLeft.No;
            benzin95_satis.ThousandsSeparator = true;
            benzin95_satis.TextAlign = HorizontalAlignment.Left;
            benzin95_satis.UpDownAlign = LeftRightAlignment.Right;
            benzin95_satis.Value = 0;

            benzin97_satis.DecimalPlaces = 2;
            benzin97_satis.Hexadecimal = false;
            benzin97_satis.Increment = 0.2m;
            benzin97_satis.InterceptArrowKeys = true;
            benzin97_satis.Maximum = Convert.ToDecimal(benzin97_stok);
            benzin97_satis.Minimum = 0;
            benzin97_satis.ReadOnly = true;
            benzin97_satis.RightToLeft = RightToLeft.No;
            benzin97_satis.TextAlign = HorizontalAlignment.Left;
            benzin97_satis.ThousandsSeparator = true;
            benzin97_satis.UpDownAlign = LeftRightAlignment.Right;
            benzin97_satis.Value = 0;

            dizel_satis.DecimalPlaces = 2;
            dizel_satis.Hexadecimal = false;
            dizel_satis.Increment = 0.2m;
            dizel_satis.InterceptArrowKeys = true;
            dizel_satis.Minimum = 0;
            dizel_satis.Maximum = Convert.ToDecimal(dizel_stok);
            dizel_satis.ReadOnly = true;
            dizel_satis.RightToLeft = RightToLeft.No;
            dizel_satis.TextAlign = HorizontalAlignment.Left;
            dizel_satis.ThousandsSeparator = true;
            dizel_satis.UpDownAlign = LeftRightAlignment.Right;
            dizel_satis.Value = 0;

            eurodizel_satis.DecimalPlaces = 2;
            eurodizel_satis.Hexadecimal = false;
            eurodizel_satis.Increment = 0.2m;
            eurodizel_satis.InterceptArrowKeys = true;
            eurodizel_satis.Minimum = 0;
            eurodizel_satis.Maximum = Convert.ToDecimal(eurodizel_stok);
            eurodizel_satis.ReadOnly = true;
            eurodizel_satis.RightToLeft = RightToLeft.No;
            eurodizel_satis.TextAlign = HorizontalAlignment.Left;
            eurodizel_satis.ThousandsSeparator = true;
            eurodizel_satis.UpDownAlign = LeftRightAlignment.Right;
            eurodizel_satis.Value = 0;

            lpg_satis.DecimalPlaces = 2;
            lpg_satis.Hexadecimal = false;
            lpg_satis.Increment = 0.2m;
            lpg_satis.InterceptArrowKeys = true;
            lpg_satis.Minimum = 0;
            lpg_satis.Maximum = Convert.ToDecimal(lpg_stok);
            lpg_satis.ReadOnly = true;
            lpg_satis.RightToLeft = RightToLeft.No;
            lpg_satis.TextAlign = HorizontalAlignment.Left;
            lpg_satis.ThousandsSeparator = true;
            lpg_satis.UpDownAlign = LeftRightAlignment.Right;
            lpg_satis.Value = 0;

            benzin97_satis.Enabled = false;
            benzin95_satis.Enabled = false;
            dizel_satis.Enabled = false;
            eurodizel_satis.Enabled = false;
            lpg_satis.Enabled = false;

            string[] kind_of_fuel = { "Benzin(95)", "Benzin(97)", "Dizel", "Eurodizel", "LPG" };
            yakıt_turu.Items.AddRange(kind_of_fuel);
            yakıt_turu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void benzin95_guncel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void depo_guncelle_Click(object sender, EventArgs e)
        {
            if (benzin95_guncel.Text != "")
            {
                if (Convert.ToDouble(benzin95_guncel.Text) + benzin95_stok > 1000)
                {
                    benzin95_guncel.Clear();
                }
                else
                {
                    benzin95_stok = benzin95_stok + Convert.ToDouble(benzin95_guncel.Text);
                    benzin95_depo.Text = benzin95_stok.ToString("N");
                    benzin95_cubuk.Value = Convert.ToInt32(benzin95_stok);
                    benzin95_satis.Maximum = Convert.ToDecimal(benzin95_stok);
                    benzin95_guncel.Clear();
                }
            }

            if (benzin97_guncel.Text != "")
            {
                if (Convert.ToDouble(benzin97_guncel.Text) + benzin97_stok > 1000)
                {
                    benzin97_guncel.Clear();
                }
                else
                {
                    benzin97_stok += Convert.ToDouble(benzin97_guncel.Text);
                    benzin97_depo.Text = benzin97_stok.ToString("N");
                    benzin97_cubuk.Value = Convert.ToInt32(benzin97_stok);
                    benzin97_satis.Maximum = Convert.ToDecimal(benzin97_stok);
                    benzin97_guncel.Clear();
                }
            }

            if (dizel_guncel.Text != "")
            {
                if (Convert.ToDouble(dizel_guncel.Text) + dizel_stok > 1000)
                {
                    dizel_guncel.Clear();
                }
                else
                {
                    dizel_stok += Convert.ToDouble(dizel_guncel.Text);
                    dizel_depo.Text = dizel_stok.ToString("N");
                    dizel_cubuk.Value = Convert.ToInt32(dizel_stok);
                    dizel_satis.Maximum = Convert.ToDecimal(dizel_stok);
                    dizel_guncel.Clear();
                }
            }

            if (eurodizel_guncel.Text != "")
            {
                if (Convert.ToDouble(eurodizel_guncel.Text) + eurodizel_stok > 1000)
                {
                    eurodizel_guncel.Clear();
                }
                else
                {
                    eurodizel_stok += Convert.ToDouble(eurodizel_guncel.Text);
                    eurodizel_depo.Text = eurodizel_stok.ToString("N");
                    eurodizel_cubuk.Value = Convert.ToInt32(eurodizel_stok);
                    eurodizel_satis.Maximum = Convert.ToDecimal(eurodizel_stok);
                    eurodizel_guncel.Clear();
                }
            }

            if (lpg_guncel.Text != "")
            {
                if (Convert.ToDouble(lpg_guncel.Text) + lpg_stok > 1000)
                {
                    lpg_guncel.Clear();
                }
                else
                {
                    lpg_stok += Convert.ToDouble(lpg_guncel.Text);
                    lpg_depo.Text = lpg_stok.ToString("N");
                    lpg_cubuk.Value = Convert.ToInt32(lpg_stok);
                    lpg_satis.Maximum = Convert.ToDecimal(lpg_stok);
                    lpg_guncel.Clear();
                }
            }
            MessageBox.Show("Akaryakıt stokları güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fiyat_guncelle_Click(object sender, EventArgs e)
        {
            string m1 = "";
            string m2 = "";
            string m3 = "";
            string m4 = "";
            string m5 = "";
            if (benzin95_oran.Text != "")
            {
                if (benzin95_zam.Checked == true)
                {
                    double zam = benzin95_ucret * (Convert.ToDouble(benzin95_oran.Text) / 100);
                    benzin95_ucret += zam;
                    benzin95_fiyat.Text = benzin95_ucret.ToString("N");
                    benzin95_oran.Clear();
                    m1 = "Benzine(95) " + zam.ToString("N") + " TL'lik zam uygulandı.";
                    benzin95_zam.Checked = false;
                }
                else if (benzin95_indirim.Checked == true)
                {
                    double indirim = benzin95_ucret * (Convert.ToDouble(benzin95_oran.Text) / 100);
                    benzin95_ucret -= indirim;
                    benzin95_fiyat.Text = benzin95_ucret.ToString("N");
                    benzin95_oran.Clear();
                    m1 = "Benzine(95) " + indirim.ToString("N") + " TL'lik indirim uygulandı.";
                    benzin95_indirim.Checked = false;
                }
                else
                {
                    m1 = "Benzin(95) fiyatı değişmedi.";
                    benzin95_oran.Clear();
                }
            }

            if (benzin97_oran.Text != "")
            {
                if (benzin97_zam.Checked == true)
                {
                    double zam = benzin97_ucret * (Convert.ToDouble(benzin97_oran.Text) / 100);
                    benzin97_ucret += zam;
                    benzin97_fiyat.Text = benzin97_ucret.ToString("N");
                    benzin97_oran.Clear();
                    m2 = "Benzine(97) " + zam.ToString("N") + " TL'lik zam uygulandı.";
                    benzin97_zam.Checked = false;
                }
                else if (benzin97_indirim.Checked == true)
                {
                    double indirim = benzin97_ucret * (Convert.ToDouble(benzin97_oran.Text) / 100);
                    benzin97_ucret -= indirim;
                    benzin97_fiyat.Text = benzin97_ucret.ToString("N");
                    benzin97_oran.Clear();
                    m2 = "Benzine(97) " + indirim.ToString("N") + " TL'lik indirim uygulandı.";
                    benzin97_indirim.Checked = false;
                }
                else
                {
                    m2 = "Benzin(97) fiyatı değişmedi.";
                    benzin97_oran.Clear();
                }
            }

            if (dizel_oran.Text != "")
            {
                if (dizel_zam.Checked == true)
                {
                    double zam = dizel_ucret * (Convert.ToDouble(dizel_oran.Text) / 100);
                    dizel_ucret += zam;
                    dizel_fiyat.Text = dizel_ucret.ToString("N");
                    dizel_oran.Clear();
                    m3 = "Dizele " + zam.ToString("N") + "TL'lik zam uygulandı.";
                    dizel_zam.Checked = false;
                }
                else if (dizel_indirim.Checked == true)
                {
                    double indirim = dizel_ucret * (Convert.ToDouble(dizel_oran.Text) / 100);
                    dizel_ucret -= indirim;
                    dizel_fiyat.Text = dizel_ucret.ToString("N");
                    dizel_oran.Clear();
                    m3 = "Dizele " + indirim.ToString("N") + "TL'lik indirim uygulandı.";
                    dizel_indirim.Checked = false;
                }
                else
                {
                    m3 = "Dizel fiyatı değişmedi";
                    dizel_oran.Clear();
                }
            }

            if (eurodizel_oran.Text != "")
            {
                if (eurodizel_zam.Checked == true)
                {
                    double zam = eurodizel_ucret * (Convert.ToDouble(eurodizel_oran.Text) / 100);
                    eurodizel_ucret += zam;
                    eurodizel_fiyat.Text = eurodizel_ucret.ToString("N");
                    eurodizel_oran.Clear();
                    m4 = "Eurodizele " + zam.ToString("N") + " TL'lik zam uygulandı.";
                    eurodizel_zam.Checked = false;
                }
                else if (eurodizel_indirim.Checked)
                {
                    double indirim = eurodizel_ucret * (Convert.ToDouble(eurodizel_oran.Text) / 100);
                    eurodizel_ucret -= indirim;
                    eurodizel_fiyat.Text = eurodizel_ucret.ToString("N");
                    eurodizel_oran.Clear();
                    m4 = "Eurodizele " + indirim.ToString("N") + " TL'lik indirim uygulandı.";
                    eurodizel_indirim.Checked = false;
                }
                else
                {
                    m4 = "Eurodizel fiyatı değişmedi.";
                    eurodizel_oran.Clear();
                }
            }

            if (lpg_oran.Text != "")
            {
                if (lpg_zam.Checked == true)
                {
                    double zam = lpg_ucret * (Convert.ToDouble(lpg_oran.Text) / 100);
                    lpg_ucret += zam;
                    lpg_fiyat.Text = lpg_ucret.ToString("N");
                    lpg_oran.Clear();
                    m5 = "LPG'ye " + zam.ToString("N") + " TL'lik zam uygulandı.";
                    lpg_zam.Checked = false;
                }
                else if (lpg_indirim.Checked)
                {
                    double indirim = lpg_ucret * (Convert.ToDouble(lpg_oran.Text) / 100);
                    lpg_ucret -= indirim;
                    lpg_fiyat.Text = lpg_ucret.ToString("N");
                    lpg_oran.Clear();
                    m5 = "LPG'ye " + indirim.ToString("N") + "TL'lik indirim uygulandı.";
                    lpg_zam.Checked = false;
                }
                else
                {
                    m5 = "LPG fiyatı değişmedi.";
                    lpg_oran.Clear();
                }
            }

            MessageBox.Show(m1 + "\n" + m2 + "\n" + m3 + "\n" + m4 + "\n" + m5, "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void yakıt_turu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yakıt_turu.SelectedIndex == 0)
            {
                benzin95_satis.Enabled = true;
                benzin97_satis.Enabled = false;
                dizel_satis.Enabled = false;
                eurodizel_satis.Enabled = false;
                lpg_satis.Enabled = false;
                sifirla();
            }
            else if (yakıt_turu.SelectedIndex == 1)
            {
                benzin97_satis.Enabled = true;
                benzin95_satis.Enabled = false;
                dizel_satis.Enabled = false;
                eurodizel_satis.Enabled = false;
                lpg_satis.Enabled = false;
                sifirla();
            }
            else if (yakıt_turu.SelectedIndex == 2)
            {
                benzin97_satis.Enabled = false;
                benzin95_satis.Enabled = false;
                dizel_satis.Enabled = true;
                eurodizel_satis.Enabled = false;
                lpg_satis.Enabled = false;
                sifirla();
            }
            else if (yakıt_turu.SelectedIndex == 3)
            {
                benzin97_satis.Enabled = false;
                benzin95_satis.Enabled = false;
                dizel_satis.Enabled = false;
                eurodizel_satis.Enabled = true;
                lpg_satis.Enabled = false;
                sifirla();
            }
            else if (yakıt_turu.SelectedIndex == 4)
            {
                benzin97_satis.Enabled = false;
                benzin95_satis.Enabled = false;
                dizel_satis.Enabled = false;
                eurodizel_satis.Enabled = false;
                lpg_satis.Enabled = true;
                sifirla();
            }
        }

        private void satıs_yap_Click(object sender, EventArgs e)
        {
            if (yakıt_turu.SelectedIndex == 0 && benzin95_satis.Value != 0)
            {
                DialogResult sonuc = MessageBox.Show("Satılacak Ürün : Benzin(95)" + "\n" + "Litre Fiyatı : " + benzin95_ucret + "\n" + "Satılacak Litre Miktarı : " + benzin95_satis.Value + "\n" + "Toplam Tutar : " + price.ToString("N") + "\n" + "Satış tamamlansın mı?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    benzin95_stok -= (double)benzin95_satis.Value;
                    benzin95_cubuk.Value = Convert.ToInt32(benzin95_stok);
                    benzin95_depo.Text = benzin95_stok.ToString("N");
                    benzin95_satis.Maximum = Convert.ToDecimal(benzin95_stok);
                    benzin95_satis.Value = 0;
                    price = 0;
                    yakıt_turu.SelectedItem = null;
                    MessageBox.Show("Satış tamamlandı.");
                }
            }
            else if (yakıt_turu.SelectedIndex == 1)
            {
                DialogResult sonuc = MessageBox.Show("Satılacak Ürün : Benzin(97)" + "\n" + "Litre Fiyatı : " + benzin97_ucret + "\n" + "Satılacak Litre Miktarı : " + benzin97_satis.Value + "\n" + "Toplam Tutar : " + price.ToString("N") + "\n" + "Satış tamamlansın mı?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    benzin97_stok -= (double)benzin97_satis.Value;
                    benzin97_depo.Text = benzin97_stok.ToString("N");
                    benzin97_cubuk.Value = Convert.ToInt32(benzin97_stok);
                    benzin97_satis.Maximum = Convert.ToDecimal(benzin97_stok);
                    benzin97_satis.Value = 0;
                    price = 0;
                    yakıt_turu.SelectedItem = null;
                    MessageBox.Show("Satış tamamlandı.");
                }
            }
            else if (yakıt_turu.SelectedIndex == 2)
            {
                DialogResult sonuc = MessageBox.Show("Satılacak Ürün : Dizel" + "\n" + "Litre Fiyatı : " + dizel_ucret + "\n" + "Satılacak Litre Miktarı : " + dizel_satis.Value + "\n" + "Toplam Tutar : " + price.ToString("N") + "\n" + "Satış tamamlansın mı?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    dizel_stok -= (double)dizel_satis.Value;
                    dizel_depo.Text = dizel_stok.ToString("N");
                    dizel_cubuk.Value = Convert.ToInt32(dizel_stok);
                    dizel_satis.Maximum = Convert.ToDecimal(dizel_stok);
                    dizel_satis.Value = 0;
                    price = 0;
                    yakıt_turu.SelectedItem = null;
                    MessageBox.Show("Satış tamamlandı.");
                }
            }
            else if (yakıt_turu.SelectedIndex == 3)
            {
                DialogResult sonuc = MessageBox.Show("Satılacak Ürün : Eurodizel" + "\n" + "Litre Fiyatı : " + eurodizel_ucret + "\n" + "Satılacak Litre Miktarı : " + eurodizel_satis.Value + "\n" + "Toplam Tutar : " + price.ToString("N") + "\n" + "Satış tamamlansın mı?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    eurodizel_stok -= (double)eurodizel_satis.Value;
                    eurodizel_depo.Text = eurodizel_stok.ToString("N");
                    eurodizel_cubuk.Value = Convert.ToInt32(eurodizel_stok);
                    eurodizel_satis.Maximum = Convert.ToDecimal(eurodizel_stok);
                    eurodizel_satis.Value = 0;
                    price = 0;
                    yakıt_turu.SelectedItem = null;
                    MessageBox.Show("Satış tamamlandı.");
                }
            }
            else if (yakıt_turu.SelectedIndex == 4)
            {
                DialogResult sonuc = MessageBox.Show("Satılacak Ürün : LPG" + "\n" + "Litre Fiyatı : " + lpg_ucret + "\n" + "Satılacak Litre Miktarı : " + lpg_satis.Value + "\n" + "Toplam Tutar : " + price.ToString("N") + "\n" + "Satış tamamlansın mı?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sonuc == DialogResult.Yes)
                {
                    lpg_stok -= (double)lpg_satis.Value;
                    lpg_depo.Text = lpg_stok.ToString("N");
                    lpg_cubuk.Value = Convert.ToInt32(lpg_stok);
                    lpg_satis.Maximum = Convert.ToDecimal(lpg_stok);
                    lpg_satis.Value = 0;
                    price = 0;
                    yakıt_turu.SelectedItem = null;
                    MessageBox.Show("Satış tamamlandı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir akaryakıt türü seçiniz ve miktarını belirleyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void benzin95_satis_ValueChanged(object sender, EventArgs e)
        {
            if (yakıt_turu.SelectedIndex == 0)
            {
                price = benzin95_ucret * Convert.ToDouble(benzin95_satis.Value);
                toplam_tutar.Text = price.ToString("N");
            }
            else if (yakıt_turu.SelectedIndex == 1)
            {
                price = benzin97_ucret * Convert.ToDouble(benzin97_satis.Value);
                toplam_tutar.Text = price.ToString("N");
            }
            else if (yakıt_turu.SelectedIndex == 2)
            {
                price = dizel_ucret * Convert.ToDouble(dizel_satis.Value);
                toplam_tutar.Text = price.ToString("N");
            }
            else if (yakıt_turu.SelectedIndex == 3)
            {
                price = eurodizel_ucret * Convert.ToDouble(eurodizel_satis.Value);
                toplam_tutar.Text = price.ToString("N");
            }
            else if (yakıt_turu.SelectedIndex == 4)
            {
                price = lpg_ucret * Convert.ToDouble(lpg_satis.Value);
                toplam_tutar.Text = price.ToString("N");
            }
        }
        private void sifirla()
        {
            benzin95_satis.Value = 0;
            benzin97_satis.Value = 0;
            dizel_satis.Value = 0;
            eurodizel_satis.Value = 0;
            lpg_satis.Value = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string dosya_1 = @"C:\Benzin İstasyonu\Depo.txt";
            FileStream fs = new FileStream(dosya_1, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            double[] stoklar_1 = { benzin95_stok, benzin97_stok, dizel_stok, eurodizel_stok, lpg_stok };
            foreach (double stok in stoklar_1)
            {
                sw.WriteLine(stok.ToString());
            }
            sw.Flush();
            sw.Close();
            fs.Close();

            string dosya_2 = @"C:\Benzin İstasyonu\Fiyat.txt";
            FileStream fs_2 = new FileStream(dosya_2, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw_2 = new StreamWriter(fs_2);
            double[] ucretler = { benzin95_ucret, benzin97_ucret, dizel_ucret, eurodizel_ucret, lpg_ucret };
            foreach (double ucret in ucretler)
            {
                sw_2.WriteLine(ucret.ToString());
            }
            sw_2.Flush();
            sw_2.Close();
            fs_2.Close();
        }
    }
}