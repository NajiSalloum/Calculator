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
        Calculator cal = new Calculator();
        private void showNumber(string number)
        {
            if (textDisplay.Text == "0" || textDisplay.Text == "+" || textDisplay.Text == "-" 
                || textDisplay.Text == "x" || textDisplay.Text == "/" || textDisplay.Text == "%" )
                textDisplay.Text = number;
            else
                textDisplay.Text = textDisplay.Text + number;
        }
        private void showSymbol(string symbol)
        {
            cal.firstNumber = double.Parse(textDisplay.Text);
            textDisplay.Text = symbol;
            
        }

        public bool isIncludeAcomma(string str)
        {
           
            bool isInclude = false;
            
            if (str.Contains(','))
            {
                isInclude = true;
            }

            return isInclude;
                 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            showNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            showNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            showNumber("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            showNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            showNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            showNumber("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            showNumber("3");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            showNumber("0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSymbol("+");
            cal.Operation = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            cal.secondNumber = double.Parse(textDisplay.Text);
            double res = cal.Calc(cal.Operation);
            textDisplay.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            showSymbol("-");
            cal.Operation = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            showSymbol("x");
            cal.Operation = "x";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isIncludeAcomma(textDisplay.Text))
                textDisplay.Text = textDisplay.Text;
            else
            textDisplay.Text = textDisplay.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showSymbol("/");
            cal.Operation = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showSymbol("%");
            cal.Operation = "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textDisplay.Text;
            if (isIncludeAcomma(str))
                textDisplay.Text = "YES";
            else
                textDisplay.Text = "NO";
        }

        private void buttonStyle()
        {
            btn0.BackColor = Color.Violet;
            btn1.BackColor = Color.Violet;
            btn2.BackColor = Color.Violet;
            btn3.BackColor = Color.Violet;
            btn4.BackColor = Color.Violet;
            btn5.BackColor = Color.Violet;
            btn6.BackColor = Color.Violet;
            btn7.BackColor = Color.Violet;
            btn8.BackColor = Color.Violet;
            btn9.BackColor = Color.Violet;
            button13.BackColor = Color.Violet;
            button14.BackColor = Color.Violet;
            button4.BackColor = Color.Violet;
            button15.BackColor = Color.Violet;
            btnSub.BackColor = Color.Violet;
            btnMult.BackColor = Color.Violet;
            btnEqual.BackColor = Color.Violet;
            btnClear.BackColor = Color.Violet;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            buttonStyle();
        }
    }
}
