using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                a = a + b;
                label1.Text = Convert.ToString(a);
            }
            else

            {
                MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку") ;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    a = a - b;
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }

            }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    a = a * b;
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                   
                    {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    if (b == 0)
                        MessageBox.Show(text: "Делить на ноль нелязя!");
                    else
                    {
                        a = a / b;
                        label1.Text = Convert.ToString(a);
                    }
                }
                 
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
            }

        private void button5_Click(object sender, EventArgs e)

        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    a = Math.Abs(a + b);
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    double c;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    c = (a * b) *0.01;
                    label1.Text = Convert.ToString(c);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    double c;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    c=Math.Log(b)/Math.Log(a);
                    label1.Text = Convert.ToString(c);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    double a;
                    a = Convert.ToInt32(textBox1.Text);
                    textBox1.Text = "";
                    a = Math.Sqrt(a);
            
                    label1.Text = Convert.ToString(a);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b;
                    double c;
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    c = Math.Exp(b*Log(a));
                    label1.Text = Convert.ToString(c);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int a, b, c, d, m, f, g, h, j, k, l, u, y, t, p, q, w, z;
                a = Convert.ToInt32(textBox3.Text);
                b = Convert.ToInt32(textBox4.Text);
                c = Convert.ToInt32(textBox5.Text);
                d = Convert.ToInt32(textBox6.Text);
                m = Convert.ToInt32(textBox7.Text);
                f = Convert.ToInt32(textBox8.Text);
                g = Convert.ToInt32(textBox9.Text);
                h = Convert.ToInt32(textBox10.Text);
                j = Convert.ToInt32(textBox11.Text);
                k = Convert.ToInt32(textBox12.Text);
                l = Convert.ToInt32(textBox13.Text);
                u = Convert.ToInt32(textBox14.Text);
                y = Convert.ToInt32(textBox15.Text);
                t = Convert.ToInt32(textBox16.Text);
                p = Convert.ToInt32(textBox17.Text);
                q = Convert.ToInt32(textBox18.Text);
                w = Convert.ToInt32(textBox19.Text);
                z = Convert.ToInt32(textBox20.Text);
                
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                a = a + k;
                b = b + l;
                c = c + u;
                d = d + y;
                m = m + t;
                f = f + p;
                g = g + q;
                h = h + w;
                j = j + z;
         
                textBox21.Text = Convert.ToString(a);
                textBox22.Text = Convert.ToString(b);
                textBox23.Text = Convert.ToString(c);
                textBox24.Text = Convert.ToString(d);
                textBox25.Text = Convert.ToString(m);
                textBox26.Text = Convert.ToString(f);
                textBox27.Text = Convert.ToString(g);
                textBox28.Text = Convert.ToString(h);
                textBox29.Text = Convert.ToString(j);
            }
            else

            {
                MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
            }

    }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked == true)
                {
                    int a, b, c, d, m, f, g, h, j, k, l, u, y, t, p, q, w, z,aa,bb,cc,dd,ff,gg,ss,qq,zz;
                    a = Convert.ToInt32(textBox3.Text);
                    b = Convert.ToInt32(textBox4.Text);
                    c = Convert.ToInt32(textBox5.Text);
                    d = Convert.ToInt32(textBox6.Text);
                    m = Convert.ToInt32(textBox7.Text);
                    f = Convert.ToInt32(textBox8.Text);
                    g = Convert.ToInt32(textBox9.Text);
                    h = Convert.ToInt32(textBox10.Text);
                    j = Convert.ToInt32(textBox11.Text);
                    k = Convert.ToInt32(textBox12.Text);
                    l = Convert.ToInt32(textBox13.Text);
                    u = Convert.ToInt32(textBox14.Text);
                    y = Convert.ToInt32(textBox15.Text);
                    t = Convert.ToInt32(textBox16.Text);
                    p = Convert.ToInt32(textBox17.Text);
                    q = Convert.ToInt32(textBox18.Text);
                    w = Convert.ToInt32(textBox19.Text);
                    z = Convert.ToInt32(textBox20.Text);

                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
                    textBox12.Text = "";
                    textBox13.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox16.Text = "";
                    textBox17.Text = "";
                    textBox18.Text = "";
                    textBox19.Text = "";
                    textBox20.Text = "";
                    aa = (a * k) + (d * l) + (g * u);
                    bb = (a * y) + (d * t) + (g * p);
                    cc = (a * q) + (d * w) + (g * z);
                    dd = (b * k) + (m * l) + (h * u);
                    ff = (b * y) + (m * t) + (h * p);
                    gg = (b * q) + (m * w) + (h * z);
                    ss = (c * k) + (f * l) + (j * u);
                    qq = (c * y) + (f * t) + (j * p);
                    zz = (c * q) + (f * w) + (j * z);

                    textBox21.Text = Convert.ToString(aa);
                    textBox22.Text = Convert.ToString(bb);
                    textBox23.Text = Convert.ToString(cc);
                    textBox24.Text = Convert.ToString(dd);
                    textBox25.Text = Convert.ToString(ff);
                    textBox26.Text = Convert.ToString(gg);
                    textBox27.Text = Convert.ToString(ss);
                    textBox28.Text = Convert.ToString(qq);
                    textBox29.Text = Convert.ToString(zz);
                }
                else

                {
                    MessageBox.Show(text: "Для использованиия калькулятора нажмите на галочку");
                }
            }
            }
    }
    }
