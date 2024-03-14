using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesiödevi
{
    public partial class Form1 : Form
    {
        char islem;
        bool ekranTemizlenecekMi;
        int ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
               
            if (ekranlabel.Text == "0")
                ekranlabel.Text ="";
            ekranlabel.Text += "1"; 
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0")
                ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizlenecekMi = true;
            ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizlenecekMi = true;
            ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void çarpmabutton_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizlenecekMi = true;
            ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bölmebutton_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizlenecekMi = true;
            ilkSayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void eşittirbutton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc=0;
            switch(islem){
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    break;
                case '-':
                    if (ilkSayi > ikinciSayi)
                        sonuc = ilkSayi - ikinciSayi;
                    else
                        sonuc =ikinciSayi-ilkSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case '/':
                    if(ikinciSayi>0)
                    sonuc = ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc =0;
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
    }
    
