using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_10_PE
{
    public partial class Form1 : Form
    {

        //SOLVED
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            long s = 0;
            for(int n=2;n<2000000;n++)
            {
                if (prime(n))
                    s += n;
            }
            textBox1.Text = s.ToString();

        }

        bool prime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
