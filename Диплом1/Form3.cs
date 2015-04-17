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
        private int i = 0;
        private int k = 0;
        public Form3()
        {
            InitializeComponent();
            Data.kolvo_TB2 = 1;
            Data.kolvo_TB3 = 1;
            TipLineVetv();
            Data.i = 0;
            Data.i1 = 0;
            Data.TUL = new int[Peremen.F2_TB2, 4];
            Data.TUN = new int[Peremen.F2_TB3, 3];
            Data.RL = new int[Peremen.F2_TB2, 2];
            Data.RLMB = new int[Peremen.F2_TB2, 2];
            Data.RN = new double[Peremen.F2_TB3, 3];
            Data.RKN = new double[Peremen.F2_TB3, 3];
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
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
                Data.TUL[i, 0] = int.Parse(textBox1.Text);
                Data.TUL[i, 1] = int.Parse(textBox2.Text);
                Data.TUL[i, 2] = int.Parse(textBox3.Text);
                Data.TUL[i, 3] = Data.combocheck;
                Form4 fourthForm = new Form4();
                fourthForm.ShowDialog();
                Data.kolvo_TB2++;
                i++;
                Line();
                Data.i++;
            }
            else
            {
                if (Data.kolvo_TB3 <= Peremen.F2_TB3)
                {
                    Data.TUN[k, 0] = int.Parse(textBox1.Text);
                    Data.TUN[k, 1] = int.Parse(textBox2.Text);
                    //  Data.TUL[Data.kolvo_TB3 - 1, 2] = int.Parse(textBox3.Text);
                    Data.TUN[k, 2] = Data.combocheck;
                    Form5 fifthForm = new Form5();
                    fifthForm.ShowDialog();
                    textBox1.ResetText();
                    textBox2.ResetText();
                    Data.kolvo_TB3++;
                    k++;
                    Data.i1++;
                    if (Data.kolvo_TB3 > Peremen.F2_TB3)
                    {
                        this.Hide();
                        Form6 sixthForm = new Form6();
                        sixthForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
        public void TipLineVetv()
        {
            comboBox1.Items.Add("Для ветвей с задаными тепловымы сопротивлениями");
            comboBox1.Items.Add("Для кондуктивных ветвей, тепл. сопр. которых будет рассчитываться в программе");
            comboBox1.Items.Add("Для ветвей, описывающих контактное сопротивление");
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
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
               // Data.i = 0;
                textBox1.ResetText();
                textBox2.ResetText();
                label2.Text = "Формирование матриц описания не линейных ветвей";
                label5.Hide();
                textBox3.Hide();
                comboBox1.Items.Clear();
                TipNeLineVetv();
            }
            comboBox1.Text = "Тип ветви";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        public static int[,] TUL
        {
            get;
            set;
        }
        public static int[,] TUN
        {
            get;
            set;
        }
        public static int[,] RL
        {
            get;
            set;
        }
        public static int[,] RLMB
        {
            get;
            set;
        }
        public static double[,] RN
        {
            get;
            set;
        }
        public static double[,] RKN
        {
            get;
            set;
        }
        public static int i
        {
            get;
            set;
        }
        public static int i1
        {
            get;
            set;
        }
    }
}
