using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4
{
    class LinearReg
    {
        private System.Windows.Forms.DataGridView grid;
        int n = 0;
        double sumx = 0.0;
        double sumy = 0.0;
        double sumxy = 0.0;
        double a0 = 0.0;
        double a1 = 0.0;
        double sumyy = 0.0;
        double sume2 = 0.0;
        double r = 0.0;
        double r1 = 0.0;
        double exp = 0.5;
        double temp = 0.0;
        double ybar = 0.0;
        int i = 0;
        double sumxx = 0, sumyyy = 0, sumx2 = 0;
        double sumxxy = 0;

        public void SetGrid(System.Windows.Forms.DataGridView g)
        {
            grid = g;
        }

        public void solve()
        {
            n = grid.Rows.Count;
            sumx = 0;
            for (i = 0; i < n; i++)
            {
                sumx += Double.Parse(grid[1, i].Value.ToString());
            }
            for (i = 0; i < n; i++)
            {
                sumy += Double.Parse(grid[2, i].Value.ToString());
            }
            for (i = 0; i < n; i++)
            {
                temp = Double.Parse(grid[1, i].Value.ToString()) * Double.Parse(grid[2, i].Value.ToString());
                sumxy += Math.Round(temp, 5);
            }
            for (i = 0; i < n; i++)
            {
                temp = Double.Parse(grid[1, i].Value.ToString()) * Double.Parse(grid[1, i].Value.ToString());
                sume2 += Math.Round(temp, 5);
            }

            a1 = (n * sumxy - sumx * sumy) / (7 * sume2 - (sumx * sumx));
            a1 = Math.Round(a1, 5);
            a0 = (sumy / n) - a1 * (sumx / n);
            a0 = Math.Round(a0, 5);

            ybar = sumy / n;

            for (i = 0; i < n; i++)
            {
                temp = (Double.Parse(grid[2, i].Value.ToString()) - ybar) * (Double.Parse(grid[2, i].Value.ToString()) - ybar);
                sumyy += Math.Round(temp, 5);
            }
            for (i = 0; i < n; i++)
            {
                temp = Double.Parse(grid[2, i].Value.ToString()) - a0 - a1 * Double.Parse(grid[1, i].Value.ToString());
                sume2 += Math.Round(temp * temp, 5);
            }

            r = ((sumyy - sume2) / sumyy);
            r1 = (Math.Pow(r, exp));
        }

        public void solveSUM()
        {
            n = grid.Rows.Count;

            for (int i = 0; i < n; i++)
            {
                sumxx += Double.Parse(grid[1, i].Value.ToString());
                sumyyy += Double.Parse(grid[2, i].Value.ToString());
                sumx2 += Double.Parse(grid[3, i].Value.ToString());
                sumxxy += Double.Parse(grid[4, i].Value.ToString());
            }

        }

        public double getA0()
        {
            return a0;
        }



        public double getA1()
        {
            return a1;
        }

        public double getSumX()
        {
            return sumxx;
        }
        public double getSumYY()
        {
            return sumyyy;
        }
        public double getSumX2()
        {
            return sumx2;
        }
        public double getSumXXY()
        {
            return sumxxy;
        }
        public double getY()
        {
            return ybar;
        }
        public String getR()
        {
            return r1.ToString("F4");
        }
        public double getN()
        {
            n = grid.RowCount;
            return n;
        }
    }
}
