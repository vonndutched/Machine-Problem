using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using info.lundin.math;

namespace MP4
{
    class NumDifferentiation
    {
        private double xi;
        private double fxi;
        private double xiadd;
        private double fxiadd;
        private double ximinus;
        private double fximinus;
        private double xiadd2;
        private double fxiadd2;
        private double ximinus2;
        private double fximinus2;
        private double h;
        private double diffEstimate;
        private double diffEstimateMORE;
        private ExpressionParser myParse;
        Hashtable myHash;

        public void Start(double stepSize, double inSize)
        {
            myParse = new ExpressionParser();
            myHash = new Hashtable();
            xi = inSize;
            h = stepSize;
        }
        public double getDiffEstiMORE()
        {
            return diffEstimateMORE;
        }
        public double getFX()
        {
            return fxi;
        }
        public double getXi1()
        {
            return xiadd;
        }
        public double getFXi1()
        {
            return fxiadd;
        }
        public double getXi2()
        {
            return xiadd2;
        }
        public double getFXi2()
        {
            return fxiadd2;
        }
        public double getFXmin1()
        {
            return fximinus;
        }
        public double getXmin1()
        {
            return ximinus;
        }
        public double getFXmin2()
        {
            return fximinus2;
        }
        public double getXmin2()
        {
            return ximinus2;
        }
        public void Compute(string equation)
        {
            xiadd = xi + h;
            xiadd2 = xi + (2 * h);
            ximinus = xi - h;
            ximinus2 = xi - (2 * h);

            myHash.Clear();
            myHash.Add("x", xi.ToString());
            fxi = myParse.Parse(equation, myHash);

            myHash.Clear();
            myHash.Add("x", xiadd.ToString());
            fxiadd = myParse.Parse(equation, myHash);

            myHash.Clear();
            myHash.Add("x", xiadd2.ToString());
            fxiadd2 = myParse.Parse(equation, myHash);

            myHash.Clear();
            myHash.Add("x", ximinus.ToString());
            fximinus = myParse.Parse(equation, myHash);

            myHash.Clear();
            myHash.Add("x", ximinus2.ToString());
            fximinus2 = myParse.Parse(equation, myHash);
        }
        public void ForwardDivideDifference(string equation)
        {
            diffEstimate = (fxiadd - fxi) / (xiadd - xi);
            diffEstimateMORE = ((-1 * fxiadd2) + (4 * fxiadd) + (-3 * fxi)) / (2 * h);
        }
        public string Display()
        {
            //string message = "Estimate: " + diffEstimate;
            string message = Math.Round(diffEstimate, 5).ToString();
            return message;
        }
    }
}
