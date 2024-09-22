using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorna5
{


    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private string selectedOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            selectedOperator = button.Text;  
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxFirstNumber.Text);
                double num2 = double.Parse(textBoxSecondNumber.Text);
                double result = 0;

                switch (selectedOperator)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("На нуль ділити не можна!");
                        break;
                }

                labelResult.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка, введіть правильні числа.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxFirstNumber.Text = "";
            textBoxSecondNumber.Text = "";
            labelResult.Text = "Результат:";
            selectedOperator = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       

        private CalculatorController controller;

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            
            int number = Convert.ToInt32(txtNumber.Text);

            
            listBoxResult.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                string result = $"{number} x {i} = {number * i}";
                listBoxResult.Items.Add(result);
            }

        }

        private void btnGenerateTable_Click_1(object sender, EventArgs e)
        {
            
            int number = Convert.ToInt32(txtNumber.Text);

            
            listBoxResult.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                string result = $"{number} x {i} = {number * i}";
                listBoxResult.Items.Add(result);
            }

        }

        private void btnCheckAge_Click_1(object sender, EventArgs e)
        {
     
            int age = Convert.ToInt32(txtAge.Text);

           
            if (age <= 12)
            {
                lblAgeCategory.Text = "Категорія: Дитина";
            }
            else if (age <= 18)
            {
                lblAgeCategory.Text = "Категорія: Підліток";
            }
            else
            {
                lblAgeCategory.Text = "Категорія: Доросла людина";
            }
        }
    }

}