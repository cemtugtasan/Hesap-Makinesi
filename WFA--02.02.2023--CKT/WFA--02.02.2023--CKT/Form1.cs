using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA__02._02._2023__CKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        
        }



        float sayi1;
        string op = " ";
        private void button3_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 3;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSayi.Text += 9;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(txtSayi.Text);
            txtSayi.Clear();
            txtSayi.Focus();
            op = "+";


        }
        private void btnCikar_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(txtSayi.Text);
            txtSayi.Clear();
            txtSayi.Focus();
            op = "-";

        }
        private void btnBol_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(txtSayi.Text);
            txtSayi.Clear();
            txtSayi.Focus();
            op = "/";

        }
        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = float.Parse(txtSayi.Text);
            txtSayi.Clear();
            txtSayi.Focus();
            op = "*";

        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            txtSayi.Text = null;

        }
        private void btnSonuc_Click(object sender, EventArgs e)
        {
            
            
            float sonuc = 0;
            if (op=="+")
            {
                sonuc = sayi1 + float.Parse(txtSayi.Text);
                txtSayi.Text =Convert.ToString(sonuc);
            }
            if (op == "-")
            {
                sonuc = sayi1 - float.Parse(txtSayi.Text);
                txtSayi.Text = Convert.ToString(sonuc);
            }
            if (op == "*")
            {
                sonuc = sayi1 * float.Parse(txtSayi.Text);
                txtSayi.Text = Convert.ToString(sonuc);
               
            }
            if (op == "/")
            {
                if (float.Parse(txtSayi.Text) == 0)
                {
                    MessageBox.Show("Hiçbir Sayi 0 a bölünemez Lütfen başka değer girin");
                    txtSayi.Clear();
                    
                }
                
            }
            if (op=="/")
            {
                sonuc = sayi1 / float.Parse(txtSayi.Text);
                txtSayi.Text = Convert.ToString(sonuc);
                
            }




        }
    }
}
