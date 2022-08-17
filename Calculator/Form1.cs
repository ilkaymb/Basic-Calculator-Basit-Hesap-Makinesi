using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {            
                StringBuilder sb = new StringBuilder(maskedTextBox1.Text);

                sb.Remove(sb.Length - 1, 1);

                maskedTextBox1.Text = sb.ToString();
            }

        }

        private void ac_button_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = null;
        }

        private void slash_button_Click(object sender, EventArgs e)
        {
            printer("/");
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            printer("=");
            calculater();

        }

        private void mult_button_Click(object sender, EventArgs e)
        {
            printer("*");

        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            printer("-");

        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            printer(".");

        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            printer("+");

        }

        private void three_button_Click(object sender, EventArgs e)
        {
            printer("3");

        }

        private void six_button_Click(object sender, EventArgs e)
        {
            printer("6");

        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            printer("9");

        }

        private void two_button_Click(object sender, EventArgs e)
        {
            printer("2");

        }

        private void five_button_Click(object sender, EventArgs e)
        {
            printer("5");

        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            printer("0");

        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            printer("8");

        }

        private void one_button_Click(object sender, EventArgs e)
        {
            printer("1");

        }

        private void four_button_Click(object sender, EventArgs e)
        {
            printer("4");

        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            printer("7");

        }
        List<string> text = new List<string>();

        public void printer(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(maskedTextBox1.Text);
            sb.Append(text);
            maskedTextBox1.Text = sb.ToString();


        }
        public void calculater()
        {
            string text = maskedTextBox1.Text;
            List<int> numbers = new List<int>();
            List<char> symbols = new List<char>();

            int total = 0;


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '+')
                {
                    numbers.Add(total);
                    symbols.Add('+');
                    total = 0;
                }
                else if (text[i] == '-')
                {
                    numbers.Add(total);
                    symbols.Add('-');

                    total = 0;

                }
                else if (text[i] == '*')
                {
                    numbers.Add(total);
                    symbols.Add('*');

                    total = 0;


                }
                else if (text[i] == '/')
                {
                    numbers.Add(total);
                    symbols.Add('/');

                    total = 0;


                }
                else if (text[i] == '=')
                {
                    numbers.Add(total);
                    symbols.Add('=');
                    break;
                }
                else
                {
                    total = (total * 10) + int.Parse(text[i].ToString());
                }

            }
            int result = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (symbols[i] == '+')
                {
                    result = numbers[i] + numbers[i + 1];
                    numbers[i + 1] = result;
                }
                else if (symbols[i] == '-')
                {
                    result =  numbers[i] - numbers[i + 1];
                    numbers[i + 1] = result;

                }
                else if (symbols[i] == '*')
                {
                    result =  numbers[i] * numbers[i + 1];
                    numbers[i + 1] = result;

                }
                else if (symbols[i] == '/')
                {
                    result = numbers[i] / numbers[i + 1];
                    numbers[i + 1] = result;

                }
                else if (symbols[i] == '=')
                {

                    maskedTextBox1.Text = result.ToString();

                }

            }
            maskedTextBox1.Text = result.ToString();


        }

    }
}
