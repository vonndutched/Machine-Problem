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

namespace MP2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            myparse = new ExpressionParser();
            myhash = new Hashtable();
            table();
            myparse.Values.Add("x", 0);
        }
        private double xo, x1, x2 = 0.00000, errornum, fxo, fx1, fx2 = 0.000, prevnum = 0.0000, ans, test, xn, xn1, dfxn, fxn;

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        double[] col1 = new double[10];
        double[] col2 = new double[10];
        double[] col3 = new double[10];
        //private int p = 0;
        private ExpressionParser myparse;
        private Hashtable myhash;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton2.Visible = true;
            labelanswer.Visible = true;
            metroButton1.Enabled = false;
            try
            {
                int x = 2, i = 0;
                clear(2);
                get_num(x);
                plot_graph(zedGraphControl1, 2);
                labelfx0.Text = labelfx0.Text + fxo.ToString();
                labelfx1.Text = labelfx1.Text + fx1.ToString();
                labelx0.Text = labelx0.Text + xo.ToString();
                labelx1.Text = labelx1.Text + x1.ToString();
                errornum = double.Parse(metroTextBox2.Text);
                x2 = Math.Round(x1 - (fx1) * ((x1 - xo) / (fx1 - fxo)), 4);
                myparse.Values["x"].SetValue(x2);
                fx2 = Math.Round(myparse.Parse(metroTextBox1.Text), 4);
                while (Math.Round(Math.Abs(x2 - prevnum), 4) > errornum)
                {
                    test = Math.Round(Math.Abs(x2 - prevnum), 4);
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = xo;
                    dataGridView1.Rows[i].Cells[2].Value = x2;
                    dataGridView1.Rows[i].Cells[3].Value = x1;
                    dataGridView1.Rows[i].Cells[4].Value = fxo;
                    dataGridView1.Rows[i].Cells[5].Value = fx2;
                    dataGridView1.Rows[i].Cells[6].Value = fx1;
                    dataGridView1.Rows[i].Cells[7].Value = test;
                    if (i != 0)
                    {
                        prevnum = x2;
                    }
                    xo = Math.Round(x1, 4);
                    x1 = Math.Round(x2, 4);
                    fxo = Math.Round(fx1, 4);
                    fx1 = Math.Round(fx2, 4);
                    x2 = Math.Round(x1 - (fx1) * ((x1 - xo) / (fx1 - fxo)), 4);
                    i++;
                    myparse.Values["x"].SetValue(x2);
                    fx2 = Math.Round(myparse.Parse(metroTextBox1.Text), 4);
                }
                test = Math.Round(Math.Abs(x2 - prevnum), 4);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = xo;
                dataGridView1.Rows[i].Cells[2].Value = x2;
                dataGridView1.Rows[i].Cells[3].Value = x1;
                dataGridView1.Rows[i].Cells[4].Value = fxo;
                dataGridView1.Rows[i].Cells[5].Value = fx2;
                dataGridView1.Rows[i].Cells[6].Value = fx1;
                dataGridView1.Rows[i].Cells[7].Value = test;
                ans = Math.Round(x2, 4);
                labelanswer.Text = labelanswer.Text + ans.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error encountered", MessageBoxButtons.OK);
            }
            zedGraphControl1.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            clear(2);
            metroButton1.Enabled = true;
            metroButton2.Visible = true;
            dataGridView1.Visible = true;
            labelanswer.Visible = true;
            zedGraphControl1.Visible = true;
            metroTextBox1.Clear();
            metroTextBox2.Clear();
        }

        private void get_num(int x)
        {
            switch (x)
            {

                case 2:
                    for (int i = -30; ; i++)
                    {

                        myparse.Values["x"].SetValue(i);
                        xo = i;
                        fxo = Math.Round(myparse.Parse(metroTextBox1.Text), 4);

                        myparse.Values["x"].SetValue((i + 1));
                        x1 = i + 1;
                        fx1 = Math.Round(myparse.Parse(metroTextBox1.Text), 4);
                        if (fx1 != fxo)
                        {
                            break;
                        }
                    }
                    break;

            }
        }
        public void clear(int v)
        {

                labelx0.Text = "Xo :";
                labelx1.Text = "X1 :";
                labelfx0.Text = "f(Xo) :";
                labelfx1.Text = "f(X1) :";
                labelanswer.Text = "Answer :";


            prevnum = 0.00; test = 0.00; x2 = 0.00; x1 = 0.00; xo = 0.00; fxo = 0.0000; fx1 = 0.00;
            ans = 0.00; test = 0.00;

            zedGraphControl1.GraphPane.CurveList.Clear();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            table();
        }
        public void table()
        {

            dataGridView1.Columns.Add("K", "K");
            dataGridView1.Columns.Add("xo", "Xo");
            dataGridView1.Columns.Add("x2", "X2");
            dataGridView1.Columns.Add("x1", "X1");
            dataGridView1.Columns.Add("fxo", "fXo");
            dataGridView1.Columns.Add("fx2", "fX2");
            dataGridView1.Columns.Add("fx1", "fX1");
            dataGridView1.Columns.Add("error", "Error");

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
                x = (double)i * 0.5;
                myparse.Values["x"].SetValue(x);
                y = myparse.Parse(metroTextBox1.Text);
                list1.Add(x, y);
            }
            LineItem myCurve = myPane.AddCurve(metroTextBox1.Text, list1, Color.Violet, SymbolType.Square);

            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Refresh();
        }
    }
}
