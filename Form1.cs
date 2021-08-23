using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkishLetters_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void button_srch_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
                textBox1.Text = ofd.SafeFileName;
            }
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@textBox2.Text,Encoding.UTF8);
            text = text.Replace('Ç', 'C').Replace('ç', 'c').Replace('ı', 'i').Replace('İ', 'I').Replace('Ö', 'O').Replace('ö', 'o').Replace('ğ', 'g').Replace('Ş', 'S').Replace('ş', 's').Replace('Ü', 'U').Replace('ü', 'u').Replace('î', 'i').Replace('â', 'a');
            File.WriteAllText(@textBox2.Text, text, Encoding.UTF8);
            if (MessageBox.Show("Çıkış yapılsın mı?", "Harfler değiştirildi", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit(); // or this.Close();
            }
        }
    }
}
