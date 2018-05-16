using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NewSince.Model;

namespace NewSince
{
    public partial class Form1 : Form
    {
        private List<EMZ> EmzList;
        public Form1()
        {
            InitializeComponent();
            
            EmzList=new List<EMZ>();
        }

        private void BtnAddGraph_Click(object sender, EventArgs e)
        {
            AddGraph add = new AddGraph();
            
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                if (chartEmz.Series.FindByName(add.emz.numberProfile + " " + add.emz.RaznosYst + "m") == null)
                {
                    EmzList.Add(add.emz);
                    DrawEmz();
                    dataGridViewGraph.Rows.Add(add.emz.numberProfile + " " + add.emz.RaznosYst);
                }
                else
                {
                    MessageBox.Show("Данный график уже присутствует в программе",
                        "Сообщение о попытке повторного добавления информации", MessageBoxButtons.OK);

                }
                
            }

        }

        public void DrawEmz(int without = -1)
        {
            chartEmz.Series.Clear();
            
            if (without == -1)
            {
                foreach (var emz in EmzList)
                {

                    Series line = new Series(emz.numberProfile+" "+emz.RaznosYst+"m");
                    line.IsXValueIndexed = true;
                    line.MarkerSize = 3;
                    line.ChartType = emz.TyeChartType;
                    line.Color = emz.LineColor;
                    line.ChartArea = "ChartArea1";
                    
                    foreach (var itemKeyValuePair in emz.DempInf.OrderBy(k=>k.Key))
                    {
                        line.Points.AddXY(itemKeyValuePair.Key, itemKeyValuePair.Value);
                    }
                    line.ToolTip = "Линия: "+emz.numberProfile + " " + emz.RaznosYst + "m";


                    //for (int i = 0; i < emz.Raznos.ToArray().Length; i++)
                    //{
                    //    line.Points.AddXY(emz.Raznos.ToArray()[i], emz.Ref.ToArray()[i]);
                    //}
                    chartEmz.Series.Add(line);

                    //chartEmz.ChartAreas["ChartArea1"].AxisX.IsReversed = false;

                }
            }

        }

        private void ShowGraf_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.emzs = EmzList; 
            form2.Show(this);
        }

        private void dataGridViewGraph_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGraph.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewGraph.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewGraph.Rows[selectedrowindex];

                string profileAndRaznos = Convert.ToString(selectedRow.Cells["Profile"].Value);
                if(profileAndRaznos.Equals("")) return;
                int profile = Convert.ToInt32(profileAndRaznos.Split(' ')[0]);
                int raznos = Convert.ToInt32(profileAndRaznos.Split(' ')[1]);

                List<EMZ> deleteObj = (from p in EmzList
                    where p.numberProfile == profile && p.RaznosYst == raznos
                    select p).ToList();



                if (MessageBox.Show($"Удалить данный график {profileAndRaznos}?", "Удаление графика", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    
                    foreach (var del in deleteObj)
                    {
                        EmzList.Remove(del);

                    }
                    dataGridViewGraph.Rows.RemoveAt(selectedrowindex);
                    
                    chartEmz.Series.Remove(chartEmz.Series.FindByName(profileAndRaznos + "m"));
                }

            }

           
        }
    }
}
