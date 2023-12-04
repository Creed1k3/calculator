using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator   // БЛЯЯЯЯТЬ ВСЁ ДОЛЖНО БЫТЬ СТРИНГОМ СКЛАДЫВАЮТСЯ ИТД ТОЛЬКО ЦИФРЫ, НЕ ЧИСЛА БЛЯЯЯТЯТВЬДФЫВФДОВЩЖДВФР
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double equal = 0;
        private string equal1 = "";
        private char penie;
        private double n = 0;

        private void nazad_Click(object sender, EventArgs e)  // ПЕРЕДЕЛАТЬ
        {
            if (equal1.Length > 0)
            {
                equal1 = equal1.Remove(equal1.Length - 1);
                textBox1.Text = equal1;
                n = 0;
            }
            else
            {
                textBox1.Text = "Чисел нет";
            }
        }
        private void Clear_Click(object sender, EventArgs e)  //РАБОТАЕТ
        {
            textBox1.Clear();
            equal1 = "";
            n = 0;
        }


        private void log_Click(object sender, EventArgs e)  // РАБОТАЕТ  CE
        {
            textBox1.Clear();
            equal = 0;
            equal1 = "";
            penie = ' ';
            n = 0;
        }

        private void plusminus_Click(object sender, EventArgs e)  //РАБОТАЕТ
        {          
                try
                {
                    double pepe = double.Parse(equal1);
                    equal1 = (pepe * -1).ToString();
                    textBox1.Text = equal1;
                    n = 0;
                }
                catch (System.FormatException ex)
                {
                    // Обработка исключения
                    textBox1.Text = "Неверный формат строки";
                }            
        }

        private void coren_Click(object sender, EventArgs e)  // РАБОТАЕТ НО ЧУТКА ДОДЕЛАТЬ
           {        
                try
                {
                    double pepe = double.Parse(equal1);
                    equal1 = Math.Sqrt(pepe).ToString();
                    textBox1.Text = equal1;
                    n = 0;
                }
                catch (System.FormatException ex)
                {
                    // Обработка исключения
                    textBox1.Text = "Неверный формат строки";
                }
            }
            

        private void a7_Click(object sender, EventArgs e) 
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "7";
                equal1 += 7;
                n = 0;
            }
            else
            {
                textBox1.Text += "7";
                equal1 += 7;
                n = 0;
            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "8";
                equal1 += 8;
                n = 0;
            }
            else
            {
                textBox1.Text += "8";
                equal1 += 8;
                n = 0;
            }
        }

        private void a9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "9";
                equal1 += 9;
                n = 0;
            }
            else
            {
                textBox1.Text += "9";
                equal1 += 9;
                n = 0;
            }

        }

        private void delit_Click(object sender, EventArgs e) 
        {
            if (equal1.Length == 0)
            {
                textBox1.Text = "Введите число!!!";
            }
            if (penie != '/')
            {
                penie = '/';
                textBox1.Clear();
                try
                {
                    equal += double.Parse(equal1);
                    equal1 = "";
                    n = 0;
                }
                catch (System.FormatException ex)
                {
                    textBox1.Text = "Чисел нет";
                }
            }
            else
            {
                
            }
        }

        private void procent_Click(object sender, EventArgs e) 
        {
            {
                if (equal1.Length == 0)
                {
                    textBox1.Text = "Введите число!!!";
                }
                if (penie != 'p')
                {
                    penie = 'p';
                    textBox1.Clear();
                    try
                    {
                        equal += double.Parse(equal1);
                        equal1 = "";
                        n = 0;
                    }
                    catch (System.FormatException ex)
                    {
                        textBox1.Text = "Чисел нет";
                    }
                }
                else
                {

                }
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "4";
                equal1 += 4;
                n = 0;
            }
            else
            {
                textBox1.Text += "4";
                equal1 += 4;
                n = 0;
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "5";
                equal1 += 5;
                n = 0;
            }
            else
            {
                textBox1.Text += "5";
                equal1 += 5;
                n = 0;
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "6";
                equal1 += 6;
                n = 0;
            }
            else
            {
                textBox1.Text += "6";
                equal1 += 6;
                n = 0;
            }
        }

        private void umnoshit_Click(object sender, EventArgs e)
        {
            if (equal1.Length == 0)
            {
                textBox1.Text = "Введите число!!!";
            }
            else if (penie != '*')
            {
                penie = '*';
                textBox1.Clear();
                try
                {
                    equal += double.Parse(equal1);
                    equal1 = "";
                    n = 0;
                }
                catch (System.FormatException ex)
                {
                    textBox1.Text = "Чисел нет";
                }
            }

            else
            {
                
            }
        }

        private void kvadrat_Click(object sender, EventArgs e)
        {
            if (equal1.Length == 0)
            {
                textBox1.Text = "Введите число!!!";
            }
            if (penie != 'k')
            {
                penie = 'k';
                textBox1.Clear();
                try
                {
                    equal += double.Parse(equal1);
                    equal1 = "";

                    double res = equal * equal;
                    equal = res;
                    textBox1.Text = equal.ToString();
                    n = 1;
                }
                catch (System.FormatException ex)
                {
                    // Обработка исключения
                    textBox1.Text = "Неверный формат строки";
                }
            }
            else
            {
                // Остальные действия
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!" || textBox1.Text == "Чисел нет")
            {
                textBox1.Clear();
                textBox1.Text += "1";
                equal1 += 1;
                n = 0;
            }
            else
            {
                textBox1.Text += "1";
                equal1 += 1;
                n = 0;
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!")
            {
                textBox1.Clear();
                textBox1.Text += "2";
                equal1 += 2;
                n = 0;
            }
            else
            {
                textBox1.Text += "2";
                equal1 += 2;
                n = 0;
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!")
            {
                textBox1.Clear();
                textBox1.Text += "3";
                equal1 += 3;
                n = 0;
            }
            else
            {
                textBox1.Text += "3";
                equal1 += 3;
                n = 0;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!equal1.Contains('-'))
            {
                equal1 += '-';
                textBox1.Text += "-";
            }
            else if (equal1.Length != 1 && equal1.Length !=0)
            {
                penie = '-';
                textBox1.Clear();
                equal += double.Parse(equal1);
                equal1 = "";
                n = 0;
            }
        }
           

        private void ravno_Click(object sender, EventArgs e)
        {
            switch (penie)
            {
                case '+':
                    double res = equal + double.Parse(equal1);
                    equal = res;
                    textBox1.Text = equal.ToString();
                    n = 1;
                    break;

                case '-':
                     res = equal - double.Parse(equal1);
                      equal = res;
                       textBox1.Text = equal.ToString();
                       n = 1;
                    break;
                   
                case '*':
                       res = equal * double.Parse(equal1);
                       equal = res;
                       textBox1.Text = equal.ToString();
                       n = 1;
                    break;

                case '/':
                    if (double.Parse(equal1) != 0)
                    {
                        res = equal / double.Parse(equal1);
                        equal = res;
                        textBox1.Text = equal.ToString();
                        n = 1;
                    }
                    break;

                case 'p':
                        res = equal * double.Parse(equal1) / 100;
                        equal = res;
                        textBox1.Text = equal.ToString();
                        textBox4.Clear();
                        n = 1;
                    break;
            }
        }

        private void a0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите число!!!")
            {
                textBox1.Clear();
                textBox1.Text += "0";
                equal1 += 0;
                n = 0;
            }
            else
            {
                textBox1.Text += "0";
                equal1 += 0;
                n = 0;
            }
        }

        private void zapyataya_Click(object sender, EventArgs e) 
        {
            if (equal1.Contains(','))
            {
                
            }
            else
            {
                equal1 += ',';
                textBox1.Text += ",";
                n = 0;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (equal1.Length == 0)
            {
                textBox1.Text = "Введите число!!!";
            }
            if (penie != '+')
            {
                penie = '+';
                textBox1.Clear();
                try
                {
                    equal += double.Parse(equal1);
                    equal1 = "";
                    n = 0;
                }
                catch (System.FormatException ex)
                {
                    // Обработка исключения
                    textBox1.Text = "Неверный формат строки";
                }
            }
            else
            {
                // Остальные действия
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n != 1 && equal != 0) 
            {
                textBox2.Text = penie.ToString();
                textBox4.Text = equal.ToString();
            }
            else
            {
                textBox4.Text = " ";
                textBox2.Text = " ";
            }
     
        }
    }
}
