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
    public partial class Form6 : Form
    {
        public int k = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            kolvo.kolvo_TB4 = 1;
            kolvo.kolvo_TB5 = 0;
            tempVnesh();
        }

        public void tempVnesh()
        {
            k++;
            label3.Text = "Внешняя температура по шкале цельсия";
            label4.Text = k.ToString(); ;
            label6.Text = "воздействия (внешняя температура)";
        }

        public void tempVnutr()
        {
            k++;
            label3.Text = "Значение тепловых потоков внутренних источников (Вт)";
            label4.Text = k.ToString(); ;
            label6.Text = "воздействия (источник внутренних тепловыделений)";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kolvo.kolvo_TB5 < Peremen.F2_TB5)
            {
                kolvo.kolvo_TB5++;
                tempVnesh();
            }
            else
            {
                tempVnutr();
                if (kolvo.kolvo_TB4 <= Peremen.F2_TB4)
                {
                    kolvo.kolvo_TB4++;
                    if (kolvo.kolvo_TB4 > Peremen.F2_TB4)
                    {
                        this.Close();
                        MessageBox.Show("Ввод закончен");
                    }
                }
            }
        }
    }
    static class kolvo
    {
        public static int kolvo_TB4
        {
            get;
            set;
        }
        public static int kolvo_TB5
        {
            get;
            set;
        }
    }
}
