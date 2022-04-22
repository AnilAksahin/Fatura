using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.KategoriTableAdapter kt = new DataSet1TableAdapters.KategoriTableAdapter();
        DataSet1TableAdapters.ÜrünBilgisiTableAdapter ut = new DataSet1TableAdapters.ÜrünBilgisiTableAdapter();
        DataSet1TableAdapters.MüşteriBilgileriTableAdapter mt = new DataSet1TableAdapters.MüşteriBilgileriTableAdapter();
        DataSet1TableAdapters.FaturaDetayTableAdapter fdt = new DataSet1TableAdapters.FaturaDetayTableAdapter();
        DataSet1TableAdapters.FaturaTableAdapter ft = new DataSet1TableAdapters.FaturaTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kt.KategoriListesi();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox3.Text);
            kt.KategoriEkle(textBox1.Text, textBox2.Text,value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ut.UrunBilgisiListesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox4.Text);
            int value2 = int.Parse(textBox5.Text);
            int value3 = int.Parse(textBox7.Text);
            ut.UrunEkle(value1, textBox6.Text, value2, value3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mt.MusteriBilgileriListesi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int value4 = int.Parse(textBox9.Text);
            mt.MusteriEkle(value4, textBox11.Text, textBox10.Text, textBox8.Text, textBox12.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fdt.FaturaDetayListesi();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int value5 = int.Parse(textBox14.Text);
            int value6 = int.Parse(textBox16.Text);
            short value7 = short.Parse(textBox15.Text);
            int value8 = int.Parse(textBox13.Text);
            fdt.FaturaDetayEkle(value5,value6,value7,value8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ft.FaturaListesi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int value9 = int.Parse(textBox18.Text);
            int value10 = int.Parse(textBox20.Text);
            ft.FaturaEkle(value9, value10, dateTimePicker1.Text, textBox17.Text, textBox21.Text);
        }
    }
}
