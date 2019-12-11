using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;

namespace Runge_Kutta
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            string expression = functionTextBox.Text;
            double x0 = Convert.ToDouble(x0TextBox.Text);
            double y0 = Convert.ToDouble(y0TextBox.Text);
            double x = Convert.ToDouble(xTextBox.Text);
            double h = Convert.ToDouble(hTextBox.Text);

            RungeKutta rungeKutta = new RungeKutta(expression, x0, y0, x, h);
            resultLabel.Text = "El valor de y cuando x = " + xTextBox.Text + " es: " +rungeKutta.Evaluate().ToString("N10");
        }
    }
}
