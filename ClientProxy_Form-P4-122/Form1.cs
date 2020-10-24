using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_Form_P4_122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();

            double hasilTambah = obj.Tambah(1, 2);
            textBox1.Text = hasilTambah.ToString();
            textBox1.ReadOnly = true;

            double hasilKurang = obj.Kurang(3, 2);
            textBox2.Text = hasilKurang.ToString();
            textBox2.ReadOnly = true;

            double hasilKali = obj.Kali(2, 2);
            textBox3.Text = hasilKali.ToString();
            textBox3.ReadOnly = true;

            double hasilBagi = obj.Bagi(2, 2);
            textBox4.Text = hasilBagi.ToString();
            textBox4.ReadOnly = true;

            ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
            textBox5.Text = jarak.ToString();
            textBox5.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
