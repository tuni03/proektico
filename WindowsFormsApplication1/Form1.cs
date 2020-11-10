using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
         TextBox1.Text= TextBox1.Text+"0";//текстовото поле за фаренхайт да присвои стойността  0
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";//текстовото поле за фаренхайт да присвои стойността  1
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"2";//текстовото поле за фаренхайт да присвои стойността  2      
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";//текстовото поле за фаренхайт да присвои стойността  3
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"4";//текстовото поле за фаренхайт да присвои стойността  4
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"5";//текстовото поле за фаренхайт да присвои стойността  5
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"6";//текстовото поле за фаренхайт да присвои стойността 6 
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"7";//текстовото поле за фаренхайт да присвои стойността  7
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"8";//текстовото поле за фаренхайт да присвои стойността  8
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text= TextBox1.Text+"9";//текстовото поле за фаренхайт да присвои стойността 9 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text= "-";//добавяне на знак за отрицателните стойности  
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ".";//добавяне на десетична запетая
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text= " ";//стойностите на текстовото поле да се изтрият
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(TextBox1.Text);
            TextBox2.Text = Convert.ToString((value - 32) * 5 / 9 + 273.15);
            TextBox3.Text = Convert.ToString((5.0 / 9) * (value - 32));
        }
    }
}
