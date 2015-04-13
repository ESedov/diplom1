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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Data.kolvo_TB2 = 1;
            Data.kolvo_TB3 = 1;
            Peremen.F2_TB2 = int.Parse(Peremen.TB2);
            Peremen.F2_TB3 = int.Parse(Peremen.TB3);
            TipLineVetv();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.combocheck = comboBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.kolvo_TB2 <= Peremen.F2_TB2)
            {
                Form4 fourthForm = new Form4();
                fourthForm.ShowDialog();
                Data.kolvo_TB2++;
                Line();
            }
            else
                if(Data.kolvo_TB3 <= Peremen.F2_TB3)
                {
                    Data.kolvo_TB3++;
                    Form5 fifthForm = new Form5();
                    fifthForm.ShowDialog();
                    if (Data.kolvo_TB3 > Peremen.F2_TB3)
                        this.Close();
                }
        }
        public void TipLineVetv()
        {
            comboBox1.Items.Add("Для ветвей с задаными тепловымы сопротивлениями");
            comboBox1.Items.Add("Для кондуктивных ветвей, тепл. сопр. которых будет рассчитываться в программе");
            comboBox1.Items.Add("Для ветвей, описывающих контактное сопротивление");
        }
        public void TipNeLineVetv()
        {
            comboBox1.Items.Add("Конвективный теплоперенос с поверхности твёрдого тела \n в окружающий воздух по закону степени 1/4");
            comboBox1.Items.Add("Излучение тепловой энергии с поверхности твёрдого тела");
            comboBox1.Items.Add("Перенос тепла воздушным потоком в канале");
            comboBox1.Items.Add("Теплопередача от стенок канала к воздуху в канале");
            comboBox1.Items.Add("Кондуктивно-конвективная теплоотдача с оребрённой поверхности в среду \n (Пластинчатый радиатор)");
            comboBox1.Items.Add("Кондуктивно-конвективная теплоотдача с оребрённой поверхности в среду \n (штырьковый радиатор)");
            comboBox1.Items.Add("Кондуктивно-конвективный теплоперенос через \n тонкую воздушную прослойку малой толщины");
        }
        public void Line()
        {
            if (Data.kolvo_TB2 <= Peremen.F2_TB2)
            {
                comboBox1.Items.Clear();
                TipLineVetv();
            }
            else
            {
                label2.Text = "Формирование матриц описания не линейных ветвей";
                comboBox1.Items.Clear();
                TipNeLineVetv();
            }
            comboBox1.Text = "Тип ветви";
        }
   }
    static class Data
    {
        public static int combocheck
        {
            get;
            set;
        }
        public static int kolvo_TB2
        {
            get;
            set;
        }
        public static int kolvo_TB3
        {
            get;
            set;
        }
        public static Boolean metka
        {
            get;
            set;
        }
    }
}
