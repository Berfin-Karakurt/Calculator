using System;
using System.Windows.Forms;

namespace Basit_hesaplama_programı
{
    public partial class Form1 : Form
    {
        double ilkSayi;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        // SAYI BUTONLARI
        private void SayiButonu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sonuc.Text += btn.Text;
        }

        private void sonuc_TextChanged(object sender, EventArgs e)
        {

        }

        // İŞLEM BUTONLARI
        private void IslemButonu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (sonuc.Text == "") return;

            ilkSayi = Convert.ToDouble(sonuc.Text);
            islem = btn.Text;

            // 🔥 artık label kullanıyoruz
            label2.Text = ilkSayi + " " + islem;

            sonuc.Clear();
        }

        // ENTER (=)
        private void enter_Click(object sender, EventArgs e)
        {
            if (sonuc.Text == "") return;

            double ikinciSayi = Convert.ToDouble(sonuc.Text);
            double sonucDeger = 0;

            switch (islem)
            {
                case "+":
                    sonucDeger = ilkSayi + ikinciSayi;
                    break;

                case "-":
                    sonucDeger = ilkSayi - ikinciSayi;
                    break;

                case "*":
                    sonucDeger = ilkSayi * ikinciSayi;
                    break;

                case "/":
                    if (ikinciSayi != 0)
                        sonucDeger = ilkSayi / ikinciSayi;
                    else
                    {
                        MessageBox.Show("0'a bölme hatası!");
                        return;
                    }
                    break;
            }

            // 🔥 sonuç hem label hem textbox
            label2.Text = label2.Text + " " + ikinciSayi + " = " + sonucDeger;
            sonuc.Text = sonucDeger.ToString();
        }

        // TEMİZLE
        private void sil_Click(object sender, EventArgs e)
        {
            sonuc.Clear();
            label2.Text = "";
            ilkSayi = 0;
            islem = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}