using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NewSince.Model;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace NewSince
{

    public partial class Form2 : Form
    {
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        public List<int> FalseIndexses;

        public List<EMZ> emzs;
        public List<EMZToExel> EmzToExels;
        public Form2()
        {
            InitializeComponent();
            FalseIndexses = new List<int>();
            emzs = new List<EMZ>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           DrawLines();
            foreach (var emz in emzs)
            {
                dataGridemz.Rows.Add(emz.numberProfile + " " + emz.RaznosYst, true);
            }
        
           
        }

        private void DrawLines(int without = -1)
        {
            chartEmzGr.Series.Clear();

            int k = 0;
            foreach (var emz in emzs)
            {
                if (!FalseIndexses.Contains(k))
                { 
                    Series line = new Series(emz.numberProfile + " " + emz.RaznosYst + " m");
                    line.IsXValueIndexed = true;
                    line.MarkerSize = 15;
                    //line.BorderWidth = 3;
                    line.ChartType = SeriesChartType.FastPoint;
                    line.Color = emz.LineColor;
                    int i = 0;
                    foreach (var item in emz.DempInf.OrderBy(p => p.Key))
                    {
                        line.Points.AddXY(item.Key, emz.RaznosYst / 3.0);
                        line.Points[i].ToolTip = item.Value.ToString();
                        i++;
                    }
                      chartEmzGr.Series.Add(line);
                 }

                k++;
            }
           
        }
        
        private void chartEmzGr_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.Axis:
                    e.Text = e.HitTestResult.Axis.Name;
                    break;
                case ChartElementType.ScrollBarLargeDecrement:
                    e.Text = "A scrollbar large decrement button";
                    break;
                case ChartElementType.ScrollBarLargeIncrement:
                    e.Text = "A scrollbar large increment button";
                    break;
                case ChartElementType.ScrollBarSmallDecrement:
                    e.Text = "A scrollbar small decrement button";
                    break;
                case ChartElementType.ScrollBarSmallIncrement:
                    e.Text = "A scrollbar small increment button";
                    break;
                case ChartElementType.ScrollBarThumbTracker:
                    e.Text = "A scrollbar tracking thumb";
                    break;
                case ChartElementType.ScrollBarZoomReset:
                    e.Text = "The ZoomReset button of a scrollbar";
                    break;
                case ChartElementType.DataPoint:
                    e.Text = "Точка " + ReturnNamePoint(e.HitTestResult.Series.Name, e.HitTestResult.PointIndex);
                    break;
                case ChartElementType.Gridlines:
                    e.Text = "Grid Lines";
                    break;
                case ChartElementType.LegendArea:
                    e.Text = "Legend Area";
                    break;
                case ChartElementType.LegendItem:
                    e.Text = "Legend Item";
                    break;
                case ChartElementType.PlottingArea:
                    e.Text = "Plotting Area";
                    break;
                case ChartElementType.StripLines:
                    e.Text = "Strip Lines";
                    break;
                case ChartElementType.TickMarks:
                    e.Text = "Tick Marks";
                    break;
                case ChartElementType.Title:
                    e.Text = "Title";
                    break;
            }
        }

        public string ReturnNamePoint(string namem, int index)
        {
            int numProf = int.Parse(namem.Split(' ')[0]);
            int raznos = int.Parse(namem.Split(' ')[1]);

            foreach (var emz in emzs)
            {
                if (emz.numberProfile == numProf && emz.RaznosYst == raznos)
                {
                    int i = 0;
                    foreach (var pkePair in emz.DempInf.OrderBy(p => p.Key))
                    {
                        if (i == index)
                        {
                            return string.Format("X(m) = {0} Y(m) ={1:f3} r эф(Ом*м) = {2:f3}", pkePair.Key, raznos / 3.0, pkePair.Value) ;
                        }
                        i++;

                    }
                }
                //if (numProf == emz.numberProfile && raznos == emz.RaznosYst)
                //{
                //    return "X = " + emz.Raznos.ToArray()[index] + " Y = " + (raznos / 3.0) + " r эф = " +
                //           Math.Round(emz.Ref.ToArray()[index]);
                //}
            }
            return "не найдено";
        }

        

        private void dataGridemz_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridemz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

            if (dataGridemz.RowCount > 0 && e.RowIndex<dataGridemz.RowCount-1)
            {
                dataGridemz.Rows[e.RowIndex].Cells[1].Value = !(bool) dataGridemz.Rows[e.RowIndex].Cells[1].Value;
                if (!(bool) dataGridemz.Rows[e.RowIndex].Cells[1].Value)
                    FalseIndexses.Add(e.RowIndex);
                else
                    FalseIndexses.Remove(e.RowIndex);
                   DrawLines();
            }
            // dataGridemz.Ce  e.RowIndex
        }

        private void BtnExelTable_Click(object sender, EventArgs e)
        {
            if (emzs.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка сохранения", MessageBoxButtons.OK);
            }
            bool invert = false;

            if (MessageBox.Show("Инвертировать значения по X?", "Вопрос визуализации", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
                invert = true;

            EmzToExels = new List<EMZToExel>();
           var AllEMZ = new List<List<EMZToExel>>();
            int k = emzs.FirstOrDefault().numberProfile;
            foreach (var emz in emzs)
            {
                     for (int i = 0; i < emz.Raznos.ToArray().Length; i++)
                    {
                       var t = new EMZToExel();
                        t.Z = emz.RaznosYst / 3.0;
                        t.Pic = invert ? -emz.Raznos.ToArray()[i]: emz.Raznos.ToArray()[i];
                        t.Ref =(int)emz.Ref.ToArray()[i];
                        t.numberProfile = emz.numberProfile;
                        if (t.numberProfile!= k)
                        {
                            AllEMZ.Add(EmzToExels);
                            k = t.numberProfile;
                            EmzToExels = new List<EMZToExel>();

                        }
                    EmzToExels.Add(t);
                        //(emz.Raznos.ToArray()[i], emz.RaznosYst / 3.0);
                       // line.Points[i].ToolTip = emz.Ref.ToArray()[i].ToString();
                       
                    }
                
            }
                AllEMZ.Add(EmzToExels);
            k = 0;
            List<ExcelPackage> packages = new List<ExcelPackage>();
            string[] FileNames = new string[AllEMZ.Count];
           
                using (ExcelPackage eP = new ExcelPackage())
                {
                    foreach (List<EMZToExel> emzToExels in AllEMZ)
                    {
                        var sheet = eP.Workbook.Worksheets.Add(DateTime.Now.Minute+" Profile "+ emzToExels.FirstOrDefault().numberProfile);
                        int row = 1;
                        foreach (var item in emzToExels)
                        {
                            sheet.Cells[row, 1].Value = item.Pic;
                            sheet.Cells[row, 2].Value = -item.Z;
                            sheet.Cells[row, 3].Value = item.Ref;
                            // указываем что в этой ячейке число
                            //sheet.Cells[row, 3].Style.Numberformat.Format = @"#,##0.00_ ;\-#,##0.00_ ;0.00_ ;";

                            row++;
                        }
                       

                    //packages.Add(eP);
                   //     FileNames[k] = emzToExels.FirstOrDefault().numberProfile.ToString();
                     //   k++;
                    }
                    saveFileDialog1.Filter = "Exel files(*.xlsx)|*.xlsx|All files(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filename = saveFileDialog1.FileName;
                    // сохраняем текст в файл
                    var bin = eP.GetAsByteArray();
                    File.WriteAllBytes(filename, bin);
            }
            
            
          //  k = 0;
        //    foreach (var package in packages)
         //   {
                
          //  }
           
            MessageBox.Show("Файлы сохранен");
        }
    }
}
