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
