namespace MP2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Bisection = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.labelfx1 = new MetroFramework.Controls.MetroLabel();
            this.labelx1 = new MetroFramework.Controls.MetroLabel();
            this.labelfx0 = new MetroFramework.Controls.MetroLabel();
            this.labelx0 = new MetroFramework.Controls.MetroLabel();
            this.labelanswer = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.metroTabControl1.SuspendLayout();
            this.Bisection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Bisection);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 64);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(834, 471);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Bisection
            // 
            this.Bisection.Controls.Add(this.metroButton2);
            this.Bisection.Controls.Add(this.labelfx1);
            this.Bisection.Controls.Add(this.labelx1);
            this.Bisection.Controls.Add(this.labelfx0);
            this.Bisection.Controls.Add(this.labelx0);
            this.Bisection.Controls.Add(this.labelanswer);
            this.Bisection.Controls.Add(this.dataGridView1);
            this.Bisection.Controls.Add(this.metroButton1);
            this.Bisection.Controls.Add(this.metroTextBox2);
            this.Bisection.Controls.Add(this.metroLabel2);
            this.Bisection.Controls.Add(this.metroTextBox1);
            this.Bisection.Controls.Add(this.metroLabel1);
            this.Bisection.Controls.Add(this.zedGraphControl1);
            this.Bisection.HorizontalScrollbarBarColor = true;
            this.Bisection.HorizontalScrollbarHighlightOnWheel = false;
            this.Bisection.HorizontalScrollbarSize = 8;
            this.Bisection.Location = new System.Drawing.Point(4, 38);
            this.Bisection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bisection.Name = "Bisection";
            this.Bisection.Size = new System.Drawing.Size(826, 429);
            this.Bisection.TabIndex = 0;
            this.Bisection.Text = "SECANT METHOD";
            this.Bisection.VerticalScrollbarBarColor = true;
            this.Bisection.VerticalScrollbarHighlightOnWheel = false;
            this.Bisection.VerticalScrollbarSize = 9;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(262, 9);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(87, 28);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // labelfx1
            // 
            this.labelfx1.AutoSize = true;
            this.labelfx1.Location = new System.Drawing.Point(659, 36);
            this.labelfx1.Name = "labelfx1";
            this.labelfx1.Size = new System.Drawing.Size(45, 19);
            this.labelfx1.TabIndex = 13;
            this.labelfx1.Text = "f(X1) : ";
            // 
            // labelx1
            // 
            this.labelx1.AutoSize = true;
            this.labelx1.Location = new System.Drawing.Point(534, 36);
            this.labelx1.Name = "labelx1";
            this.labelx1.Size = new System.Drawing.Size(33, 19);
            this.labelx1.TabIndex = 12;
            this.labelx1.Text = "X1 : ";
            // 
            // labelfx0
            // 
            this.labelfx0.AutoSize = true;
            this.labelfx0.Location = new System.Drawing.Point(659, 9);
            this.labelfx0.Name = "labelfx0";
            this.labelfx0.Size = new System.Drawing.Size(47, 19);
            this.labelfx0.TabIndex = 11;
            this.labelfx0.Text = "f(X0) : ";
            // 
            // labelx0
            // 
            this.labelx0.AutoSize = true;
            this.labelx0.Location = new System.Drawing.Point(534, 9);
            this.labelx0.Name = "labelx0";
            this.labelx0.Size = new System.Drawing.Size(35, 19);
            this.labelx0.TabIndex = 10;
            this.labelx0.Text = "X0 : ";
            // 
            // labelanswer
            // 
            this.labelanswer.AutoSize = true;
            this.labelanswer.Location = new System.Drawing.Point(357, 36);
            this.labelanswer.Name = "labelanswer";
            this.labelanswer.Size = new System.Drawing.Size(74, 19);
            this.labelanswer.TabIndex = 9;
            this.labelanswer.Text = "ANSWER : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 348);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(262, 33);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(87, 31);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Compute";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(125, 36);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(131, 28);
            this.metroTextBox2.TabIndex = 6;
            this.metroTextBox2.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-5, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "RELATIVE ERROR = ";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(125, 9);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(131, 28);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "f(x) = ";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 71);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(401, 348);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 537);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "MACHINE PROBLEM 2";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.Bisection.ResumeLayout(false);
            this.Bisection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Bisection;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel labelfx1;
        private MetroFramework.Controls.MetroLabel labelx1;
        private MetroFramework.Controls.MetroLabel labelfx0;
        private MetroFramework.Controls.MetroLabel labelx0;
        private MetroFramework.Controls.MetroLabel labelanswer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}

