using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm1 : Form
    {
        public CalculatorForm1()
        {
            InitializeComponent();
        }


        private void one_Click(object sender, EventArgs e)
        {
            var one = "1";
            this.outputWindow.AppendText(one);
        }

        private void two_Click(object sender, EventArgs e)
        {
            var two = "2";
            this.outputWindow.AppendText(two);
        }

        private void three_Click(object sender, EventArgs e)
        {
            var three = "3";
            this.outputWindow.AppendText(three);
        }
        private void four_Click(object sender, EventArgs e)
        {

            var four = "4";
            this.outputWindow.AppendText(four);
        }

        private void five_Click(object sender, EventArgs e)
        {
            var four = "5";
            this.outputWindow.AppendText(four);
        }

        private void six_Click(object sender, EventArgs e)
        {
            var six = "6";
            this.outputWindow.AppendText(six);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            var seven = "7";
            this.outputWindow.AppendText(seven);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            var eight = "8";
            this.outputWindow.AppendText(eight);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            var nine = "9";
            this.outputWindow.AppendText(nine);
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            var point = ".";
            this.outputWindow.AppendText(point);
        }

        private void addition_Click(object sender, EventArgs e)
        {
            var add = "+";
            this.outputWindow.AppendText(add);
        }


        private void multiplication_Click(object sender, EventArgs e)
        {

            var multiply = "×";
            this.outputWindow.AppendText(multiply);
            
        }

        private void division_Click(object sender, EventArgs e)
        {
            var division = "÷";
            this.outputWindow.AppendText(division);
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            var substract = "-";
            this.outputWindow.AppendText(substract);
        }


        private void equals_Click(object sender, EventArgs e)
        {
            ParseInput input = new ParseInput();

            Operations op = new Operations();

            var result  = input.MakeDigit(this.outputWindow.Text);
            var a = result[0];
            var b = result[1];
            if (input.IfAddition(this.outputWindow.Text) == true)
            {
              int  solution = op.Addition(a,b);
              this.outputWindow.Text = solution.ToString();
            }
            else if (input.IfMultiplication(this.outputWindow.Text) == true)
            {
                //ToDo
                //implement multiplication
                
            }
            else if(input.IfSubtraction(this.outputWindow.Text) == true)
            {
                int solution = op.Subtraction(a,b);
                this.outputWindow.Text = solution.ToString();
            }
            else if(input.IfDivision(this.outputWindow.Text) == true)
            {
                int solution = op.Division(a, b);
                this.outputWindow.Text = solution.ToString();
            }



        }

        private void del_Click(object sender, EventArgs e)
        {
            this.outputWindow.Text = "";
        }

        private void CalculatorForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }

       
    }
}
