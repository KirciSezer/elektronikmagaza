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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void üyeOlmadanDevamEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beyazEşyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 git = new Form4();
            git.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.akakce.com/elektronik.html");
        }

        private void telefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }
    }
}
