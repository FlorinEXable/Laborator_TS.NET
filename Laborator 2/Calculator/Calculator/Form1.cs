using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double numar;
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.D0)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D1)
            {
                button5_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D2)
            {
                button6_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D3)
            {
                button4_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D4)
            {
                button8_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D5)
            {
                button9_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D6)
            {
                button7_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D7)
            {
                button11_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D8)
            {
                button12_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D9)
            {
                button10_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.Back) // BACKSPACE
            {
                button18_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.E) // EGAL
            {
                button16_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.A) // ADUNARE
            {
                button15_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.S) // SCADERE
            {
                button14_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.I) // INMULTIRE
            {
                button13_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.D) // DIVIDE
            {
                button17_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.N) // NEGATIV
            {
                button2_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.R) // RESET
            {
                button20_Click(sender, e);
            }
            else if (e.KeyChar == (Char)Keys.P) // PUNCT
            {
                button3_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(".")))
                {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            numar = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                if (textBox1.Text != "0")
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            numar = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operator = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double numar2;
            double rezultat;

            numar2 = Convert.ToDouble(textBox1.Text);

            if (Operator == "+")
            {
                rezultat = numar + numar2;
                textBox1.Text = Convert.ToString(rezultat);
                numar = rezultat;
            }
            else if (Operator == "-")
            {
                rezultat = numar - numar2;
                textBox1.Text = Convert.ToString(rezultat);
                numar = rezultat;
            }
            else if (Operator == "*")
            {
                rezultat = numar * numar2;
                textBox1.Text = Convert.ToString(rezultat);
                numar = rezultat;
            }
            else if (Operator == "/")
            {
                rezultat = numar / numar2;
                textBox1.Text = Convert.ToString(rezultat);
                numar = rezultat;
            }
        }
    }
}
