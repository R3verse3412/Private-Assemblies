using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            txtBox_Results.Text = "Total" + Environment.NewLine + "000000";
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(txtBox_number1.Text, out number1))
            {
                MessageBox.Show("First Number Invalid");
                return;
            }

            if (!float.TryParse(txtBox_number2.Text, out number2))
            {
                MessageBox.Show("Second Number Invalid");
                return;
            }

            string oper = cmBox_Operator.Text;
            switch (oper) 
            {
                case "+":
                    BasicCalculator.BasicCalcu add = new BasicCalculator.BasicCalcu();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(add.addition(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                case "-":
                    BasicCalculator.BasicCalcu sub = new BasicCalculator.BasicCalcu();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(sub.subtractiion(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                case "*":
                    BasicCalculator.BasicCalcu multiply = new BasicCalculator.BasicCalcu();
                    txtBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(multiply.multiplication(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    break;
                    if (number2 == 0)
                    {
                        MessageBox.Show("Division By ZERO");
                    }
                    else
                    {
                        BasicCalculator.BasicCalcu divide = new BasicCalculator.BasicCalcu();
                        txtBox_Results.Text = "Total" + Environment.NewLine + Convert.ToString(divide.division(Convert.ToInt16(txtBox_number1.Text), Convert.ToInt16(txtBox_number2.Text)));
                    }
                    break;                
                default:
                    MessageBox.Show("Operator is Invalid");
                    break;
            }

        }
    }
}
