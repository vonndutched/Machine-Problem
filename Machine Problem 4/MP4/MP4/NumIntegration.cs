using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using info.lundin.math;

namespace MP4
{
    class NumIntegration
    {
        double h, f, r, sum = 0, I = 0, IR = 0;

        private ExpressionParser myParse;
        private Hashtable myHash;

        double[] arrx = new double[10];
        double[] arrfx = new double[10];
        double[] arrtrap = new double[10];

        public double[] getArrFX()
        {
            return arrfx;
        }
        public double[] getArrX()
        {
            return arrx;
        }
        public double[] getArrTrap()
        {
            return arrtrap;
        }
        public double getSUM()
        {
            return sum;
        }

        public double getI()
        {
            return IR;
        }
        public void setData(int n, double xa, double xb, string equation)
        {
            myParse = new ExpressionParser();
            myHash = new Hashtable();
            h = (xb - xa) / n;

            for (int i = 0; i < (n + 1); i++)
            {
                if (i == 0)
                    f = (xa);
                else
                    f = f + h;
                arrx[i] = Math.Round(f, 4);
            }

            for (int j = 0; j < (n + 1); j++)
            {
                if (j == 0)
                    f = (xa);
                else
                    myHash.Clear();
                myHash.Add("x", arrx[j].ToString());
                arrfx[j] = Math.Round(myParse.Parse(equation, myHash), 4);
            }
        }

        public void useTrapRule(int n, double xa, double xb, string equation)
        {
            myParse = new ExpressionParser();
            myHash = new Hashtable();
            h = (xb - xa) / n;

            for (int i = 0; i < (n + 1); i++)
            {
                if (i == 0)
                    f = (xa);
                else
                    f = f + h;
                arrx[i] = Math.Round(f, 4);
            }

            for (int j = 0; j < (n + 1); j++)
            {
                if (j == 0)
                    f = (xa);
                else
                    myHash.Clear();
                myHash.Add("x", arrx[j].ToString());
                arrfx[j] = Math.Round(myParse.Parse(equation, myHash), 4);
            }

            for (int k = 0; k < (n + 1); k++)
            {
                if (k == 0)
                    f = (xa);
                else
                    getArrFX();
                if (k == 0 || k == n)
                    r = (1 * arrfx[k]);
                else
                {
                    r = (2 * arrfx[k]);
                }

                arrtrap[k] = Math.Round(r, 4);
                sum += arrtrap[k];
            }

            // getSUM();
            I = (h / 2) * sum;
            IR = Math.Round(I, 4);
        }
    }
}