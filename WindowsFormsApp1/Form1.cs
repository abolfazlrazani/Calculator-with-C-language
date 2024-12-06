using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string input;        
        string number1;   
        string number2;     
        char operation;      // کاراکتری برای ذخیره عملگر (مثل +، -، *، /)
        double result = 0.0; 



        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // جلوگیری از بوق اینتر در تکست باکس
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = ""; // پاک کردن متن تکست‌باکس
            input += "1"; // اضافه کردن عدد 1 به ورودی
            this.textBox1.Text += input; // نمایش ورودی در تکست‌باکس
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = ""; // پاک کردن تکست‌باکس
            this.input = string.Empty; // پاک کردن ورودی
            this.number1 = string.Empty; // پاک کردن عدد اول
            this.number2 = string.Empty; // پاک کردن عدد دوم
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += "."; // اضافه کردن نقطه به ورودی
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number1 = input; // ذخیره ورودی به عنوان عدد اول
            operation = '+'; // تنظیم عملگر به جمع
        
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number1 = input; // ذخیره ورودی به عنوان عدد اول
            operation = '*'; // تنظیم عملگر به ضرب

        }

        private void button13_Click(object sender, EventArgs e)
        {
            number1 = input;
            operation = '/';

        }

        private void button14_Click(object sender, EventArgs e)
        {
            number1 = input;
            operation = '-';

        }

        private void button16_Click(object sender, EventArgs e)
        {
            number2 = input; // ذخیره ورودی به عنوان عدد دوم
            double num1, num2;
            double.TryParse(number1, out num1); // تبدیل رشته اول به عدد
            double.TryParse(number2, out num2); // تبدیل رشته دوم به عدد

            if (operation == '+')
            {
                result = num1 + num2; // انجام عمل جمع
                textBox1.Text = result.ToString(); // نمایش نتیجه
            }
            else if (operation == '-')
            {
                result = num1 - num2; // انجام عمل تفریق
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2; // انجام عمل ضرب
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0) // بررسی تقسیم بر صفر
                {
                    result = num1 / num2; // انجام عمل تقسیم
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "ERROR DIV BY ZERO"; // پیام خطای تقسیم بر صفر
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double num;
            // تبدیل ورودی به عدد
            if (double.TryParse(input, out num))
            {
                // محاسبه جذر
                result = Math.Sqrt(num);
                // نمایش نتیجه
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else
            {
                textBox1.Text = "ورودی معتبر نیست";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
