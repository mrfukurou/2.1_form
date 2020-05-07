using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(coord_x.Text);
                double y = Convert.ToDouble(coord_y.Text);
                if (x < 0 && x > -15 && y < 0 && y > -15)
                    rez.Text = "Точка находится вне заштрихованной области";
                else if (((x == -15 || x == 0) && y <= 0 && y >= (-15)) || ((y == -15 || y == 0) && x <= 0 && x >= (-15)))
                    rez.Text = "Точка находится на границе";
                else rez.Text = "Точка находится внутри заштрихованной области";
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод"); }
        }
    }
}
