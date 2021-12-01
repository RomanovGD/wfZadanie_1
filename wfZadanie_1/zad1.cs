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
    public partial class zad1 : Form
    {
        public zad1()
        {
            InitializeComponent();
        }
        double sum(double fM, double diff, int N)
        {
            double lM = fM + (N - 1) * diff;
            Console.WriteLine(lM);
            Console.WriteLine();
            return ((2 * fM + diff * (N - 1)) / 2) * N;
        }
        private void zad1_Load(object sender, EventArgs e)
        {
            labResult.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstMember, diff;
            int count;
            try
            {
                firstMember = Double.Parse(tbFM.Text);
                diff = Double.Parse(tbDiff.Text);
                count = int.Parse(tbN.Text);
                labResult.Text = "Сумма: " + sum(firstMember, diff, count).ToString();
            }
            catch (System.FormatException)
            {
                labResult.Text = "Введено что-то не то";
            }
            finally
            {
                labResult.Visible = true;
            }
        }
    }
}
