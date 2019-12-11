using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;
using System.Diagnostics;

namespace Runge_Kutta
{
    class RungeKutta
    {
        public Function Function { get; set; }
        public double x0 { get; set; }
        public double y0 { get; set; }
        public double x { get; set; }
        public double h { get; set; }
        
        public RungeKutta(string function, double x0, double y0,
            double x, double h)
        {
            Function = new Function($"f(x,y) = {function}");
            this.x0 = x0;
            this.y0 = y0;
            this.x = x;
            this.h = h;
        }

        public double Evaluate()
        {
            int iteration = (int)((x - x0) / h);

            double k1;
            double k2;
            double k3;
            double k4;


            for(int i = 0; i < iteration; i++)
            {
                k1 = h * Function.calculate(x0,y0);
                k2 = h * Function.calculate(x0 + (0.5 * h) , y0 + (0.5 * k1));
                k3 = h * Function.calculate(x0 + (0.5*h), y0 + (0.5 * k2));
                k4 = h * Function.calculate(x0 + h, y0 + k3);


                y0 += (1.0 / 6.0) * (k1 + 2 * k2 + 2 * k3 + k4);
                x0 += h;
            }

            return y0;
        }


        private double EvaluateFunction(double x, double y)
        {
            return Function.calculate();
        }

    }
}
