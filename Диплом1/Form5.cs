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
                this.Hide();
                Data.combocheck = -1;
            }
            else
            {
                this.Hide();
                Form6 sixthForm = new Form6();
                sixthForm.ShowDialog();
                this.Close();
            }
        }
    }
}
