using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом1
{
   public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Peremen.F2_TB2; i++) 
            {
                textBox1.Text += " Tul \r\n  ";
                for (int j = 0; j < 4; j++)
                {
                    textBox1.Text += Data.TUL[i, j].ToString() + " ";
                }
            }
            textBox2.Text += "\r\n Tun \r\n ";
            for (int i = 0; i < Peremen.F2_TB3; i++)
            {
                textBox2.Text += " \r\n ";
                for (int j = 0; j < 3; j++)
                {
                    textBox2.Text += Data.TUN[i, j].ToString() + " ";
                }
            }
            textBox3.Text += "\r\n RL \r\n ";
            for (int i = 0; i < Peremen.F2_TB2; i++)
            {
                textBox3.Text += "\r\n ";
                for (int j = 0; j < 2; j++)
                {
                    textBox3.Text += Data.RL[i, j].ToString() + " ";
                }
            }
            textBox4.Text += "\r\n RLMB \r\n";
            for (int i = 0; i < Peremen.F2_TB2; i++)
            {
                textBox4.Text += " \r\n  ";
                for (int j = 0; j < 2; j++)
                {
                    textBox4.Text += Data.RLMB[i, j].ToString() + " ";
                }
            }
            textBox5.Text += "\r\n RN \r\n";
              for (int i = 0; i < Peremen.F2_TB3; i++)
              {
                  textBox5.Text += "\r\n ";
                  for (int j = 0; j < 3; j++)
                  {
                      textBox5.Text += Data.RN[i, j].ToString() + " ";
                  }
              }
              textBox6.Text += "\r\n RKN \r\n";
              for (int i = 0; i < Peremen.F2_TB3; i++)
              {
                  textBox6.Text += "\r\n ";
                  for (int j = 0; j < 3; j++)
                  {
                      textBox6.Text += Data.RKN[i, j].ToString() + " ";
                  }
              } 
        }
    }
   public class Peremen
   {
       public static int F2_TB1
       {
           get;
           set;
       }
       public static int F2_TB2
       {
           get;
           set;
       }
       public static int F2_TB3
       {
           get;
           set;
       }
       public static int F2_TB4
       {
           get;
           set;
       }
       public static int F2_TB5
       {
           get;
           set;
       }
       public static int F2_TB6
       {
           get;
           set;
       }
       public static string TB1
       {
           get;
           set;
       }
       public static string TB2
       {
           get;
           set;
       }
       public static string TB3
       {
           get;
           set;
       } 
       public static string TB4
       {
           get;
           set;
       }
       public static string TB5
       {
           get;
           set;
       }
       public static string TB6
       {
           get;
           set;
       }
   } 
}
