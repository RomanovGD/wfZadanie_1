using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie_1
{
    public partial class zad2 : Form
    {
        public zad2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = Double.Parse(tbA.Text);
                b = Double.Parse(tbB.Text);
                c = Double.Parse(tbC.Text);
                labResult.Text = a == b || a == c || c == b ? "Треугольник равнобедренный" : "Треугольник не равнобедренный";
            }
            catch(System.FormatException)
            {
                labResult.Text = "Введено что-то не то";
            }
            finally
            {
                labResult.Visible = true;
            }
        }

        private void zad2_Load(object sender, EventArgs e)
        {
            labResult.Visible = false;
        }
    }
}
