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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            switch (Data.combocheck)
            {
                case 0:
                    {
                        label1.Text = "Номинал сопротивления (К/Вт):";
                        label2.Hide();
                        label3.Hide();
                        label4.Hide();
                        textBox2.Hide();
                        textBox3.Hide();
                        textBox4.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        break;
                    }
                case 1:
                    {
                        label1.Text = "1ый размер эквивалентного прямоугольного сечения теплового \n потока через твёрдое тело (мм):";
                        label2.Text = "2ой размер эквивалентного прямоугольного сечения теплового \n потока через твёрдое тело (мм):";
                        label3.Text = "Длина пути в твёрдом теле теплового потока (мм):";
                        label4.Text = "Коэффициент теплопроводности тела (Вт/м*К):";
                        radioButton1.Hide();
                        radioButton2.Hide();
                        break;
                    }
                case 2:
                    {
                        label1.Text = "Эквивалентный диаметр площади контакта:";
                        label2.Hide();
                        label3.Hide();
                        label4.Hide();
                        textBox2.Hide();
                        textBox3.Hide();
                        textBox4.Hide();
                        break;
                    }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.kolvo_TB2 != Peremen.F2_TB2)
            {
                this.Hide();
                Data.combocheck = -1;
            }
            else
            {
                this.Close();
            }
        }
    }
}
