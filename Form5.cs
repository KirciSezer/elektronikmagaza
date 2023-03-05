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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        telefon t = new telefon();
     
        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(numericUpDown1.Value);                    
            t.kameracözünürlügü = Convert.ToDouble(textBox8.Text);
            t.parmakokutmadurumu = Convert.ToString(textBox9.Text); 
            double vergioranı= Convert.ToDouble(textBox3.Text);
            double zam = Convert.ToDouble(textBox6.Text);                   
            listBox1.Items.Add("kamera çözünürülüğü"+textBox8.Text);
            listBox1.Items.Add("parmak izi okuma durumu"+textBox9.Text);
            if (radioButton1.Checked=true)
            {
                label2.Visible = true;
                textBox10.Visible = true;
                textBox10.Text = radioButton1.Text;
                listBox1.Items.Add("ad :" + textBox10.Text);
                numericUpDown1.Value=adet;
                listBox1.Items.Add("telefon adet:"+adet);
                listBox1.Items.Add("vergi oranı:"+textBox3.Text);
                listBox1.Items.Add("zam:" + textBox6.Text);
                t.Fiyat = 2800;
                textBox1.Text = t.Fiyat.ToString();
            }
           else  if (radioButton2.Checked = true)
            {
                label2.Visible = true;
                textBox10.Visible = true;
                textBox10.Text = radioButton2.Text; listBox1.Items.Add("ad :" + textBox10.Text);
                numericUpDown1.Value = adet;
                listBox1.Items.Add("telefon adet:" + adet);
                listBox1.Items.Add("vergi oranı:" + textBox3.Text);
                listBox1.Items.Add("zam:" + textBox6.Text);
                t.Fiyat = 3000; textBox1.Text = t.Fiyat.ToString();
            }
            else if (radioButton3.Checked = true)
            {
                label2.Visible = true;
                textBox10.Visible = true;
                textBox10.Text = radioButton3.Text; listBox1.Items.Add("ad :" + textBox10.Text);
                numericUpDown1.Value = adet;
                listBox1.Items.Add("telefon adet:" + adet);
                listBox1.Items.Add("vergi oranı:" + textBox3.Text);
                listBox1.Items.Add("zam:" + textBox6.Text);
                t.Fiyat = 4000; textBox1.Text = t.Fiyat.ToString();
            }
           else  if (radioButton4.Checked = true)
            {
                label2.Visible = true;
                textBox10.Visible = true;
                textBox10.Text = radioButton4.Text; listBox1.Items.Add("ad :" + textBox10.Text);
                numericUpDown1.Value = adet;
                listBox1.Items.Add("telefon adet:" + adet);
                listBox1.Items.Add("vergi oranı:" + textBox3.Text);
                listBox1.Items.Add("zam:" + textBox6.Text);
                t.Fiyat = 5000;
                textBox1.Text = t.Fiyat.ToString();
            }
            t.Fiyat = (((t.Fiyat + (t.Fiyat * zam))) * adet) - (t.Fiyat * vergioranı);
            t.Döndür(t.Fiyat);
            listBox1.Items.Add("Telefon için ödeyeceğiniz para =" + t.Fiyat);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox10.Visible = false;
            label2.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
