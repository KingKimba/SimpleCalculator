using System;
using System.Windows.Forms;
//Karl Kimba Hettinger
//5/5/2021
//Professor Huitsing
//Team 3
// Extra 6-1 Simple Calculator
using System;
using System.Windows.Forms;

namespace FractionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) 
        {
            string numberTxt1 = txtOperand1.Text;
            string numberTxt2 = txtOperand2.Text;
            string operatorTxt = txtOperator.Text;
            string[] operators = new string[] { "+", "-", "*", "/" };
            double num1 = 0;
            double num2 = 0;
            bool isValid = true;
            

            if (!Double.TryParse(numberTxt1, out num1))
            {
                isValid = false;
            }

            if (isValid && !Double.TryParse(numberTxt2, out num2))
            {
                isValid = false;
            }

            if (isValid && Array.IndexOf(operators, operatorTxt) < 0)
            {
            }
            else if (isValid)
            {
                double result = 0;
                switch (operatorTxt)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = num1 / num2; break;
                    default: result = 0; break;
                }

                txtResult.Text = Math.Round(result, 4).ToString();
                txtOperand1.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
  
            Close();
        }
        
        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            if (txtOperand1.Modified) 
            txtResult.Clear();
        }
        
        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            if (txtOperator.Modified)
                txtResult.Clear();
        }
        
        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            if (txtOperand2.Modified)
                txtResult.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}