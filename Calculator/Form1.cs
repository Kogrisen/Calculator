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
        decimal previous_number;
        decimal current_number;
        char current_operator = '0';

        public Form1()
        {
            InitializeComponent();
            previous_number_n_operator.Text = "";
        }

        private void number_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (result_display.Text == "0")
                result_display.Clear();
            if (result_display.Text == "Error")
                result_display.Clear();
            if (result_display.Text.Length < 15)
                result_display.Text += b.Text;
        }

        private void operator_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (previous_number != 0 && result_display.Text != "")
            {
                equals_button.PerformClick();
                current_operator = char.Parse(b.Text);
            }
            try
            {
                current_operator = char.Parse(b.Text);
                previous_number = decimal.Parse(result_display.Text);
                previous_number_n_operator.Text = ($"{previous_number} {b.Text}");
                result_display.Clear();
            }
            catch (FormatException)
            {
                result_display.Text = "Error";
            }
            catch (Exception)
            {
                Error_Msg();
                throw;
            }

        }

        private void zero_clicked(object sender, EventArgs e)
        {
            if (result_display.Text.Length < 15 && result_display.Text != "0")
                result_display.Text += "0";
        }

        private void decimal_clicked(object sender, EventArgs e)
        {
            if (result_display.Text.Length < 15 && !result_display.Text.Contains(","))
                result_display.Text += ",";
        }

        private void equal_clicked(object sender, EventArgs e)
        {
            try
            {
                current_number = decimal.Parse(result_display.Text);

                switch (current_operator)
                {
                    case '+':
                        current_number += Math.Round(previous_number, 6);
                        result_display.Text = current_number.ToString();
                        break;
                    case '-':
                        current_number = Math.Round(previous_number - current_number, 6);
                        result_display.Text = current_number.ToString();
                        break;
                    case '*':
                        current_number *= Math.Round(previous_number, 6);
                        result_display.Text = current_number.ToString();
                        break;
                    case '/':
                        if (current_number == 0)
                        {
                            Error_Msg();
                            break;
                        }
                        current_number = Math.Round(previous_number / current_number, 6);
                        result_display.Text = current_number.ToString();
                        break;
                    default:
                        break;
                }
                previous_number = decimal.Parse(result_display.Text);
                current_operator = '0';
            }
            catch (OverflowException)
            {
                result_display.Text = "Error";
            }
            catch (FormatException)
            {
                Error_Msg();
            }
            catch (Exception ex)
            {
                result_display.Text = ex.Message;
            }

            previous_number = 0;
            previous_number_n_operator.Text = "";
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            previous_number = 0;
            current_number = 0;
            result_display.Text = "0";
            previous_number_n_operator.Text = "";
        }

        private void Error_Msg()
        {
            MessageBox.Show("I'm sorry Dave, I'm afraid I can't do that", "Affirmative Dave, I read you");
        }

        private void CE_clicked(object sender, EventArgs e)
        {
            result_display.Clear();
        }

        private void negative_positive_convert(object sender, EventArgs e)
        {
            current_number = decimal.Parse(result_display.Text);
            current_number *= -1;
            result_display.Text = current_number.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one_button.PerformClick();
                    break;
                case "2":
                    two_button.PerformClick();
                    break;
                case "3":
                    three_button.PerformClick();
                    break;
                case "4":
                    four_button.PerformClick();
                    break;
                case "5":
                    five_button.PerformClick();
                    break;
                case "6":
                    six_button.PerformClick();
                    break;
                case "7":
                    seven_button.PerformClick();
                    break;
                case "8":
                    eight_button.PerformClick();
                    break;
                case "9":
                    nine_button.PerformClick();
                    break;
                case "0":
                    zero_button.PerformClick();
                    break;
                case "-":
                    subtract_button.PerformClick();
                    break;
                case "+":
                    add_button.PerformClick();
                    break;
                case "*":
                    times_button.PerformClick();
                    break;
                case "/":
                    divide_button.PerformClick();
                    break;
                case ".":
                    decimal_button.PerformClick();
                    break;
                case ",":
                    decimal_button.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
