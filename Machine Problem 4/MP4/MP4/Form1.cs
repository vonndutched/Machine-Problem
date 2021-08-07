using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
using MetroFramework.Forms;

namespace MP4
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gridSize = 0;
        int gridSizeL = 0;
        int grid2Size = 0;
        int gridNewtonSize = 0, gridNewton2Size = 0, gridNewton3Size = 0, gridNewton4Size = 0, gridNewton5Size = 0, gridNewton6Size = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            double x, y, xi2, xy;
            x = double.Parse(txtX.Text);
            y = double.Parse(txtFx.Text);

            xi2 = x * x;
            xy = x * y;

            grid.Rows.Add(gridSize, x.ToString(), y.ToString(), xi2.ToString(), xy.ToString());
            gridSize++;
            txtX.Text = "";
            txtFx.Text = "";
            this.ActiveControl = txtX;
        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void buttonclr_Click(object sender, EventArgs e)
        {
            txtx1.Text = "";
            txtfx1.Text = "";
            txtx2.Text = "";
            txtfx2.Text = "";
            txtx3.Text = "";
            txtfx3.Text = "";
            txtx4.Text = "";
            txtfx4.Text = "";
            txtx5.Text = "";
            txtfx5.Text = "";
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, x5, fx1, fx2, fx3, fx4, fx5 = 0;
            try
            {
                x1 = double.Parse(txtx1.Text);
                x2 = double.Parse(txtx2.Text);
                x3 = double.Parse(txtx3.Text);
                x4 = double.Parse(txtx4.Text);
                x5 = double.Parse(txtx5.Text);
                fx1 = double.Parse(txtfx1.Text);
                fx2 = double.Parse(txtfx2.Text);
                fx3 = double.Parse(txtfx3.Text);
                fx4 = double.Parse(txtfx4.Text);
                fx5 = double.Parse(txtfx5.Text);
                double f1x1, f1x2, f1x3, f1x4, f2x1, f2x2, f2x3, f3x1, f3x2, f4x1, b0, b1, b2, b3, b4 = 0;
                f1x1 = Math.Round((fx2 - fx1) / (x2 - x1), 4);
                f1x2 = Math.Round((fx3 - fx2) / (x3 - x2), 4);
                f1x3 = Math.Round((fx4 - fx3) / (x4 - x3), 4);
                f1x4 = Math.Round((fx5 - fx4) / (x5 - x4), 4);
                f2x1 = Math.Round((f1x2 - f1x1) / (x3 - x1), 4);
                f2x2 = Math.Round((f1x3 - f1x2) / (x4 - x2), 4);
                f2x3 = Math.Round((f1x4 - f1x3) / (x5 - x3), 4);
                f3x1 = Math.Round((f2x2 - f2x1) / (x4 - x1), 4);
                f3x2 = Math.Round((f2x3 - f2x2) / (x5 - x1), 4);
                f4x1 = Math.Round((f3x2 - f3x1) / (x5 - x1), 4);
                b0 = fx1; b1 = f1x1; b2 = f2x1; b3 = f3x1;
                b4 = f4x1;
                double x = double.Parse(txtenterx.Text);
                double answer;
                listBox4.Items.Add(x1 + "\t" + fx1 + "\t" + f1x1 + "\t" + f2x1 + "\t" + f3x1 + "\t" + f4x1);
                listBox4.Items.Add(x2 + "\t" + fx2 + "\t" + f1x2 + "\t" + f2x2 + "\t" + f3x2);
                listBox4.Items.Add(x3 + "\t" + fx3 + "\t" + f1x3 + "\t" + f2x3);
                listBox4.Items.Add(x4 + "\t" + fx4 + "\t" + f1x4);
                listBox4.Items.Add(x5 + "\t" + fx5);
                answer = Math.Round((b0 + (b1 * (x - x1)) + (b2 * (x - x1) * (x - x2)) + (b3 * (x - x1) * (x - x2) * (x - x3)) + (b4 * (x - x1) * (x - x2) * (x - x3) * (x - x4))), 4);
                listBox4.Items.Add("");
                listBox4.Items.Add("==============================================================================");
                listBox4.Items.Add("f(" + x.ToString() + ") =" + answer.ToString());
            }
            catch (SystemException exa) { MessageBox.Show(exa.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtFx.Text = "";
            txta0.Text = "";
            txta1.Text = "";
            gridSize = 0;
            grid.Rows.Clear();
            grid2Size = 0;
            grid2.Rows.Clear();
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ymm, eii, yyy, ymr, eir, yyr, sumeir, sumyyr;
            LinearReg lr = new LinearReg();
            lr.SetGrid(grid);
            lr.solve();
            lr.solveSUM();
            txta0.Text = lr.getA0().ToString();
            txta1.Text = lr.getA1().ToString();

            int num = int.Parse(lr.getN().ToString());
            double ybar = double.Parse(lr.getY().ToString());
            sumeir = 0;
            sumyyr = 0;
            for (int i = 0; i < num; i++)
            {
                ymm = double.Parse(txta0.Text) + (double.Parse(txta1.Text)) * (Double.Parse(grid[1, i].Value.ToString()));
                eii = (Double.Parse(grid[2, i].Value.ToString()) - ymm) * (Double.Parse(grid[2, i].Value.ToString()) - ymm);
                yyy = (Double.Parse(grid[2, i].Value.ToString()) - ybar) * (Double.Parse(grid[2, i].Value.ToString()) - ybar);
                ymr = Math.Round(ymm, 4);
                eir = Math.Round(eii, 4);
                yyr = Math.Round(yyy, 4);
                sumeir += eir;
                sumyyr += yyr;
                grid2.Rows.Add(ymr.ToString(), eir.ToString(), yyr.ToString());

            }
            sumX.Text = "ΣX = " + lr.getSumX().ToString();
            sumY.Text = "ΣY = " + lr.getSumYY().ToString();
            SumX2.Text = "ΣX^2 = " + lr.getSumX2().ToString();
            SumXY.Text = "ΣXY = " + lr.getSumXXY().ToString();
            SumSr.Text = "ΣSr = " + sumeir.ToString();
            SumSr2.Text = "ΣSUM = " + sumyyr.ToString();
            eqlbl.Text = lr.getA0().ToString() + " + " + lr.getA1().ToString() + "x";
        }

        private void cmdIntegrate_Click(object sender, EventArgs e)
        {
            NumIntegration myClass;

            myClass = new NumIntegration();
            double sum, In = 0, h = 0;
            double[] arx, arfx, artr;

            try
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                myClass.setData(int.Parse(tbox_n.Text), double.Parse(tbox_LLimit.Text), double.Parse(tbox_ULimit.Text), tbox_equation.Text.ToString());

                    myClass.useTrapRule(int.Parse(tbox_n.Text), double.Parse(tbox_LLimit.Text), double.Parse(tbox_ULimit.Text), tbox_equation.Text.ToString());
                    for (int i = 0; i < (int.Parse(tbox_n.Text) + 1); i++)
                    {
                        arfx = myClass.getArrFX();
                        arx = myClass.getArrX();
                        artr = myClass.getArrTrap();
                        listBox1.Items.Add(Math.Round(arx[i], 4));
                        listBox2.Items.Add(Math.Round(arfx[i], 4));
                        listBox3.Items.Add(Math.Round(artr[i], 4));

                    }

                    sum = myClass.getSUM();
                    h = Math.Round((double.Parse(tbox_ULimit.Text) - double.Parse(tbox_LLimit.Text)) / (int.Parse(tbox_n.Text)), 4);
                    In = myClass.getI();
                    hlbl.Text = h.ToString();
                    SUMlbl.Text = sum.ToString();
                    Ilbl.Text = In.ToString();

            }
            catch (FormatException a)
            {
                MessageBox.Show(a.Message, "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            tbox_equation.Clear();
            tbox_LLimit.Clear();
            tbox_n.Clear();
            tbox_ULimit.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumDifferentiation myDiff = new NumDifferentiation();
            try
            {
                myDiff.Start(double.Parse(tbox_h.Text), double.Parse(tbox_Xi.Text));
                myDiff.Compute(tbox_equations.Text);
                FFDD.Visible = true;
                myDiff.ForwardDivideDifference(tbox_equations.Text.ToString());
                tbox_diff.Text = myDiff.Display();
                tbox_diffMore.Text = Math.Round(myDiff.getDiffEstiMORE(), 4).ToString();
                XilblF.Text = tbox_Xi.Text;
                FXilblF.Text = Math.Round(myDiff.getFX(), 4).ToString();
                Xi1lblF.Text = Math.Round(myDiff.getXi1(), 4).ToString();
                FXi1lblF.Text = Math.Round(myDiff.getFXi1(), 4).ToString();
                Xi2lblF.Text = Math.Round(myDiff.getXi2(), 4).ToString();
                FXi2lblF.Text = Math.Round(myDiff.getFXi2(), 4).ToString();
            }
            catch (FormatException E)
            {
                MessageBox.Show(E.Message, "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbox_Xi.Clear();
            tbox_equations.Clear();
            tbox_diff.Clear();
            tbox_h.Clear();
        }
    }
}
