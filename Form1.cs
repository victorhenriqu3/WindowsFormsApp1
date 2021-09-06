using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] unidade = new string[7];
            unidade[0] = "km";
            unidade[1] = "hm";
            unidade[2] = "dam";
            unidade[3] = "m";
            unidade[4] = "dm";
            unidade[5] = "cm";
            unidade[6] = "mm";

            double EnterSize = Convert.ToDouble(EnterValue.Text);
            string FormatOutput = unidade[comboBox2.SelectedIndex];
            string FormatInput = unidade[comboBox1.SelectedIndex];
            Console.WriteLine(FormatOutput);
            Console.WriteLine(FormatInput);



            textBox1.Text = $"{EnterSize} {FormatOutput}";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
