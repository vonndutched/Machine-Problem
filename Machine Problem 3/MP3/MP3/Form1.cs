using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MetroFramework.Forms;
using info.lundin.math;
using ZedGraph;

namespace MP3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            myparse = new ExpressionParser();
            myhash = new Hashtable();
            table();
        }

        private double xo, x1, x2 = 0.00000, errornum, fxo, fx1, fx2 = 0.000, prevnum = 0.0000, ans, test;
        private double x3 = 0.000, fx3 = 0.000, a, b, c, D, ho, h1, yo, y1;
        private double l11, l21, l22, l31, l32, l33, u12, u13, u23, r1, r2, r3, ans1, ans2, ans3;

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel35_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel33_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttoncholesky2_Click_1(object sender, EventArgs e)
        {
            clear(4);
            buttoncholesky2.Visible = true;
            buttoncholesky1.Enabled = true;
            txta11.Clear();
            txta12.Clear();
            txta13.Clear();
            txta21.Clear();
            txta22.Clear();
            txta23.Clear();
            txta31.Clear();
            txta32.Clear();
            txta33.Clear();
            txtc11.Clear();
            txtc21.Clear();
            txtc31.Clear();
        }

        private void buttongauss2_Click_1(object sender, EventArgs e)
        {
            clear(5);
            buttongauss2.Visible = true;
            txt4a11.Clear();
            txt4a12.Clear();
            txt4a13.Clear();
            txt4a21.Clear();
            txt4a22.Clear();
            txt4a23.Clear();
            txt4a31.Clear();
            txt4a32.Clear();
            txt4a33.Clear();
            txt4c11.Clear();
            txt4c21.Clear();
            txt4c31.Clear();
            txterror5.Clear();
            dataTable5.Rows.Clear();
            dataTable5.Columns.Clear();
            dataTable5.Visible = true;
            buttongauss1.Enabled = true;
            iterr1.Text = "";
            iterr2.Text = "";
            iterr3.Text = "";
        }

        private void buttongauss1_Click(object sender, EventArgs e)
        {
            a11 = double.Parse(txt4a11.Text);
            a12 = double.Parse(txt4a12.Text);
            a13 = double.Parse(txt4a13.Text);
            c11 = double.Parse(txt4c11.Text);
            a21 = double.Parse(txt4a21.Text);
            a22 = double.Parse(txt4a22.Text);
            a23 = double.Parse(txt4a23.Text);
            c21 = double.Parse(txt4c21.Text);
            a31 = double.Parse(txt4a31.Text);
            a32 = double.Parse(txt4a32.Text);
            a33 = double.Parse(txt4a33.Text);
            c31 = double.Parse(txt4c31.Text);
            if (a11 > a21 && a11 > a31)
            {
                if (a22 > a12 && a22 > a32)
                {
                    if (a33 > a13 && a33 > a23)
                    {

                        buttongauss2.Visible = true;
                        dataTable5.Visible = true;
                        buttongauss1.Enabled = false;
                        iterr1.Text = "(" + c11 + "+" + (-1) * a12 + "y" + "+" + (-1) * a13 + "z" + ") / (" + a11 + ")";
                        iterr2.Text = "(" + c21 + "+" + (-1) * a21 + "x" + "+" + (-1) * a23 + "z" + ") / (" + a22 + ")";
                        iterr3.Text = "(" + c31 + "+" + (-1) * a31 + "x" + "+" + (-1) * a32 + "y" + ") / (" + a33 + ")";
                        clear(5);
                        int i;
                        try
                        {
                            errornum = double.Parse(txterror5.Text);
                            for (i = 0; ; i++)
                            {

                                tempvs1 = vs1;
                                tempvs2 = vs2;
                                tempvs3 = vs3;

                                myhash.Clear();
                                myhash.Add("x", tempvs1.ToString());
                                myhash.Add("y", tempvs2.ToString());
                                myhash.Add("z", tempvs3.ToString());
                                vs1 = Math.Round(myparse.Parse(iterr1.Text, myhash), 4);
                                vs2 = Math.Round(myparse.Parse(iterr2.Text, myhash), 4);
                                vs3 = Math.Round(myparse.Parse(iterr3.Text, myhash), 4);
                                etests1 = Math.Abs(vs1 - tempvs1);
                                etests2 = Math.Abs(vs2 - tempvs2);
                                etests3 = Math.Abs(vs3 - tempvs3);
                                dataTable5.Rows.Add();
                                dataTable5.Rows[i].Cells[0].Value = i + 1;
                                dataTable5.Rows[i].Cells[1].Value = vs1;
                                dataTable5.Rows[i].Cells[2].Value = vs2;
                                dataTable5.Rows[i].Cells[3].Value = vs3;
                                dataTable5.Rows[i].Cells[4].Value = etests1;
                                dataTable5.Rows[i].Cells[5].Value = etests2;
                                dataTable5.Rows[i].Cells[6].Value = etests3;
                                if ((etests1 < errornum) && (etests2 < errornum) && (etests3 < errornum))
                                {
                                    break;
                                }
                            }
                            label5X.Text = label5X.Text + Math.Round(vs1, 4).ToString();
                            label5Y.Text = label5Y.Text + Math.Round(vs2, 4).ToString();
                            label5Z.Text = label5Z.Text + Math.Round(vs3, 4).ToString();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Error encountered", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The dominant coefficient should be in main diagonal", "Error encountered", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("The dominant coefficient should be in main diagonal", "Error encountered", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("The dominant coefficient should be in main diagonal", "Error encountered", MessageBoxButtons.OK);
            }
        }

        private void buttoncholesky1_Click_1(object sender, EventArgs e)
        {
            buttoncholesky2.Visible = true;
            buttoncholesky1.Enabled = false;
            try
            {
                clear(4);
                l11 = double.Parse(txta11.Text);
                l21 = double.Parse(txta21.Text);
                l31 = double.Parse(txta31.Text);
                u13 = double.Parse(txta12.Text) / l11;
                u12 = double.Parse(txta13.Text) / l11;
                l22 = double.Parse(txta22.Text) - (l21 * u13);
                l32 = double.Parse(txta32.Text) - (l31 * u13);
                u23 = (double.Parse(txta23.Text) - (l21 * u12)) / l22;
                l33 = double.Parse(txta33.Text) - (l31 * u12) - (l32 * u23);
                r1 = double.Parse(txtc11.Text) / l11;
                r2 = (double.Parse(txtc21.Text) - (l21 * r1)) / l22;
                r3 = (double.Parse(txtc31.Text) - (l32 * r2) - (l31 * r1)) / l33;
                ans3 = r3;
                ans2 = r2 - (u23 * ans3);
                ans1 = r1 - (u12 * ans3) - (u13 * ans2);
                clabelx1.Text = clabelx1.Text + Math.Round(ans1, 4).ToString();
                clabelx2.Text = clabelx2.Text + Math.Round(ans2, 4).ToString();
                clabelx3.Text = clabelx3.Text + Math.Round(ans3, 4).ToString();
                labL11.Text = Math.Round(l11, 2).ToString();
                labL21.Text = Math.Round(l21, 2).ToString();
                labL31.Text = Math.Round(l31, 2).ToString();
                labL32.Text = Math.Round(l32, 2).ToString();
                labL33.Text = Math.Round(l33, 2).ToString();
                labL22.Text = Math.Round(l22, 2).ToString();
                labU12.Text = Math.Round(u12, 2).ToString();
                labU13.Text = Math.Round(u13, 2).ToString();
                labU23.Text = Math.Round(u23, 2).ToString();
                labC11.Text = Math.Round(double.Parse(txtc11.Text), 1).ToString();
                labC21.Text = Math.Round(double.Parse(txtc21.Text), 1).ToString();
                labC31.Text = Math.Round(double.Parse(txtc31.Text), 1).ToString();
                labR1.Text = Math.Round(r1, 2).ToString();
                labR2.Text = Math.Round(r2, 2).ToString();
                labR3.Text = Math.Round(r3, 2).ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error encountered", MessageBoxButtons.OK);
            }
        }

        private void buttonmuller2_Click_1(object sender, EventArgs e)
        {
            clear(3);
            buttonmuller1.Enabled = true;
            buttonmuller2.Visible = true;
            dataGridView1.Visible = true;
            labelanswermuller.Visible = false;
            txtmuller1.Clear();
            txtmuller2.Clear();
        }

        private void buttonmuller1_Click(object sender, EventArgs e)
        {

            buttonmuller2.Visible = true;
            dataGridView1.Visible = true;
            labelanswermuller.Visible = true;
            buttonmuller1.Enabled = false;
            try
            {
                int x = 3, i = 0;
                double tempd;
                clear(3);
                get_num(x);

                errornum = double.Parse(txtmuller2.Text);
                labelx0.Text = labelx0.Text + xo.ToString();
                labelx1.Text = labelx1.Text + x1.ToString();
                labelx2.Text = labelx2.Text + x2.ToString();
                labelfx0.Text = labelfx0.Text + fxo.ToString();
                labelfx1.Text = labelfx1.Text + fx1.ToString();
                labelfx2.Text = labelfx2.Text + fx2.ToString();
                do
                {
                    ho = Math.Round(x1 - xo, 4);
                    h1 = Math.Round(x2 - x1, 4);
                    yo = Math.Round((fx1 - fxo) / ho, 4);
                    y1 = Math.Round((fx2 - fx1) / h1, 4);
                    a = Math.Round((y1 - yo) / (h1 + ho), 4);
                    b = Math.Round((a * h1) + y1, 4);
                    c = Math.Round(fx2, 4);
                    tempd = Math.Round(Math.Pow(b, 2) - (4 * a * c), 4);
                    if (tempd > 0)
                    {
                        D = Math.Round(Math.Sqrt(tempd), 4);
                        if (Math.Abs(b + D) > Math.Abs(b - D))
                        {
                            x3 = Math.Round(x2 - ((2 * c) / (b + D)), 4);
                        }
                        else
                        {
                            x3 = Math.Round(x2 - ((2 * c) / (b - D)), 4);
                        }
                        myhash.Clear();
                        myhash.Add("x", x3.ToString());
                        fx3 = Math.Round(myparse.Parse(txtmuller1.Text, myhash), 4);
                        test = Math.Round(Math.Abs((x3 - x2) / x3) * 100, 4);
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = xo;
                        dataGridView1.Rows[i].Cells[2].Value = x1;
                        dataGridView1.Rows[i].Cells[3].Value = x2;
                        dataGridView1.Rows[i].Cells[4].Value = fxo;
                        dataGridView1.Rows[i].Cells[5].Value = fx1;
                        dataGridView1.Rows[i].Cells[6].Value = fx2;
                        dataGridView1.Rows[i].Cells[7].Value = ho;
                        dataGridView1.Rows[i].Cells[8].Value = h1;
                        dataGridView1.Rows[i].Cells[9].Value = yo;
                        dataGridView1.Rows[i].Cells[10].Value = y1;
                        dataGridView1.Rows[i].Cells[11].Value = a;
                        dataGridView1.Rows[i].Cells[12].Value = b;
                        dataGridView1.Rows[i].Cells[13].Value = c;
                        dataGridView1.Rows[i].Cells[14].Value = D;
                        dataGridView1.Rows[i].Cells[15].Value = x3;
                        dataGridView1.Rows[i].Cells[16].Value = fx3;
                        dataGridView1.Rows[i].Cells[17].Value = test;
                        xo = x1; x1 = x2; x2 = x3;
                        fxo = fx1; fx1 = fx2; fx2 = fx3;
                        i++;
                    }
                    else
                    {
                        clear(3);
                        get_num(x);
                        labelx0.Text = labelx0.Text + xo.ToString();
                        labelx1.Text = labelx1.Text + x1.ToString();
                        labelx2.Text = labelx2.Text + x2.ToString();
                        labelfx0.Text = labelfx0.Text + fxo.ToString();
                        labelfx1.Text = labelfx1.Text + fx1.ToString();
                        labelfx2.Text = labelfx2.Text + fx2.ToString();
                        test = 1000;
                    }
                } while (test >= errornum);
                ans = Math.Round(x3, 4);
                labelanswermuller.Text = labelanswermuller.Text + ans.ToString();
                p = 0;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error encountered", MessageBoxButtons.OK);
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void labL11_Click(object sender, EventArgs e)
        {

        }

        double a11, a12, a13, a21, a22, a23, a31, a32, a33, c11, c21, c31;
        double vs1 = 0, vs2 = 0, vs3 = 0, tempvs1 = 0, tempvs2 = 0, tempvs3 = 0, etests1, etests2, etests3;
        double[] col1 = new double[10];
        double[] col2 = new double[10];
        double[] col3 = new double[10];
        private int p = 0;
        private ExpressionParser myparse;
        private Hashtable myhash;

        private void get_num(int x)
        {
            switch (x)
            {


                case 3:
                    myhash.Clear();
                    myhash.Add("x", (p).ToString());
                    xo = p;
                    fxo = Math.Round(myparse.Parse(txtmuller1.Text, myhash), 4);
                    myhash.Clear();
                    myhash.Add("x", (p + 1).ToString());
                    x1 = p + 1;
                    fx1 = Math.Round(myparse.Parse(txtmuller1.Text, myhash), 4);
                    myhash.Clear();
                    myhash.Add("x", (p + 2).ToString());
                    x2 = p + 2;
                    fx2 = Math.Round(myparse.Parse(txtmuller1.Text, myhash), 4);
                    p = p + 3;
                    break;

            }
        }
        public void clear(int v)
        {

            if (v == 3)
            {
                labelx0.Text = "X0 :";
                labelx1.Text = "X1 :";
                labelx2.Text = "X2 :";
                labelfx0.Text = "f(X0) :";
                labelfx1.Text = "f(X1) :";
                labelfx2.Text = "f(X2) :";
                labelanswermuller.Text = "Answer :";
            }
            else if (v == 4)
            {
                clabelx1.Text = "X1 :";
                clabelx2.Text = "X2 :";
                clabelx3.Text = "X3 :";
                labL11.Text = "L11";
                labL21.Text = "L21";
                labL31.Text = "L31";
                labL32.Text = "L32";
                labL33.Text = "L33";
                labL22.Text = "L22";
                labU12.Text = "U12";
                labU13.Text = "U13";
                labU23.Text = "U21";
                labC11.Text = "C11";
                labC21.Text = "C21";
                labC31.Text = "C21";
                labR1.Text = "R1";
                labR2.Text = "R2";
                labR3.Text = "R3";
            }
            else if (v == 5)
            {
                label5X.Text = "X :";
                label5Y.Text = "Y :";
                label5Z.Text = "Z :";
            }

            prevnum = 0.00; test = 0.00; x2 = 0.00; x1 = 0.00; xo = 0.00; fxo = 0.0000; fx1 = 0.00;
            ans = 0.00; test = 0.00; x3 = 0.00; fx3 = 0.00;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataTable5.Rows.Clear();
            dataTable5.Columns.Clear();

            table();
        }
        public void table()
        {


            dataGridView1.Columns.Add("K", "K");
            dataGridView1.Columns.Add("x0", "X0");
            dataGridView1.Columns.Add("x2", "X2");
            dataGridView1.Columns.Add("x1", "X1");
            dataGridView1.Columns.Add("fxo", "fXo");
            dataGridView1.Columns.Add("fx2", "fX2");
            dataGridView1.Columns.Add("fx1", "fX1");
            dataGridView1.Columns.Add("ho", "ho");
            dataGridView1.Columns.Add("h1", "h1");
            dataGridView1.Columns.Add("yo", "yo");
            dataGridView1.Columns.Add("y1", "y1");
            dataGridView1.Columns.Add("a", "a");
            dataGridView1.Columns.Add("b", "b");
            dataGridView1.Columns.Add("c", "c");
            dataGridView1.Columns.Add("D", "D");
            dataGridView1.Columns.Add("x3", "X3");
            dataGridView1.Columns.Add("fx3", "fX3");
            dataGridView1.Columns.Add("error", "Error");


            dataTable5.Columns.Add("K", "K");
            dataTable5.Columns.Add("X", "X");
            dataTable5.Columns.Add("Y", "Y");
            dataTable5.Columns.Add("Z", "Z");
            dataTable5.Columns.Add("error", "error(X)");
            dataTable5.Columns.Add("error", "error(Y)");
            dataTable5.Columns.Add("error", "error(Z)");


        }
        private void plot_graph(ZedGraphControl zgc, int a)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles

            myPane.Title.Text = "Graph of Curve";
            myPane.XAxis.Title.Text = "X Coordinates";
            myPane.YAxis.Title.Text = "Y Coordinates";

            PointPairList list1 = new PointPairList();

            double y = 0;
            double x;
            for (int i = -25; i < 26; i++)
            {
                myhash.Clear();
                x = (double)i * 0.5;
                myhash.Add("x", x.ToString());

                if (a == 3)
                {
                    y = myparse.Parse(txtmuller1.Text, myhash);
                }

                list1.Add(x, y);
            }
            LineItem myCurve = myPane.AddCurve(txtmuller1.Text, list1, Color.Violet, SymbolType.Square);

            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
