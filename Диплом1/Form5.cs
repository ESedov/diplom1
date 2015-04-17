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
    public partial class Form5 : Form
    {
        private double RB;
        public Form5()
        {
            InitializeComponent();
            switch (Data.combocheck)
            {
                case 0:
                    {
                        label1.Text = "1ый размер теплоотдающей поверхности (мм)";
                        label2.Text = "2ой размер теплоотдающей поверхности (мм)";
                        label3.Hide();
                        label4.Hide();
                        label5.Hide();
                        label6.Hide();
                        textBox3.Hide();
                        textBox4.Hide();
                        textBox5.Hide();
                        textBox6.Hide();
                        label8.Text = "Коэффициент ориентации поверхности";
                        break;
                    }
                case 1:
                    {
                        label1.Text = "1ый размер теплоотдающей поверхности (мм)";
                        label2.Text = "2ой размер теплоотдающей поверхности (мм)";
                        label3.Text = "Приведенная степень черноты поверхности";
                        label4.Text = "Коэффициент облученности";
                        label5.Hide();
                        label6.Hide();
                        textBox5.Hide();
                        textBox6.Hide();
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
                case 2:
                    {
                        label1.Text = "1ый размер теплоотдающей поверхности (мм)";
                        label2.Text = "2ой размер теплоотдающей поверхности (мм)";
                        label3.Text = "Расстояние между стенками канала (мм)";
                        label4.Text = "Номер узла модели, моделирующего темп. воздуха на вх. в канал";
                        label5.Hide();
                        label6.Hide();
                        textBox5.Hide();
                        textBox6.Hide();
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
                case 3:
                    {
                        label1.Text = "1ый размер теплоотдающей поверхности (мм)";
                        label2.Text = "2ой размер теплоотдающей поверхности (мм)";
                        label3.Text = "Расстояние между стенками канала (мм)";
                        label4.Hide();
                        label5.Hide();
                        label6.Hide();
                        textBox4.Hide();
                        textBox5.Hide();
                        textBox6.Hide();
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
                case 4:
                    {
                        label1.Text = "Шаг рёбер (по гориз. стороне радиатора) (мм)";
                        label2.Text = "Высота рёбер (мм)";
                        label3.Text = "Высота оребрённой поверхности";
                        label4.Text = "Толщина (диаметр) ребра";
                        label5.Text = "Количество рёбер";
                        label6.Text = "Коэф. теплопроводности материала ребер (Вт/м*К)";
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
                case 5:
                    {
                        label1.Text = "Шаг рёбер (по гориз. стороне радиатора) (мм)";
                        label2.Text = "Высота рёбер (мм)";
                        label3.Text = "Высота оребрённой поверхности";
                        label4.Text = "Толщина (диаметр) ребра";
                        label5.Text = "Количество рёбер";
                        label6.Text = "Коэф. теплопроводности материала ребер (Вт/м*К)";
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
                case 6:
                    {
                        label1.Text = "1ый размер теплоотдающей поверхности (мм)";
                        label2.Text = "2ой размер теплоотдающей поверхности (мм)";
                        label3.Text = "Толщина воздушной прослойки";
                        label4.Hide();
                        label5.Hide();
                        label6.Hide();
                        textBox4.Hide();
                        textBox5.Hide();
                        textBox6.Hide();
                        label8.Hide();
                        radioButton1.Hide();
                        radioButton2.Hide();
                        radioButton3.Hide();
                        break;
                    }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.kolvo_TB3 <= Peremen.F2_TB3)
            {
                switch (Data.combocheck)
                {
                    case 0:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = 0;

                            Data.RKN[Data.i1, 0] = RB;
                            Data.RKN[Data.i1, 1] = 0;
                            Data.RKN[Data.i1, 2] = 0;
                            break;
                        }
                    case 1:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = 0;

                            Data.RKN[Data.i1, 0] = double.Parse(textBox3.Text);
                            Data.RKN[Data.i1, 1] = double.Parse(textBox4.Text);
                            Data.RKN[Data.i1, 2] = 0;
                            break;
                        }
                    case 2:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = 0;

                            Data.RKN[Data.i1, 0] = double.Parse(textBox3.Text);
                            Data.RKN[Data.i1, 1] = double.Parse(textBox4.Text);
                            Data.RKN[Data.i1, 2] = 0;
                            break;
                        }
                    case 3:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = 0;

                            Data.RKN[Data.i1, 0] = double.Parse(textBox3.Text);
                            Data.RKN[Data.i1, 1] = 0;
                            Data.RKN[Data.i1, 2] = 0;
                            break;
                        }
                    case 4:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = double.Parse(textBox3.Text);

                            Data.RKN[Data.i1, 0] = double.Parse(textBox4.Text);
                            Data.RKN[Data.i1, 1] = double.Parse(textBox5.Text);
                            Data.RKN[Data.i1, 2] = double.Parse(textBox6.Text);
                            break;
                        }
                    case 5:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = double.Parse(textBox3.Text);

                            Data.RKN[Data.i1, 0] = double.Parse(textBox4.Text);
                            Data.RKN[Data.i1, 1] = double.Parse(textBox5.Text);
                            Data.RKN[Data.i1, 2] = double.Parse(textBox6.Text);
                            break;
                        }
                    case 6:
                        {
                            Data.RN[Data.i1, 0] = double.Parse(textBox1.Text);
                            Data.RN[Data.i1, 1] = double.Parse(textBox2.Text);
                            Data.RN[Data.i1, 2] = 0;

                            Data.RKN[Data.i1, 0] = double.Parse(textBox3.Text);
                            Data.RKN[Data.i1, 1] = 0;
                            Data.RKN[Data.i1, 2] = 0;
                            break;
                        }
                }
                this.Close();
                Data.combocheck = -1;
            }
            /*    else
               {
                   /* this.Hide();
                   Form6 sixthForm = new Form6();
                   sixthForm.ShowDialog(); 
                   this.Close();
               } */
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RB = 0.7;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RB = 1.3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RB = 1;
        }
    }
}
