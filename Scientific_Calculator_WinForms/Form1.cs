using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator_WinForms
{
    public partial class Form1 : Form
    {
        bool isTax = false;
        bool isShift = false;
        double value = 0;
        string sign_operator="";
        bool exp = false;
        bool power = false;
        double answer = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button_WOC14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
                textBox1.Text += "0";
        }

        private void Arithmetic_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lbl_text.Text = "";
            value = 0;
            sign_operator = "";
            answer = 0;
            exp = false;
            power = false;
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith("-") || textBox1.Text.EndsWith("+")
                || textBox1.Text.EndsWith("*") || textBox1.Text.EndsWith("/")
                || textBox1.Text.EndsWith("(") && !exp && !power)
            {
                lbl_text.Text = "ERROR";
                rtb.Text += "\t*)  " + lbl_text.Text + "\n\n";
            }
            else if (!exp && !power)
            {
                answer = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null));
                lbl_text.Text = textBox1.Text;
                textBox1.Text = "";
                textBox1.Text = Convert.ToString(answer);
                rtb.Text += "\t *)  " + textBox1.Text+"\n\n";
            }
            else if (exp || power)
            {
                switch (sign_operator)
                {
                    case "power":
                        lbl_text.Text += textBox1.Text;
                        answer = Math.Pow(value, Convert.ToDouble(textBox1.Text));
                        textBox1.Text = "";
                        textBox1.Text = Convert.ToString(answer);
                        power = false ;
                        rtb.Text += "\t*)  " + textBox1.Text +"\n\n";
                        break;
                    case "exp":
                        answer = Math.Exp(Convert.ToDouble(textBox1.Text));
                        lbl_text.Text += textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = Convert.ToString(answer);
                        exp = false;
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";
                        break;
                }
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >=1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "";
            }
        }

        private void btn_multi_0_Click(object sender, EventArgs e)
        {

        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void btn_multi_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_multi_0_Click_1(object sender, EventArgs e)
        {
            if (!isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Sin (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Sin(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Sin^-1 (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Asin(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isTax && !isShift)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 60000 && Convert.ToDouble(textBox1.Text) < 120000)
                    {
                        value = (Convert.ToDouble(textBox1.Text) * 5) / 100;
                        lbl_text.Text = "Income  = "+ textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = "5% Tax is : ";
                        textBox1.Text += Convert.ToString(value);
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";

                    }
                    else
                    {
                        lbl_text.Text = "5% Tax NOT Applicable";
                    }
                }
            }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
        }

        private void btn_multi_1_Click(object sender, EventArgs e)
        {
            if (!isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Cos (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Cos(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isShift  && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Cos^-1 (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Acos(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isTax && !isShift)
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 120000 && Convert.ToDouble(textBox1.Text) < 180000)
                    {
                        value = (Convert.ToDouble(textBox1.Text) * 10) / 100;
                        lbl_text.Text = "Income  = " + textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = "10% Tax is : ";
                        textBox1.Text += Convert.ToString(value);
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";
                    }
                    else
                    {
                        lbl_text.Text = "10% Tax NOT Applicable";
                    }
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
        }

        private void btn_multi_2_Click(object sender, EventArgs e)
        {
            if (!isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Tan (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Tan(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isShift && !isTax)
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    value = (value * Math.PI) / 180;
                    lbl_text.Text = "Tan^-1 (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Atan(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isTax && !isShift)
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 180000 && Convert.ToDouble(textBox1.Text) < 250000)
                    {
                        value = (Convert.ToDouble(textBox1.Text) * 15) / 100;
                        lbl_text.Text = "Income  = " + textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = "15% Tax is : ";
                        textBox1.Text += Convert.ToString(value);
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";
                    }
                    else
                    {
                        lbl_text.Text = "15% Tax NOT Applicable";
                    }
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            if(!isShift)
            {
                isShift = true;
                btn_shift.ButtonColor = System.Drawing.Color.Black;
                btn_shift.TextColor = System.Drawing.Color.White;
                btn_toggle.BorderColor = System.Drawing.Color.LemonChiffon;
                btn_shift.BorderColor = System.Drawing.Color.Orange;
                btn_multi_0.Text = "Sin^-1";
                btn_multi_1.Text = "Cos^-1";
                btn_multi_2.Text = "Tan^-1";
                btn_multi_3.Text = "Log";
                btn_multi_4.Text = "ln";
            }

            else if (isShift)
            {
                isShift = false;
                btn_shift.ButtonColor = System.Drawing.Color.Silver;
                btn_shift.TextColor = System.Drawing.Color.Black;
                btn_shift.BorderColor = System.Drawing.Color.LemonChiffon;
                btn_multi_0.Text = "Sin";
                btn_multi_1.Text = "Cos";
                btn_multi_2.Text = "Tan";
                btn_multi_3.Text = "π";
                btn_multi_4.Text = "√";
            }
           
        }

        private void btn_multi_3_Click_1(object sender, EventArgs e)
        {
            if (!isShift && !isTax)
            {
                textBox1.Text = "3.14";
            }
            else if (isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    lbl_text.Text = "Log Base 10 (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Log10(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isTax && !isShift)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 250000 && Convert.ToDouble(textBox1.Text) < 350000)
                    {
                        value = (Convert.ToDouble(textBox1.Text) * 17.5) / 100;
                        lbl_text.Text = "Income  = " + textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = "17.5% Tax is : ";
                        textBox1.Text += Convert.ToString(value);
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";
                    }
                    else
                    {
                        lbl_text.Text = "17.5% Tax NOT Applicable";
                    }
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
        }

        private void btn_multi_4_Click(object sender, EventArgs e)
        {
            if (!isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    lbl_text.Text = "Squre Root (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Sqrt(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isShift && !isTax)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    value = Convert.ToDouble(textBox1.Text);
                    lbl_text.Text = "Log Base e (" + textBox1.Text + ")";
                    textBox1.Text = "";
                    answer = Math.Log(value);
                    textBox1.Text = Convert.ToString(answer);
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
            else if (isTax && !isShift)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (Convert.ToDouble(textBox1.Text) > 350000 && Convert.ToDouble(textBox1.Text) < 500000)
                    {
                        value = (Convert.ToDouble(textBox1.Text) * 20) / 100;
                        lbl_text.Text = "Income  = " + textBox1.Text;
                        textBox1.Text = "";
                        textBox1.Text = "17.5% Tax is : ";
                        textBox1.Text += Convert.ToString(value);
                        rtb.Text += "\t*)  " + textBox1.Text + "\n\n";
                    }
                    else
                    {
                        lbl_text.Text = "20% Tax NOT Applicable";
                    }
                }
                else if ((textBox1.Text == ""))
                {
                    textBox1.Text = "";
                }
            }
        }

        private void btn_exponent_Click(object sender, EventArgs e)
        {
            sign_operator = "exp";
            textBox1.Text = "e ^ ";
            lbl_text.Text = textBox1.Text;
            textBox1.Text = "";
            exp = true;
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            sign_operator = "power";
            value = Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "^";
            lbl_text.Text = textBox1.Text;
            textBox1.Text = "";
            power = true;
        }

        private void btn_minus_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "-";
            }
        }

        private void btn_toggle_Click(object sender, EventArgs e)
        {
            if(!isTax)
            {
                isTax = true;
                btn_toggle.ButtonColor = System.Drawing.Color.Black;
                btn_toggle.TextColor = System.Drawing.Color.White;
                btn_shift.BorderColor = System.Drawing.Color.LemonChiffon;
                btn_toggle.BorderColor = System.Drawing.Color.Orange;
                btn_multi_0.Text = "5 %";
                btn_multi_1.Text = "10 %";
                btn_multi_2.Text = "15 %";
                btn_multi_3.Text = "17.5 %";
                btn_multi_4.Text = "20 %";
            }
            else if (isTax)
            {
                isTax = false;
                btn_toggle.ButtonColor = System.Drawing.Color.Silver;
                btn_toggle.TextColor = System.Drawing.Color.Black;
                btn_shift.BorderColor = System.Drawing.Color.LemonChiffon;
                btn_toggle.BorderColor = System.Drawing.Color.LemonChiffon;
                btn_multi_0.Text = "Sin";
                btn_multi_1.Text = "Cos";
                btn_multi_2.Text = "Tan";
                btn_multi_3.Text = "π";
                btn_multi_4.Text = "√";
            }
        }

        private void btn_left_paranthesis_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void btn_right_paranthesis_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void btn_clear_history_Click(object sender, EventArgs e)
        {
            rtb.Text = "";
        }
    }
}
