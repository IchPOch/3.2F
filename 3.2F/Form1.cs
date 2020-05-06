using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int f(int x)
        {
            int y;
            if (x < 0) return 0;
            else
            {
                if (x == 1) return 1;
                else return y = x * x + 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, h;
            if (A.Text == "" || B.Text == "" || H.Text == "") V.Text = "Неккоректные введённые данные";
            else
            {
                a = Convert.ToInt32(A.Text);
                b = Convert.ToInt32(B.Text);
                h = Convert.ToInt32(H.Text);
                V.Text = "";
                if (b < a) V.Text = "Неккоректно введены данные";
                else
                {
                    V.Text = "";
                    for (int i = a; i < b; i += h)
                    {
                        V.Text += "f(" + i + ") = " + f(i);
                        V.Text += Environment.NewLine;
                    }

                }
            }
        }
    }
}