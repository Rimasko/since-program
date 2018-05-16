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

namespace NewSince
{
    public partial class AddGraph : Form
    {
        public EMZ emz;
        public bool download;
        public AddGraph()
        {
            download = false;
            InitializeComponent();
            emz = new EMZ();
            emz.TyeChartType = SeriesChartType.Line;
        }

        private void DownloadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "Exel files(*.xls;*.xlsx)|*.xls;*.xlsx|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                download = false;
                string FilePath = dialog.FileName;
                emz.name = FilePath;
                FileInfo existingFile = new FileInfo(FilePath);
                try
                {
                    using (ExcelPackage package = new ExcelPackage(existingFile))
                    {


                        emz.Raznos = new List<double>();
                        emz.Ref = new List<double>();
                        emz.DempInf = new Dictionary<double, double>();

                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                        int j = 1;
                        emz.numberProfile = int.Parse(worksheet.Cells[j, 1].Value.ToString().Split('.')[0]);
                        emz.RaznosYst = int.Parse(worksheet.Cells[1, 3].Value.ToString());
                        do
                        {
                            try
                            {

                                emz.Raznos.Add(Double.Parse(worksheet.Cells[j, 1].Value.ToString().Split('.')[1]));
                                emz.Ref.Add(Double.Parse(worksheet.Cells[j, 2].Value.ToString()));
                                emz.DempInf.Add(Double.Parse(worksheet.Cells[j, 1].Value.ToString().Split('.')[1]), Double.Parse(worksheet.Cells[j, 2].Value.ToString()));

                            }
                            catch (Exception Ex)
                            {
                                if (emz.RaznosYst > 0 && emz.Raznos.Count > 0)
                                {
                                    MessageBox.Show("Считано удачно");
                                    download = true;
                                }
                                else
                                {
                                    MessageBox.Show("Данный файл не считан, по пробуйте другой.");
                                }
                                return;

                            }
                            j++;
                            //Console.WriteLine(p1 + " " + d1 + " " + fpr1);
                        } while (true);

                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("Данный тип файлов не поддерживается, откройте файл формата xls или xlsx ");
                }
                
            }
        }

        private void LineColorPick_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);

            emz.LineColor = colorDialog1.Color;
        }

        private void comboLines_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = int.Parse(comboLines.SelectedIndex.ToString());
            emz.TyeChartType = SeriesChartType.Spline;
            if (comboLines.Items[index].ToString().Equals("Spline"))
                emz.TyeChartType = SeriesChartType.Spline;
            if (comboLines.Items[index].ToString().Equals("SplineArea"))
                emz.TyeChartType = SeriesChartType.SplineArea;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (download == true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Информация о графике не загружена,\n добавьте файл либо закройте окно добавленя");
            }

        }
    }
}
