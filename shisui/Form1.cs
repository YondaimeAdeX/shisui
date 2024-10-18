using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shisui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                this.groupBox1.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
            }
            if (!radioButton1.Checked==true)
            {
                this.groupBox1.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int baslangic , bitis;
            baslangic = int.Parse(textBox1.Text);
            bitis = int.Parse(textBox2.Text);
            for (int i = baslangic; i <= bitis; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi-=1;
            textBox4.Text = sayi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi+=1;
            textBox4.Text = sayi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi *= 2;
            textBox4.Text = sayi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi -= 3;
            textBox4.Text = sayi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi += 3;
            textBox4.Text = sayi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            sayi = sayi /= 2;
            textBox4.Text = sayi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int baslangic, bitis;
            baslangic = int.Parse(textBox5.Text);
            bitis = int.Parse(textBox3.Text);
            for (int i = baslangic; i >= bitis; i--)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox7.Text);
            for (int i = 0; i <= sayi; i++)
            {
                listBox3.Items.Add(i + ". Adem");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int rastgeleSayi;
            Random rand = new Random();
            rastgeleSayi = rand.Next(100);
            label5.Text = rastgeleSayi.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int sayi,toplam = 0;
            sayi = int.Parse(textBox6.Text);
            for (int i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
            }
            label7.Text = toplam.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, toplam = 0;
            baslangic = int.Parse(textBox9.Text);
            bitis = int.Parse(textBox8.Text);
            
            for (int i = baslangic; i <= bitis; i++)
            {
                toplam += i;
            }
            label8.Text = toplam.ToString();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            int sayi = int.Parse(textBox11.Text);
            for (int i = 0; i <= sayi; i++)
            {
                if (i%2==0)
                {
                    listBox4.Items.Add(i);
                }
                else
                {
                    listBox5.Items.Add(i);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            int sayi, rastgele;
            sayi = int.Parse(textBox11.Text);
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                rastgele = rnd.Next(sayi);
                if (rastgele%2==0)
                {
                    listBox4.Items.Add(rastgele);
                }
                else
                {
                    listBox5.Items.Add(rastgele);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
            int sayi = int.Parse(textBox12.Text);
            for (int i = 0; i <= 10; i++)
            {
                listBox6.Items.Add(sayi + " x " + i + " = " + i * sayi);
            }
        }
    }
}
