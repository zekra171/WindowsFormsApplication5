using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                panel2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                panel2.Visible = true;
        }

        private void num(object sender, EventArgs e)
        {   // It casts thse sender (the button clicked ) to a button , retrieve its text, and updates the textbox text
            Button btn = (Button)sender;
            //textBox1.Text = btn.Text;
            textBox1.Text += btn.Text;
        }


        double n1 = 0, n2 = 0, res;
        char op;
        double memory = 0;

        // + button


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

       

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }

        

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            op = '*';
            textBox1.Clear();

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            op = '/';
            textBox1.Clear();

        }


  

        private void buttonFact_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            op = '!';
            textBox1.Clear();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            textBox1.Text = (n1 * n1).ToString();
        }

        private void buttonXpowY_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text,out n1);
            op = '^';
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            textBox1.Text = (1 / n1).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            textBox1.Text = Math.Sqrt(n1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out n1);
            op = '%';
            textBox1.Clear();

        }


        //= button
        private void buttonEqual_Click(object sender, EventArgs e)
        {
             double.TryParse(textBox1.Text, out n2);
          
            if (op == '+')
                textBox1.Text = (n1 + n2).ToString();
            if (op == '-')
                textBox1.Text = (n1 - n2).ToString();
            if (op == '*')
                textBox1.Text = (n1 * n2).ToString();
            if (op == '/')
                if (n2 == 0)
                    textBox1.Text = "Undefined";
                else
                    textBox1.Text = (n1 / n2).ToString();
            if (op == '%')
                if (n2 == 0)
                    textBox1.Text = "Undefined";
                else
                    textBox1.Text = (n1 % n2).ToString();
            if (op == '!')
            {
                if (n1 < 0 || n1 != (int)n1)
                {
                    textBox1.Text = "Invalid input";
                }
                else
                {
                    res = 1;
                    for (int i = 2; i <= n1; i++)
                        res *= i;
                    textBox1.Text = res.ToString();
                }
            }
            if (op == '^')
            {
                textBox1.Text = Math.Pow(n1, n2).ToString();
            }
        }


    }





}

