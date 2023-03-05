using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezer_sınav_form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        beyazesya b = new beyazesya();       
        private void button1_Click(object sender, EventArgs e)
        {
            b.adet = Convert.ToInt32(numericUpDown1.Value);
            b.beyazesyaadi = comboBox1.SelectedItem.ToString();
            b.enerjigücü = Convert.ToDouble(textBox2.Text);
            b.vergioranı= Convert.ToDouble(textBox3.Text);
            b.Zam = Convert.ToDouble(textBox6.Text);                     
            listBox1.Items.Add("Beyaz eşya adı :" + comboBox1.SelectedItem);
            listBox1.Items.Add("Enerji gücü :" + textBox2.Text);
            listBox1.Items.Add("Vergi oranı :" + textBox3.Text);
            listBox1.Items.Add("Zam :" + textBox6.Text);
            
            if(checkBox1.Checked==true)
            {
                numericUpDown1.Value = b.adet;
                listBox1.Items.Add(b.adet+ " adet Buzdolabı");
                b.Fiyat = 2500;
                listBox1.Items.Add("Fiyat :" + b.Fiyat);         
            }
            else if(checkBox2.Checked==true)
            {
                numericUpDown1.Value = b.adet;
                listBox1.Items.Add(b.adet+" adet Çamaşır makinesi");
                b.Fiyat =4500;
                listBox1.Items.Add("Fiyat :" + b.Fiyat);
               
            }
            else if (checkBox3.Checked == true)
            {
                numericUpDown1.Value = b.adet;
                listBox1.Items.Add(b.adet+" adet Bulaşık makinesi");
                b.Fiyat = 5000;
                listBox1.Items.Add("Fiyat :" + b.Fiyat);
               
            }
            else if (checkBox4.Checked == true)
            {
                numericUpDown1.Value = b.adet;
                listBox1.Items.Add(b.adet +"+ adet Fırın");
                b.Fiyat = 2200;
                listBox1.Items.Add("Fiyat :" + b.Fiyat);
            
            }                     
            b.zam(b.Fiyat, b.adet);
            listBox1.Items.Add("Ödeyeceğiniz fiyat :" + b.zam(b.Fiyat, b.adet));    
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
