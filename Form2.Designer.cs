namespace NewSince
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridemz = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnExelTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartEmzGr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridemz)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmzGr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BtnExelTable);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            this.toolTip2.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip1"));
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.dataGridemz);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            this.toolTip2.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip1"));
            // 
            // dataGridemz
            // 
            resources.ApplyResources(this.dataGridemz, "dataGridemz");
            this.dataGridemz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridemz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Column2});
            this.dataGridemz.Name = "dataGridemz";
            this.dataGridemz.ReadOnly = true;
            this.dataGridemz.RowTemplate.Height = 24;
            this.toolTip1.SetToolTip(this.dataGridemz, resources.GetString("dataGridemz.ToolTip"));
            this.toolTip2.SetToolTip(this.dataGridemz, resources.GetString("dataGridemz.ToolTip1"));
            this.dataGridemz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridemz_CellContentClick);
            this.dataGridemz.CurrentCellChanged += new System.EventHandler(this.dataGridemz_CurrentCellChanged);
            // 
            // Col1
            // 
            resources.ApplyResources(this.Col1, "Col1");
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // BtnExelTable
            // 
            resources.ApplyResources(this.BtnExelTable, "BtnExelTable");
            this.BtnExelTable.Name = "BtnExelTable";
            this.toolTip1.SetToolTip(this.BtnExelTable, resources.GetString("BtnExelTable.ToolTip"));
            this.toolTip2.SetToolTip(this.BtnExelTable, resources.GetString("BtnExelTable.ToolTip1"));
            this.BtnExelTable.UseVisualStyleBackColor = true;
            this.BtnExelTable.Click += new System.EventHandler(this.BtnExelTable_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chartEmzGr);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            this.toolTip2.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip1"));
            // 
            // chartEmzGr
            // 
            resources.ApplyResources(this.chartEmzGr, "chartEmzGr");
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.Title = "пикеты м";
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.IsReversed = true;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.Title = "глубина м";
            chartArea1.Name = "ChartArea1";
            this.chartEmzGr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEmzGr.Legends.Add(legend1);
            this.chartEmzGr.Name = "chartEmzGr";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 15;
            series1.Name = "Series1";
            this.chartEmzGr.Series.Add(series1);
            this.toolTip2.SetToolTip(this.chartEmzGr, resources.GetString("chartEmzGr.ToolTip"));
            this.toolTip1.SetToolTip(this.chartEmzGr, resources.GetString("chartEmzGr.ToolTip1"));
            this.chartEmzGr.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chartEmzGr_GetToolTipText);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.toolTip2.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridemz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmzGr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmzGr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridView dataGridemz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button BtnExelTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}