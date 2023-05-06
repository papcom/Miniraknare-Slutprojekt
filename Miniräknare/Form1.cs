using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniräknare
{
    public partial class Form1 : Form
    {
        //input
        string input;
        //cache1 = första input-värdet
        string cache1;
        //cache2 = andra input-värdet (dvs efter operatören)
        string cache2;
        //cache3 = svaret av beräkningen (ans)
        double cache3;
        //operatör
        char operator1;
        //resultat av beräkningen
        double result = 0.0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Metod för operatörer, startas av (=)
        public void button24_Click(object sender, EventArgs e)
        {
            cache2 = input;
            //Felhantering
            try
            {
                //Temporära variabler
                double tmp1;
                double tmp2;
                double tmp3;
                //Konverterar inputs till double (tmp1 och tmp2), cache3 är redan double
                tmp1 = double.Parse(cache1);
                tmp2 = double.Parse(cache2);
                tmp3 = cache3;
                Numbers numbers = new Numbers(tmp1, tmp2);
                //Addition
                if (operator1 == '+')
                {
                    double ans = numbers.Add();
                    textBox1.Text = ans.ToString();
                    cache1 = textBox1.Text;
                    cache3 = ans;
                }
                //Multiplikation
                else if (operator1 == '*')
                {
                    double ans = numbers.Multiply();
                    //Multiplikation rundas av till två decimaler
                    textBox1.Text = Math.Round(ans, 2).ToString();
                    cache1 = textBox1.Text;
                    cache3 = ans;
                }
                //Division
                else if (operator1 == '/')
                {
                    double ans = numbers.Divide();
                    //Division rundas också av till två decimaler
                    textBox1.Text = Math.Round(ans, 2).ToString();
                    cache1 = textBox1.Text;
                    cache3 = ans;
                }
                //Subtraktion
                else if (operator1 == '-')
                {
                    double ans = numbers.Subtract();
                    textBox1.Text = ans.ToString();
                    cache1 = textBox1.Text;
                    cache3 = ans;
                }
                //Upphöjt till två
                else if (operator1 == '^')
                {
                    double ans = numbers.Square();
                    textBox1.Text = Math.Round(ans, 2).ToString();
                    cache1 = textBox1.Text;
                    cache3 = ans;
                }
                else
                {
                    textBox1.Text = "ERROR";
                }
            }
            catch
            {
                textBox1.Text = "ERROR";
            }
        }

        // Knapp 1
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        // Knapp 2
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        // Knapp 3
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        // Knapp 4
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        // Knapp 5
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        // Knapp 6
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        // Knapp 7
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        // Knapp 8
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        // Knapp 9
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        // Knapp 0
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;
        }

        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //try-catch för att förhindra att appen kraschar när input.Length blir 0
            try
            {
                input = input.Remove(input.Length - 1);
            }
            catch
            {

            }
            textBox1.Text = input;
        }

        //CE
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = "";
        }

        // Knapp (,)
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += ",";
            textBox1.Text += input;
        }

        // Knapp (+)
        private void button20_Click(object sender, EventArgs e)
        {
            cache1 = input;
            operator1 = '+';
            input = "";
        }

        // Knapp (-)
        private void button16_Click(object sender, EventArgs e)
        {
            
                cache1 = input;
                operator1 = '-';
                input = "";
            
        }

        // Knapp (*)
        private void button12_Click(object sender, EventArgs e)
        {
            
                cache1 = input;
                operator1 = '*';
                input = "";
            
        }

        // Knapp (/)
        private void button8_Click(object sender, EventArgs e)
        {
               cache1 = input;
               operator1 = '/';
               input = "";
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Clear, hade inte tid att fixa funktionen, fungerar som CE istället
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cache1 = input;
            operator1 = '^';
            input = "";
        }
        //Ans (svaret på senaste beräkningen)
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = cache3.ToString();
        }
    }
}
