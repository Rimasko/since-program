namespace NewSince
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowGraf = new System.Windows.Forms.Button();
            this.BtnAddGraph = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartEmz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewGraph = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ShowGraf);
            this.groupBox1.Controls.Add(this.BtnAddGraph);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(507, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(241, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ShowGraf
            // 
            this.ShowGraf.Location = new System.Drawing.Point(22, 93);
            this.ShowGraf.Margin = new System.Windows.Forms.Padding(2);
            this.ShowGraf.Name = "ShowGraf";
            this.ShowGraf.Size = new System.Drawing.Size(190, 49);
            this.ShowGraf.TabIndex = 1;
            this.ShowGraf.Text = "Показать в разрезе";
            this.ShowGraf.UseVisualStyleBackColor = true;
            this.ShowGraf.Click += new System.EventHandler(this.ShowGraf_Click);
            // 
            // BtnAddGraph
            // 
            this.BtnAddGraph.Location = new System.Drawing.Point(22, 25);
            this.BtnAddGraph.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddGraph.Name = "BtnAddGraph";
            this.BtnAddGraph.Size = new System.Drawing.Size(190, 38);
            this.BtnAddGraph.TabIndex = 0;
            this.BtnAddGraph.Text = "Добавить график";
            this.BtnAddGraph.UseVisualStyleBackColor = true;
            this.BtnAddGraph.Click += new System.EventHandler(this.BtnAddGraph_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartEmz);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(507, 492);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chartEmz
            // 
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.Title = "Пк м";
            chartArea1.AxisX2.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Title = "р эф Ом*м";
            chartArea1.AxisY2.Crossing = -1.7976931348623157E+308D;
            chartArea1.Name = "ChartArea1";
            this.chartEmz.ChartAreas.Add(chartArea1);
            this.chartEmz.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEmz.Legends.Add(legend1);
            this.chartEmz.Location = new System.Drawing.Point(2, 15);
            this.chartEmz.Margin = new System.Windows.Forms.Padding(2);
            this.chartEmz.Name = "chartEmz";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ToolTip = "sdfsdf";
            this.chartEmz.Series.Add(series1);
            this.chartEmz.Size = new System.Drawing.Size(503, 475);
            this.chartEmz.TabIndex = 0;
            this.chartEmz.Text = "chart1";
            // 
            // dataGridViewGraph
            // 
            this.dataGridViewGraph.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profile});
            this.dataGridViewGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGraph.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGraph.Name = "dataGridViewGraph";
            this.dataGridViewGraph.ReadOnly = true;
            this.dataGridViewGraph.Size = new System.Drawing.Size(237, 324);
            this.dataGridViewGraph.TabIndex = 2;
            this.dataGridViewGraph.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGraph_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewGraph);
            this.panel1.Location = new System.Drawing.Point(3, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 324);
            this.panel1.TabIndex = 3;
            // 
            // Profile
            // 
            this.Profile.HeaderText = "Провиль и разнос";
            this.Profile.Name = "Profile";
            this.Profile.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Главное окно";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmz;
        private System.Windows.Forms.Button ShowGraf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profile;
    }
}

