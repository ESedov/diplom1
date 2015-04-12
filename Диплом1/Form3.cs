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
            Peremen.F2_TB2 = int.Parse(Peremen.TB2);
            Data.kolvo_TB2 = 1;
            if (Peremen.F2_TB2 > 0)
            {
                comboBox1.Items.Add("Для ветвей с задаными тепловымы сопротивлениями");
                comboBox1.Items.Add("Для кондуктивных ветвей, тепл. сопр. которых будет рассчитываться в программе");
                comboBox1.Items.Add("Для ветвей, описывающих контактное сопротивление");
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
                Form4 fourthForm = new Form4();
                fourthForm.ShowDialog();
                Data.kolvo_TB2++;
            }
            else
            {
                Form5 fifthForm = new Form5();
                fifthForm.ShowDialog();
            }
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
    }
}
